using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTruTuong
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Class Cat: ");
            Cat cat_115 = new Cat();
            cat_115.Eat();
            cat_115.makeSound();
            cat_115.Run();
            Console.WriteLine("\n");
            Console.WriteLine("Class Bird: ");
            
            Bird bird_115 = new Bird();
            bird_115.Eat();
            bird_115.makeSound();
            bird_115.Fly();

            Console.ReadKey();
        }
    }
}
