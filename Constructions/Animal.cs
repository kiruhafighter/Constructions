using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructions
{
    internal class Animal
    {
        public string Name { get; set; }
        public virtual void GetRoar()
        {
            Console.WriteLine("Abstract roar");
        }
        

    }
}
