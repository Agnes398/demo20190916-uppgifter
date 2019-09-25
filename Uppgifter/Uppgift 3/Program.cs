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
            string[] ord = mening.Split(' '); //Dela upp meningen i ord

            int räknare = 1;

            System.Collections.ArrayList index = new System.Collections.ArrayList();

            for (int i = 0; i < ord.Length; i++)
            {
                for (int j = i+1; j < ord.Length; j++)
                {
                    
                    if (ord[i] == ord[j])
                    {
                        

                        index.Add(new Index() { index = räknare++, ord = ord[i] });
                        
                        foreach (Index x in index) {
                            Console.WriteLine("({0}) {1}", x.index, x.ord);
                        }

                    }

                }
            }
            



        }
    }
}
