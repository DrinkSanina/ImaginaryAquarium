using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aquarium
{
    public class Fish : IWaterCreature
    {
        public int id { get; set; }
        public Species info { get; set; }
        public string listName => $"{info.name} ({info.species})";
        public int age { get; set; }
        public string dietStr { get; set; }

        public string[] DietArray
        {
            get
            {
                string[] array = dietStr.Split(';');
                return array;
            }
        }
        
        public string conditions { get; set; }

        public string[] CondArray
        {
            get
            {
                string[] array = conditions.Split(';');
                return array;
            }
        }

        public Fish()
        {
            id = age = 0;
            info = new Species();
        }
    }
}
