using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpathGoatApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Goat Jeff = new Goat("Jeff");
            Jeff.makeNoise();

            Goat LilJeff = new Goat();


            Console.ReadKey();
        }
       
        
      
    }

}
