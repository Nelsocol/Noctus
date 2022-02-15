using System;
using System.Collections.Generic;
using System.Text;

namespace NoctusEngine
{
    public class ConsoleInputChannel : IInputChannel
    {
        public Link SelectLink(List<Link> links)
        {
            if (links.Count == 1) 
            {
                return links[0];
            }

            int input = 0;
            while (!int.TryParse(Console.ReadLine(), out input) || input <= 0 || input > links.Count) ;
            return links[input - 1];
        }
    }
}
