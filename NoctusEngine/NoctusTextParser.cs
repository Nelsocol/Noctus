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
            string[] components = input.Split(new string[1]{"->"}, StringSplitOptions.RemoveEmptyEntries);
            Link returnLink = new Link(components[0], components[1]);
            return returnLink;
        }

        public List<string> ParsePassage(string rawText) 
        {
            List<StringBuilder> parsedLines = new List<StringBuilder>();
            StringBuilder currentLine = new StringBuilder();

            string[] lines = rawText.Split("\r\n", StringSplitOptions.RemoveEmptyEntries);
            foreach (string line in lines) {
                string[] splitLine = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                foreach (string word in splitLine)
                {           
                    currentLine.Append($"{ParseWord(word)} ");
                }

                parsedLines.Add(currentLine);
                currentLine = new StringBuilder();
            }

            return parsedLines.Select(e => e.ToString()).ToList();
        }

        private string ParseWord(string word) 
        {
            if (word.StartsWith("$"))
            {
                return LuaContext[word[1..]]?.ToString() ?? "UNASSIGNED_VAR";
            }

            return word;
        }
    }
}
