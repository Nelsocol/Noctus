using NLua;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace NoctusEngine
{
    public class Game
    {
        private Lua LuaContext { get; }
        private NoctusTextParser Parser { get; }
        private IInputChannel InputChannel { get; }
        private string rootDir { get; }
        private string CurrentNode;

        public Game(string gameDirectory) 
        {
            rootDir = gameDirectory;
            LuaContext = new Lua();
            Parser = new NoctusTextParser(LuaContext);
            InputChannel = new ConsoleInputChannel();
            BuildMetadataTree();
            RunNlibFiles();
            CurrentNode = "start";
        }

        private void BuildMetadataTree() 
        {
            LuaContext.DoString("METADATA = {}");
            foreach (string file in Directory.EnumerateFiles(rootDir, "*.header", SearchOption.AllDirectories)) 
            {
                LuaContext.DoString($"CURRENT_NODE=METADATA.start");
                LuaContext.DoString($"METADATA[\"{Path.GetFileNameWithoutExtension(file)}\"] = {{{File.ReadAllText(file)}}}");
                LuaContext.DoString($"setmetatable(METADATA[\"{Path.GetFileNameWithoutExtension(file)}\"], Node)");
            }
        }

        private void RunNlibFiles()
        {
            foreach (string file in Directory.EnumerateFiles(rootDir, "*.nlib", SearchOption.AllDirectories))
            {
                LuaContext.DoFile(file);
            }
        }

        public void Run() 
        {
            while (true) 
            {
                //Clear Console
                Console.Clear();

                //Execute behavior in the .lua file and parse .txt file for this node
                LuaContext.DoString(File.ReadAllText(Directory.GetFiles(rootDir, $"{CurrentNode}.lua", SearchOption.AllDirectories)[0]));
                List<string> passageLines = Parser.ParsePassage(File.ReadAllText(Directory.GetFiles(rootDir, $"{CurrentNode}.txt", SearchOption.AllDirectories)[0]));

                //Individually present each line from the txt file
                foreach (string line in passageLines) 
                {
                    Console.WriteLine(line);
                    Console.ReadKey(true);
                }

                //Present links and direct game flow to one selected link.
                int counter = 1;
                List<Link> outLinks = File.ReadAllLines(Directory.GetFiles(rootDir, $"{CurrentNode}.links", SearchOption.AllDirectories)[0]).Select(e => Parser.ParseLink(e)).ToList();
                if (outLinks.Count > 1) {
                    foreach (Link link in outLinks.Where(e => e.ShowState))
                    {
                        Console.WriteLine($"{counter++}: {link.DisplayName}");
                    }
                }

                Link selectedLink = InputChannel.SelectLink(outLinks);
                LuaContext.DoString(selectedLink.Behavior);
                LuaContext.DoString($"METADATA.{selectedLink.PassageName}.ARGS = {{{selectedLink.Args}}}");
                LuaContext.DoString($"CURRENT_NODE=METADATA.{selectedLink.PassageName}");
                CurrentNode = selectedLink.PassageName;
            }
        }
    }
}
