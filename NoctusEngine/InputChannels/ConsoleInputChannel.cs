using System;
using System.Collections.Generic;
using System.Text;

namespace NoctusEngine
{
    public class ConsoleInputChannel: IInputChannel
    {
        public Link SelectLink(List<Link> links)
        {
            int input = 0;
            while (!int.TryParse(Console.ReadLine(), out input) || input <= 0 || input > links.Count) ;
            return links[input - 1];
        }
    }
}
