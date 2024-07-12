using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;


namespace aquarium
{
    [Serializable]
    class AquariumParameters
    {
        public string water;
        public int temperature;

        //Синхронизация с БД после каждого действия
        public bool immediateSync;

        //Синхронизация каждый промежуток времени
        public bool autoSync;

        //Значение промежутка
        public int syncInterval;

        //Максимально допустимая разница между температурой воды и условиями обитания
        public int temperatureDifference;

        public AquariumParameters(string _water, int _temperature, int _temperatureDifference = 5, bool _immediateSync = false, bool _autoSync = false, int _syncInterval = 1)
        {
            water = _water;
            temperature = _temperature;
            immediateSync = _immediateSync;
            autoSync = _autoSync;
            syncInterval = _syncInterval;
            temperatureDifference = _temperatureDifference;
        }
    }
}
