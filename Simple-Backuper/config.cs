using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Backuper
{
    [Serializable]
    class Config
    {
        public string BackupedFolder { get; set; }

        public bool CustomBackupsEnabled { get; set; }
        public int BackupsAmount { get; set; }

        public bool TimerEnabled { get; set; }
        public int TimerDelay { get; set; }

        public Config()
        {
            BackupedFolder = "";
            CustomBackupsEnabled = true;
            BackupsAmount = 5;
            TimerEnabled = false;
            TimerDelay = 15;
        }
    }
}
