using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aquarium
{
    public class Flora : IWaterCreature
    {
        public int id { get; set; }
        public Species info { get; set; }
        public string listName => $"{info.name} ({info.species})";
        public bool lifespan { get; set; }
        public int age { get; set; }
        public string conditions { get; set; }
        public Flora()
        {
            id = age = 0;
            info = new Species();
            lifespan = true;
            conditions = "";
        }

        public string[] CondArray
        {
            get
            {
                string[] array = conditions.Split(';');
                return array;
            }
        }
    }
}
