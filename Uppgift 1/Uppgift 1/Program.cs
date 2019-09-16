using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a line of text: ");
            String userResponse = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Thank you for entering: '{0}' ", userResponse);


            int wordcount = 1; //dvs när det första spacet hittas är det ord 2
            //for (int i = 0; i < userResponse.Length; i++)
            //{
            //    if (userResponse[i] == ' ')
            //    {
            //        wordcount++;
            //    }
            //}

            Console.WriteLine("Din mening har {0} ord.", wordcount);

            foreach (char c in userResponse)
            {
                if (c == ' ')
                {
                    wordcount++;
                }
            }

            Console.WriteLine("Din mening har {0} ord.", wordcount);

        }
    }
}
