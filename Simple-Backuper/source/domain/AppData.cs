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
        public bool MinimizeOnExit { get; set; }

        public AppData()
        {
            Backups = new List<Backup>();
            AutoStart = false;
            MinimizeOnExit = false;
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
        public bool ContainsBackupName(string name)
        {
            foreach(Backup backup in Backups)
            {
                if (backup.Name.Equals(name))
                {
                    return true;
                }
            }
            return false;
        }
        public bool ContainsSourcePath(string path)
        {
            foreach (Backup backup in Backups)
            {
                if (backup.SourcePath.Equals(path))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
