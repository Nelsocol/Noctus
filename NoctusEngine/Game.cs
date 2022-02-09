using NLua;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NoctusEngine
{
    public class Game
    {
        private Lua LuaContext { get; }
        private NoctusTextParser Parser { get; }
        private IInputChannel InputChannel { get; }
        private string CurrentNode;

        public Game() 
        {
            LuaContext = new Lua();
            Parser = new NoctusTextParser(LuaContext);
            InputChannel = new ConsoleInputChannel();
            BuildMetadataTree();
            CurrentNode = "start";
        }

        private void BuildMetadataTree() 
        {
            LuaContext.DoString("metadata = {}");
            foreach (string file in Directory.EnumerateFiles("./game", "*.header", SearchOption.AllDirectories)) 
            {
                LuaContext.DoString($"metadata[\"{Path.GetFileNameWithoutExtension(file)}\"] = {{{File.ReadAllText(file)}}}");
            }
        }

        public void Run() 
        {
            while (true) 
            {
                LuaContext.DoString(File.ReadAllText(Directory.GetFiles("./game", $"{CurrentNode}.lua", SearchOption.AllDirectories)[0]));
                List<string> passageLines = Parser.ParsePassage(File.ReadAllText(Directory.GetFiles("./game", $"{CurrentNode}.txt", SearchOption.AllDirectories)[0]));

                foreach (string line in passageLines) 
                {
                    Console.WriteLine(line);
                    Console.ReadKey(true);
                }

                List<Link> outLinks = new List<Link>();
                int counter = 1;
                foreach (string line in File.ReadAllLines(Directory.GetFiles("./game", $"{CurrentNode}.links", SearchOption.AllDirectories)[0]))
                {
                    Link link = Parser.ParseLink(line);
                    Console.WriteLine($"{counter++}: {link.DisplayName}");
                    outLinks.Add(link);
                }
                CurrentNode = InputChannel.SelectLink(outLinks).PassageName;
            }
        }
    }
}
