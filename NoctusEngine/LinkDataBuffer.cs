using System;
using System.Collections.Generic;
using System.Text;

namespace NoctusEngine
{
    public class LinkDataBuffer
    {
        private char currentBuffer = '\0';

        public Dictionary<char, string> Buffers = new Dictionary<char, string>()
        {
            { '\0', ""},
            { '>', ""},
            { '?', ""},
            { '#', ""},
            { '<', ""}
        };

        public LinkDataBuffer(string linkString) 
        {
            //Sort characters into relevant buffers
            int iterator = 0;
            while (iterator < linkString.Length)
            {
                if (linkString[iterator] == '|')
                {
                    iterator++;
                    currentBuffer = linkString[iterator];
                    Buffers[linkString[iterator]] = string.Empty;
                }
                else 
                {
                    Buffers[currentBuffer] += linkString[iterator];
                }
                iterator++;
            }

            //Trim problematic spaces
            char[] identifiers = new char[Buffers.Count];
            Buffers.Keys.CopyTo(identifiers, 0);
            foreach (char identifier in identifiers) 
            {
                Buffers[identifier] = Buffers[identifier].Trim();
            }
        } 
    }
}
