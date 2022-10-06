using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Constructions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 person1 = new Class1();
            person1.Show();

            Class1 person2 = new Class1(34, "Balayan");
            person2.Show();

            Class1 person3 = new Class1();
            person3.Mstr = "budrt45";
            Console.WriteLine(person3.Mstr);
            person3.Wer = 67;
            Console.WriteLine($"  {person3.Wer} ");

            Inherit person4 = new Inherit();
            person4.Show();
            person4.Mstr = " ettf dgeyg";
            Console.WriteLine(person4.Mstr);
            person4.Wer = 45;
            Console.WriteLine($"  {person4.Wer} ");

            Cat kit = new Cat();
            kit.Name = "Freya";

            Dog pes = new Dog();
            pes.Name = "Peta";

            Rat shesterka = new Rat();
            shesterka.Name = "Bor`ka";

            Vatnik daun = new Vatnik();
            daun.Name = "Batya Bori";

            Animal[] animals = new Animal[4];
            animals[0] = kit;
            animals[1] = pes;
            animals[2] = shesterka;
            animals[3] = daun;

            for(int i = 0; i< animals.Length; i++)
            {
                Console.WriteLine($"Animal {animals[i].Name} is saying");
                animals[i].GetRoar();
            }

            Inherit ress = new Inherit(45, "Bob" , "WR345T1");
            ress.Show();
            int[] numbers = new int[] { 2, 6, 2, 8, 9, 4, 6, 8, 1, 3, 4, 1, 8, 5, 9, 10 };
            int a = 7, b = 8, c = 9, d = 1;
            Console.WriteLine("First max element");
            Console.WriteLine(ress.GetMax(numbers));
            Console.WriteLine("Second max element");
            Console.WriteLine(ress.GetMax(a, b, c, d));

        }
    }
}
