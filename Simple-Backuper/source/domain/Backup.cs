using System;
using System.Collections.Generic;

namespace Simple_Backuper.domain
{
    [Serializable]
    class Backup
    {
        public string Name { get; set; }

        // contains backup dates (dates are used as folder names)
        public List<string> StampsList { get; }
        // contains full path to source
        public string SourcePath { get; set; }

        public bool CustomAmountEnabled { get; set; }
        public int CustomAmount { get; set; }

        public bool TimerEnabled { get; set; }
        public int TimerDelay { get; set; }

        public Backup()
        {
            Name = "";
            StampsList = new List<string>();
            SourcePath = "";
            CustomAmountEnabled = false;
            CustomAmount = 5;
            TimerEnabled = false;
            TimerDelay = 15;
        }
    }
}
