﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NoctusEngine
{
    public class Link
    {
        public string DisplayName { get; set; }
        public string PassageName { get; set; }
        public bool ShowState { get; set; }
        public string Behavior { get; set; }
        public string Args { get; set; }

        public Link(string displayName, string passageName, string behavior, string args, bool showState = true) 
        {
            DisplayName = displayName;
            PassageName = passageName;
            ShowState = showState;
            Behavior = behavior;
            Args = args;
        }
    }
}
