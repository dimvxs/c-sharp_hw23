using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hw
{
    public class Fish: IWater{
        public string Name { get; set;} = "Clownfish";
        public double Weight {get; set;} = 0.25;
        public double Size {get ; set;} = 0.1;
        public bool Predator {get; set;} = false;
    }
}