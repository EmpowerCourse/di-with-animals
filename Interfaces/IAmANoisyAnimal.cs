using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalDemo.Interfaces
{
    public interface IAmANoisyAnimal
    {
        string Species { get; }
        string MakeNoise();
    }
}
