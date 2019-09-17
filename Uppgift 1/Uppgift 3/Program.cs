using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in en mening: ");
            string mening = Console.ReadLine();

            //Dela upp meningen i ord
            string[] ord = mening.Split(' ');

            //Skriv ut varje ord och hur många gånger förekommer varje ord?
            //foreach (string s in ord)
            //{
            //    Console.WriteLine("{0}", s);
            //}

            //Jämför ord för ord

            


            //räknare för hur ofta ord förekommer
            int a = 0;

            //gå igenom varje ord
            for (int i = 1; i < ord.Length; i++)
            {
                foreach (string s in ord)
                {
                    if (!ord.Contains(ord[i])) //om listan ord innehåller s
                    {
                        //dupes.Add(s);
                        a++;
                    }
                }
            }

            //Lägg in alla ord i en ny lista och se om ett likadant ord finns i orginalet
            //List<string> dupes = new List<string>();
            ord.Clone();



            foreach (string s in ord)
            {
                Console.WriteLine("{0} ({1})", s, a);
            }



            foreach (string s in ord)
            {
                if (!ord.Contains(s)) //om listan ord innehåller s
                {
                    dupes.Add(s);
                }

                //Console.WriteLine("{0} ({1})", s, index); //skriv ut ord samt räknare
            }

            foreach (string s in dupes)
            {
                if (!dupes.Contains(s))
                {

                }
            }



            //foreach (string s in ord) {
            //    int index = ord.IndexOf(s);
            //    Console.WriteLine("{0}", index); 
            //}


            //int x = 1;
            //foreach (string s in ord)
            //{
            //    System.Collections.Comparer(s, x);
            //    x++;
            //}


            //foreach(string s in ord)
            //{
            //    if (s = System.Collections.ArrayList.Repeat(ord, count: 1))
            //    {

            //    }
            //}



            //int counter = 0;
            //int x = 1;
            //foreach (string s in ord)
            //{
            //    if (s == ord[x])
            //    {
            //        counter++;
            //    }
            //    x++;
            //    Console.WriteLine("{0} ({1})", s, counter);
            //}

        }
    }
}
