using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace Simple_Backuper
{
    [Serializable]
    class BackupData
    {
        public string BackupPath { get; set; }

        public List<DateTime> Backups { get; }

        public BackupData()
        {
            Backups = new List<DateTime>();
            BackupPath = "";
        }

        // saves backup data to the choosen directory
        public static BackupData ReadBackupData(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                try
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    BackupData data = (BackupData)formatter.Deserialize(fs);
                    return data;
                }
                catch (Exception)
                {
                    return new BackupData();
                }
            }
        }
        public static void SaveBackupData(BackupData data, string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, data);
            }
        }

        public static void CreateBackup(string sourceDir, string backupPath)
        {
            string[] splittedPath = sourceDir.Split('\\');
            string backupName = splittedPath[splittedPath.Count() - 1];
            
            Directory.CreateDirectory(backupPath);

            BackupData data = BackupData.ReadBackupData(backupPath + "\\backups.dat");
            data.BackupPath = sourceDir;

            DateTime now = DateTime.Now;
            if (data.Backups.Count() < numericUpDownBackupsAmount.Value)
            {
                data.Backups.Add(now);
            }
            else
            {
                DateTime timeToReplace = data.Backups.OrderBy(time => time.Ticks).First();
                Directory.Delete(backupPath + "\\" + timeToReplace.ToString().Replace(':', '-'), true);
                data.Backups[data.Backups.IndexOf(timeToReplace)] = now;
            }
            DirectoryUtil.DirectoryCopy(data.BackupPath, backupPath + "\\" + now.ToString().Replace(':', '-'), true);
            BackupData.SaveBackupData(data, backupPath + "\\backups.dat");
        }
    }
}
