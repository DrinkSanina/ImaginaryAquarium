using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace aquarium
{
    static class Utilities
    {
        public static AquariumParameters aqmparameters;
        public static void SaveAquariumParameters()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("config.aqm", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, aqmparameters);
            }
        }

        public static void LoadAquariumParameters()
        {
            if(System.IO.File.Exists("config.aqm"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fs = new FileStream("config.aqm", FileMode.Open))
                {
                    aqmparameters = (AquariumParameters)formatter.Deserialize(fs);
                }
            }
            else
            {
                aqmparameters = new AquariumParameters("fresh", 25);
            }
            
        }

        public static bool CheckName(string name)
        {
            Regex regex = new Regex(@"\S+", RegexOptions.IgnoreCase);
            return regex.IsMatch(name);
        }
    }
}
