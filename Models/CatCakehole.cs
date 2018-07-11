using AnimalDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalDemo.Models
{
    public class CatCakehole : IVoiceBox
    {
        public string NoiseMade
        {
            get
            {
                return "Meow";
            }
        }
    }
}
