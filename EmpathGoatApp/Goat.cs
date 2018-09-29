using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpathGoatApp
{
    class Goat
    {
        string name { get; set; }



        public Goat()
        {

        }

        public Goat(string _name)
        {
            name = _name;
        }

        public void makeNoise()
        {
            Console.WriteLine("My name is "+name+". Baahh!!!");
        }
        
    }
   


}
