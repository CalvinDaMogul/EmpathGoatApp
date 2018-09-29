using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpathGoatApp
{
    class EGoat:Goat
    {
       
        string name { get; set; }

         



        public EGoat()
        {

        }

        public EGoat(string _name)
        {
            name = _name;
        }

        public void Feeling()
        {
            Console.WriteLine("I felt a goat Baahh!!!");
        }
    }
}
