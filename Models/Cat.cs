using AnimalDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalDemo.Models
{
    public class Cat : IAmANoisyAnimal
    {
        private readonly IVoiceBox _voiceBox;

        public Cat(IVoiceBox voiceBox)
        {
            _voiceBox = voiceBox;
        }

        public string Species
        {
            get { return "Cat"; }
        }

        public string MakeNoise()
        {
            return _voiceBox.NoiseMade;
        }
    }
}
