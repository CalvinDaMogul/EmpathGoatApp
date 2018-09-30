using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpathGoatApp
{
    class Duck
    {
        string name { get; set; }

        public event Action makeNoiseEvent;

        public Duck()
        {

        }

        public Duck(string _name)
        {
            name = _name;
        }

        public void Feeling()
        {
            Console.WriteLine(name + ": I felt a duck Quack, Quack!!!");
        }

        public void makeNoise()
        {
            Console.WriteLine("My name is " + name + ". Quack!!!");
            makeNoiseEvent?.Invoke();
        }

        public void SubscribeToDuck(Duck foreignDuck)
        {
            foreignDuck.makeNoiseEvent += new System.Action(Feeling);
        }


    
}
}
