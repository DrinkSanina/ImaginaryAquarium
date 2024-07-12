using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aquarium
{
    public interface IWaterCreature
    {
        int id { get; set; }
        Species info { get; set; }
        string listName { get; }
        string conditions { get; set; }
        int age { get; set; }
    }
}
