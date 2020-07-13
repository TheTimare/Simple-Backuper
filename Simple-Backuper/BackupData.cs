using System;
using System.Collections.Generic;
using System.IO;
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
       
    }
}
