using System;
using System.Collections.Generic;

namespace Simple_Backuper.domain
{
    [Serializable]
    class AppData
    {
        // stores all backups data
        public List<Backup> Backups { get; }
        public bool AutoStart { get; set; }

        public AppData()
        {
            Backups = new List<Backup>();
            AutoStart = false;
        }

        public Backup GetBackup(string backupName)
        {
            foreach (Backup backup in Backups)
            {
                if (backup.Name.Equals(backupName))
                {
                    return backup;
                }
            }
            return null;
        }
    }
}
