using NLua;
using System;
using System.Collections.Generic;
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

        public Link ParseLink(string input) 
        {
            LinkDataBuffer linkBuffers = new LinkDataBuffer(input);
            Link returnLink = new Link(ParsePassage(linkBuffers.Buffers['\0'])[0], ParsePassage(linkBuffers.Buffers['>'])[0], linkBuffers.Buffers['#']);
            if (linkBuffers.Buffers['?'] != "") 
            {
                returnLink.ShowState = (bool)LuaContext.DoString($"return {linkBuffers.Buffers['?']}")[0];
            }

            return returnLink;
        }

        public List<string> ParsePassage(string rawText) 
        {
            List<StringBuilder> parsedLines = new List<StringBuilder>();
            StringBuilder currentLine = new StringBuilder();

            string[] lines = rawText.Split("\r\n", StringSplitOptions.RemoveEmptyEntries);
            foreach (string line in lines) {
                string[] splitLine = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < splitLine.Count(); i++)
                {           
                    currentLine.Append($"{ParseWord(splitLine, ref i)} ");
                }

                parsedLines.Add(currentLine);
                currentLine = new StringBuilder();
            }

            return parsedLines.Select(e => e.ToString().Trim()).ToList();
        }

        private string ParseWord(string[] line, ref int iterator) 
        {
            if (line[iterator].StartsWith("${"))
            {
                return LuaContext.DoString($"return {ParseCodeBlock(line, "}", ref iterator)}")[0]?.ToString() ?? "MALFORMED_STATEMENT";
            }
            else if (line[iterator].StartsWith("$["))
            {
                LuaContext.DoString($"{ParseCodeBlock(line, "]", ref iterator)}");
                return "";
            }
            else if (line[iterator].StartsWith("$"))
            {
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
