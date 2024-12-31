using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSamples
{
    internal class Animal
    {
        public string Color { get; set; }
        public string Smell { get; set; }
        public string Flavor { get; set; }

        public string Sing()
        {
            return "・・・";
        }
    }
}
