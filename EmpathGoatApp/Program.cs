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
            Goat Keisha = new Goat("Keisha");
            Keisha.makeNoise();
            Goat Jim = new Goat("Jim");
            Jim.makeNoise();
            Goat Mildred = new Goat("Mildred");
            Mildred.makeNoise();
            Keisha.SubscribeToGoat(Jim);
            Jim.SubscribeToGoat(Mildred);
            Jim.makeNoise();
            Mildred.makeNoise();

            Duck James = new Duck("James");
            James.makeNoise();
            Duck Ricky = new Duck("Ricky");
            Ricky.makeNoise();
            Duck Eliza = new Duck("Eliza");
            Eliza.SubscribeToDuck(James);
            Duck Cheryl = new Duck("Cheryl");
            Cheryl.SubscribeToDuck(Ricky);


            Console.ReadKey();
        }
       
        
      
    }

}
