using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        public static void printDirections()
        {
            Console.WriteLine("Welcome to the Leap Year Checking Machine (LYCM)!\n");
            Console.WriteLine("In a moment, you will be prompted to enter a year.\n");
            Console.WriteLine("This program will then quickly display the year you entered and whether or not it was a leap year!\n");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
        }
        public static int getInt()
        {
            int n1 = 0;
            String input = "";
            Console.WriteLine("Please enter an integer: ");
            input = Console.ReadLine();
            n1 = Convert.ToInt32(input);
            return n1;
        }
        //1 = a leap year 
        //2 = not a leap year
        public static int checkYear(int uYear)
        {
            int finalResult = 0;
            int resultMod4 = 0;
            int resultMod100 = 0;
            int resultMod400 = 0;

            resultMod4 = uYear % 4;
            resultMod100 = uYear % 100;
            resultMod400 = uYear % 400;

            if(resultMod4 == 0)
            {
                if( (resultMod100 == 0) && (resultMod400 == 0) )
                {
                    finalResult = 1;
                }
                else if(resultMod100 != 0)
                {
                    finalResult = 1;
                }
                else
                {
                    finalResult = 2;
                }
            }
            else
            {
                finalResult = 2;
            }

            return finalResult;
        }
        public static void printResults(int uYear, int isLeap)
        {
            Console.Clear();
            Console.WriteLine("You entered the year : " + uYear);
            if (isLeap == 1)
            {
                Console.WriteLine("That was a leap year!");
                Console.ReadLine();
            }
            else if (isLeap == 2)
            {
                Console.WriteLine("The year you entered was not a leap year.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You entered an invalid year. Please close the program and try again.");
                Console.ReadLine();
            }
        }
        public static void leapYearChecker()
        {
            int year = 0;
            int answer = 0;

            printDirections();

            Console.Clear();
            Console.WriteLine("Please remember to enter a valid year!\n");
            year = getInt();
            answer = checkYear(year);

            printResults(year,answer);
        }

        static void Main(string[] args)
        {
            leapYearChecker();
        }
    }
}