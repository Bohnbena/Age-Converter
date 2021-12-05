using System;

namespace Calculate_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

            
            Console.WriteLine("Welcome to Age Converter");
            Console.WriteLine("Pick an option to converter your age to");
            Console.WriteLine("");
            Console.WriteLine("Months/M , Days/D ,Weeks/W, Hours/H , Minutes/M1 , Seconds/S ");
            Console.WriteLine("");
            Console.WriteLine("Press the key for any of these options");
            Console.WriteLine();
            Console.WriteLine("Or to exit/E");

            int yearinput= 0;
            int resultnumber;

            int m, d, w, h, m1, s;

            var input = Console.ReadLine();

            // Read up on "enums". This could be a better case for using this
            // https://www.w3schools.com/cs/cs_enums.php
            string Month="M";
            string Day="D";
            string Week="W";
            string Hours="H";
            string Minutes="M1";
            string Seconds="S";
            string end="E";
          
            // Make this into a switch statement
            if (input == Month)
            {
                Console.Clear();
                Console.WriteLine("Please Enter Your Age :");
                yearinput = int.Parse(Console.ReadLine());
                m = 12;
                resultnumber = yearinput * m;
                Console.WriteLine("Your age in months is :"+resultnumber + "months");
                Console.ReadLine();
            }

            else if (input == Week)
            {
                Console.Clear();
                Console.WriteLine("Please Enter Your Age :");
                yearinput = int.Parse(Console.ReadLine());
                w = 52;
                resultnumber = yearinput * w;
                Console.WriteLine("Your age in weeks is :" + resultnumber + "weeks");
                Console.ReadLine();
            }

            else if (input == Day)
            {
                Console.Clear();
                Console.WriteLine("Please Enter Your Age :");
                yearinput = int.Parse(Console.ReadLine());
                d = 365;
                resultnumber = yearinput * d;
                Console.WriteLine("Your age in days is :" + resultnumber + "days");
                Console.ReadLine();
            }

            else if (input == Hours)
            {
                Console.Clear();
                Console.WriteLine("Please Enter Your Age :");
                yearinput = int.Parse(Console.ReadLine());
                h = 8760;
                resultnumber = yearinput * h;
                Console.WriteLine("Your age in hours is :" + resultnumber + "hours");
                Console.ReadLine();
            }

            else if (input == Minutes)
            {
                Console.Clear();
                Console.WriteLine("Please Enter Your Age :");
                yearinput = int.Parse(Console.ReadLine());
                m1 = 525600;
                resultnumber = yearinput * m1;
                Console.WriteLine("Your age in minutes is :" + resultnumber + "minutes");
                Console.ReadLine();
            }

            else if (input == Seconds)
            {
                Console.Clear();
                Console.WriteLine("Please Enter Your Age :");
                yearinput = int.Parse(Console.ReadLine());
                s = 31536000;
                resultnumber = yearinput * s;
                Console.WriteLine("Your age in seconds is :" + resultnumber+"seconds");
                Console.ReadLine();

            }
            else if (input==end)
            {
                Environment.Exit(0);
            }

                Console.WriteLine("Press R to restart ");
                
            Console.ReadLine();
         
            }
        }


    
    }
}
