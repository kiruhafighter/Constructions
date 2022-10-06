using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructions
{
    internal class Class1
    {
        int age;
        string name;
        

        string mstr;
        public string Mstr
        {
            get
            {
                return mstr;
            }
            set
            {
                if (value != "")
                {
                    mstr = value;
                }
            }

        }
        public int Wer
        {
            get;
            set;
        }
        
        public Class1()
        {
            age = 25;
            name = "Alien";
            
        }
        public Class1(int age)
        {
            this.age = age;
        }
        public Class1(int age,string name) : this(age)
        {
            this.name = name;
        }
        public virtual void Show()
        {
            Console.WriteLine($"Name is {name} , age is {age} ");
        }
    }
}
