using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

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

        // saves config file to the choosen directory
        public static void SaveConfig(Config config, string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, config);
            }
        }
        public static Config LoadConfig(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                try
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    Config config = (Config)formatter.Deserialize(fs);
                    return config;
                }
                catch (Exception)
                {
                    return new Config();
                }
            }
        }
    }
}
