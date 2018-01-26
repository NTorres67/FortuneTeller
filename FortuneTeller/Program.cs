using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //User's First Name
            string nameFirst = "";
            Console.WriteLine("Please enter your first name.");
            nameFirst = Console.ReadLine();
            Console.WriteLine(" ");
            //Console.WriteLine(nameFirst);
            
            //User's Last Name
            string nameLast = "";
            Console.WriteLine("Please enter your last name.");
            nameLast = Console.ReadLine();
            Console.WriteLine(" ");
            //Console.WriteLine(nameLast);
            
            //User's Age
            Console.WriteLine("Please enter your age.");
            int ageCurrent = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            //Console.WriteLine(ageCurrent);
            
            //Years to Retirement
            int ageOdd = 62;
            int ageEven = 65;
            //int retire = (ageEven - ageCurrent);

            int retire;
            if ((ageCurrent % 2) == 0)
            {
                retire = (ageEven - ageCurrent);
                //Console.WriteLine(retire);
            }
            else
            {
                retire = (ageOdd - ageCurrent);
            }

            //Console.WriteLine(retire);
            Console.WriteLine("");
            
            //Birth Month
            Console.WriteLine("Please enter your month of birth by its numerical value.");
            int birthMonth = int.Parse(Console.ReadLine());
            //Console.WriteLine(birthMonth);
            Console.WriteLine(" ");
            
            //Money in bank based on month of birth
            string pay = "";
            if ((birthMonth == 1) || (birthMonth == 2) || (birthMonth == 3) || (birthMonth == 4))
            {
                pay = "$10,000";
                //Console.WriteLine(payOne);
            }
            if ((birthMonth == 5) || (birthMonth == 6) || (birthMonth == 7) || (birthMonth == 8))
            {
                pay = "$15,000";
                //Console.WriteLine(payTwo);
            }
            if ((birthMonth == 9) || (birthMonth == 10) || (birthMonth == 11) || (birthMonth == 12))
            {
                pay = "$20,000";
                //Console.WriteLine(payThree);
            }
            if ((birthMonth <= 0) || (birthMonth >= 12))
            {
                pay = "$0.00";
                //Console.WriteLine(payOther);
            }
            else
            { }
            Console.WriteLine("");
            
            //Favorite Color
            Console.WriteLine("Please state your favorite using the ROYGBIV color acronym.");
            Console.WriteLine("If help is required, please type the word \"Help.\"");
            string favoriteColor = Console.ReadLine();
            //Console.WriteLine(favoriteColor);
            string color = favoriteColor.ToLower();
            Console.WriteLine(" ");

            if (favoriteColor == "Help")
            {
                Console.WriteLine("R = red");
                Console.WriteLine("O = orange");
                Console.WriteLine("Y = yellow");
                Console.WriteLine("G = green");
                Console.WriteLine("B = blue");
                Console.WriteLine("I = indigo");
                Console.WriteLine("V = violet");

                Console.WriteLine("");

                Console.WriteLine("Please select your favorit color using the ROYGIBIV color acronym.");
                favoriteColor = Console.ReadLine();
                color = favoriteColor.ToLower();
            }

            Console.WriteLine("");
            
            //Transportation according to favorite color
            string col = "";
            //string orange = "";
            //string yellow = "";
            //string green = "";
            //string blue = "";
            //string indigo = "";
            //string violet = "";

            switch (color)
            {
                case "red":
                    col = "walk";
                    //Console.WriteLine(red);
                    break;

                case "orange":
                    col = "skip";
                    break;

                case "yellow":
                    col = " truck";
                    break;

                case "green":
                    col = "scooter";
                    break;

                case "blue":
                    col = "donkey";
                    break;

                case "indigo":
                    col = "seahorse";
                    break;

                case "violet":
                    col = "sled pulled by rabbits";
                    break;

                default:
                    break;
            }

            Console.WriteLine("");
            
            //Number Siblings
            Console.WriteLine("How many sibilings do you have?");
            int numberSiblings = int.Parse(Console.ReadLine());
            //Console.Write(numberSiblings);
            Console.WriteLine("");
            
            //Vacation Home according to number of siblings
            string vac = "";
            //string zero = "";
            //string one = "";
            //string two = "";
            //string three = "";

            if (numberSiblings <= 0)
            {
                vac = "shack int the garbage dump";
                //Console.WriteLine(vac);
            }
            if (numberSiblings == 0)
            {
                vac = "cabin in the woods";
            }
            if (numberSiblings == 1)
            {
                vac = "dome under the sea";
            }
            if (numberSiblings == 2)
            {
                vac = "houseboat";
            }
            if (numberSiblings == 3)
            {
                vac = "yurt in the Rockies";
            }
            if (numberSiblings >= 3)
            {
                vac = "yurt in the Rockies";
            }
            else
            { }

            Console.WriteLine("");
            
            Console.WriteLine("{0} {1} will retire in {2} years with {3} in the bank and a vaction home in a {4} and a {5}", nameFirst, nameLast, retire, pay, vac, col);
            //Console.WriteLine("and a vacation home in {0} and a {1}", vac, col);

            Console.WriteLine("");
        }
    }
}
