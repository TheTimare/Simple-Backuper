using Simple_Backuper.domain;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Simple_Backuper.util
{
    class AppDataUtil
    {
        // Creation of util objects is forbidden
        private AppDataUtil() { }

        // serialize data file to the choosen directory
        public static void SaveAppData(AppData data, string pathToFile)
        {
            using (FileStream fs = new FileStream(pathToFile, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, data);
            }
        }

        // deserialize data file
        public static AppData ReadAppData(string pathToFile)
        {
            using (FileStream fs = new FileStream(pathToFile, FileMode.OpenOrCreate))
            {
                try
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    AppData data = (AppData)formatter.Deserialize(fs);
                    return data;
                }
                catch (Exception)
                {
                    return new AppData();
                }
            }
        }
    }
}
