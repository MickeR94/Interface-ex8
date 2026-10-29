using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_ex8
{

    public class Program1 : IStart, IGreeting
    {
        /*public void Run()
        {
            Console.WriteLine("Nu kör vi program 1");
        }*/

        // Nu används istället interfacet IStart med dess metod Start(). 
        public void Start()
        {
            Console.WriteLine("Nu kör vi program 1");
        }

        public void Greeting()
        {
            Console.WriteLine("--- Välkommen! ---");
        }
    }
}
