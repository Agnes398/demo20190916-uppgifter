using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Var snäll och mata in en mening: "); //mata in en mening

            System.Collections.ArrayList MyList;
            MyList = new System.Collections.ArrayList(); //skapar lista


            string key = ""; //skapar ett objekt som ska temporärt innehålla användarens ord

            //användaren matar in ord tills de skriver EXIT, då avslutas programmet
            do
            {
                key = Console.ReadLine();
                if (key != "EXIT")
                {
                    MyList.Add(key);
                }

            } while (key != "EXIT");

            Console.WriteLine("Tack, du matade in {0} ord", MyList.Count); 

            //skriv ut varje ord som matades in
            foreach (string s in MyList)
            {
                Console.Write("{0} ", s);
            }

        }
    }
}
