﻿using System;
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
            //Uppgift 1.1
            Console.WriteLine("Please enter a line of text: ");
            String userResponse = Console.ReadLine();
            Console.WriteLine("Thank you for entering: '{0}' ", userResponse);

            //Uppgift 1.2
            int wordcount = 1; //dvs när det första spacet hittas är det ord 2
            foreach (char c in userResponse)
            {
                if (c == ' ')
                {
                    wordcount++;
                }
            }

            Console.WriteLine("Din mening har {0} ord.", wordcount);

            //Uppgift 1.3
            Console.WriteLine("Please enter a sentance: ");
            string UserResponse = Console.ReadLine();

            string[] words = UserResponse.Split(' ');

            Console.WriteLine("Words består av {0} ord", words.Length);

            foreach (string s in words)
            {
                Console.WriteLine("{0} ({1})", s, s.Length);
            }



        }
    }
}
