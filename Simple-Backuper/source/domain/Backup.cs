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

        // sets whether the app should start a timer for this backup when it starts
        public bool AutoSaveWithBoot { get; set; }

        public Backup()
        {
            Name = "";
            StampsList = new List<string>();
            SourcePath = "";
            CustomAmountEnabled = false;
            CustomAmount = 5;
            TimerEnabled = false;
            TimerDelay = 15;
            AutoSaveWithBoot = false;
        }
    }
}
