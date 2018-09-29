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

         public event Action makeNoiseEvent;

        public Goat()
        {

        }

        public Goat(string _name)
        {
            name = _name;
        }

         public void Feeling()
        {
            Console.WriteLine(name+": I felt a goat Baahh!!!");
        }

        public void makeNoise()
        {
            Console.WriteLine("My name is "+name+". Baahh!!!");
            makeNoiseEvent?.Invoke();
        }
        
       public void SubscribeToGoat(Goat foreignGoat) {
            foreignGoat.makeNoiseEvent += new System.Action(Feeling);
}

        
    }
   


}
