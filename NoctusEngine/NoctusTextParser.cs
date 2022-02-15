using NLua;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace NoctusEngine
{
    public class NoctusTextParser
    {
        Lua LuaContext { get; }

        public NoctusTextParser(Lua luaContext) 
        {
            LuaContext = luaContext;
        }

        public Link ParseLink(string input, string rootDirectory) 
        {
            LinkDataBuffer linkBuffers = new LinkDataBuffer(input);
            Link returnLink = new Link(ParsePassage(linkBuffers.Buffers['\0'], rootDirectory)[0], ParsePassage(linkBuffers.Buffers['>'], rootDirectory)[0], linkBuffers.Buffers['#'], linkBuffers.Buffers['<']);
            if (linkBuffers.Buffers['?'] != "") 
            {
                returnLink.ShowState = (bool)LuaContext.DoString($"return {linkBuffers.Buffers['?']}")[0];
            }

            return returnLink;
        }

        public List<string> ParsePassage(string rawText, string rootdirectory) 
        {
            if (rawText != null)
            {
                List<StringBuilder> parsedLines = new List<StringBuilder>();
                StringBuilder currentLine = new StringBuilder();

                bool recursivePotential = false;
                string[] lines = rawText.Split("\r\n", StringSplitOptions.RemoveEmptyEntries);
                foreach (string line in lines)
                {
                    if (line == "##")
                    {
                        parsedLines.Add(null);
                    }
                    else
                    {
                        string[] splitLine = line.Split(new string[] { " ", "\n\r" }, StringSplitOptions.RemoveEmptyEntries);

                        for (int i = 0; i < splitLine.Count(); i++)
                        {
                            currentLine.Append($"{ParseWord(splitLine, rootdirectory, ref i, ref recursivePotential)} ");
                        }

                        parsedLines.Add(currentLine);
                        currentLine = new StringBuilder();
                    }
                }

                //Handles the recursive step to recursively evaluate passages
                List<string> recursiveReturnList = new List<string>();
                if (recursivePotential)
                {
                    foreach (string line in parsedLines.Select(e => e == null ? null : e.ToString().Trim()))
                    {
                        recursiveReturnList.AddRange(ParsePassage(line, rootdirectory));
                    }
                }
                else
                {
                    recursiveReturnList = parsedLines.Select(e => e == null ? null : e.ToString().Trim()).ToList();
                }

                return recursiveReturnList;
            }
            else
            {
                return new List<string>() { null };
            }
        }

        private string ParseWord(string[] line,string rootDirectory, ref int iterator, ref bool recursivePotential) 
        {

            if (line[iterator].StartsWith("${"))
            {
                recursivePotential = true;
                return LuaContext.DoString($"return {ParseCodeBlock(line, "}", ref iterator)}")[0]?.ToString() ?? "MALFORMED_STATEMENT";
            }
            else if (line[iterator].StartsWith("$["))
            {
                recursivePotential = true;
                LuaContext.DoString($"{ParseCodeBlock(line, "]", ref iterator)}");
                return "";
            }
            else if (line[iterator].StartsWith("$>"))
            {
                recursivePotential = true;
                LuaContext.DoString(File.ReadAllText(Directory.GetFiles(rootDirectory, $"{line[iterator][2..]}.lua", SearchOption.AllDirectories)[0]));
                return File.ReadAllText(Directory.GetFiles(rootDirectory, $"{line[iterator][2..]}.txt", SearchOption.AllDirectories)[0]);
            }
            else if (line[iterator].StartsWith("$"))
            {
                recursivePotential = true;
                return LuaContext.DoString($"return {line[iterator][1..]}")[0]?.ToString() ?? "UNASSIGNED_VAR";
            }

            return line[iterator];
        }

        private string ParseCodeBlock(string[] line, string endDelimiter, ref int iterator)
        {
            StringBuilder codeFragment = new StringBuilder();

            if (line[iterator].EndsWith(endDelimiter))
            {
                codeFragment.Append(line[iterator]);
            }
            else
            {
                while (!line[iterator].EndsWith(endDelimiter))
                {
                    codeFragment.Append(line[iterator] + " ");
                    iterator++;
                }

                codeFragment.Append(line[iterator]);
            }

            return codeFragment.ToString()[2..^1];
        }
    }
}
