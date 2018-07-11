using AnimalDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalDemo.Models
{
    public class Bear : IAmANoisyAnimal
    {
        public string Species
        {
            get
            {
                return "Bear";
            }
        }

        public string MakeNoise()
        {
            return "Rawr!";
        }
    }
}
