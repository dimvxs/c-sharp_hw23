using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hw
{
    public interface IWater
    {
        string Name { get; set;}
        double Weight {get; set;}
        double Size {get ; set;}
        bool Predator {get; set;}
    }
}