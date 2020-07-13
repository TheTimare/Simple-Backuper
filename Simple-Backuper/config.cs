using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Simple_Backuper
{
    [Serializable]
    class Config
    {
        public string BackupedFolder { get; set; }

        public bool AutoStart { get; set; }

        public Config()
        {
            BackupedFolder = "";
            AutoStart = false;
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
