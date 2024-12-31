using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSamples
{
    internal class Cat : Animal
    {
        public string Ear { get; set; }

        public string CatSing()
        {
            return "にゃー！";
        }
    }
}
