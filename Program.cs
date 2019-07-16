using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            ///<summary>
            ///Welcome the user to the program
            /// </summary>
            double roomWidth = 0;
            double roomHeight = 0;
            double roomLength = 0;
            Console.WriteLine("Welcome to the Grand Circus Room Detail Generator!");

            int i = 0;
            while (i == 0)
            {
                bool isValid = false;
                while (!isValid)
                {
                    ///<summary>
                    ///prompt the user for input
                    /// </summary>

                    Console.WriteLine("Enter length: ");
                    string input1 = (Console.ReadLine());

                    if (double.TryParse(input1, out roomLength))
                    {
                        isValid = true;
                    }
                    else
                    {
                        Console.WriteLine("I don't understand. Please enter the length in the form of a decimal or whole number");
                    }
                }
                isValid = false;
                while (!isValid)
                {
                    Console.WriteLine("Enter width: ");
                    string input2 = Console.ReadLine();


                    if (double.TryParse(input2, out roomWidth))
                    {
                        isValid = true;
                    }
                    else
                    {
                        Console.WriteLine("I don't understand. Please enter the length in the form of a decimal or whole number");
                    }


                }
                isValid = false;
                while (!isValid)
                {
                    Console.WriteLine("Enter height: ");
                    string input3 = Console.ReadLine();


                    ///<summary>
                    ///lines 93-100 are error handling
                    /// </summary>
                    if (double.TryParse(input3, out roomHeight))
                    {
                        isValid = true;
                    }
                    else
                    {
                        Console.WriteLine("I don't understand. Please enter the length in the form of a decimal or whole number");
                    }
                }
                ///<summary>
                ///calculate the area
                /// </summary>
                double area = roomLength * roomWidth;

                ///<summary>
                ///calculate the perimeter
                /// </summary>
                double perimeter = (roomLength * 2) + (roomWidth * 2);

                ///<summary>
                ///calculate the volumn
                /// </summary>

                double volume = area * roomHeight;

                ///<summary>
                ///display the area and perimeter
                /// </summary>
                Console.WriteLine("area = " + area);
                Console.WriteLine("perimeter = " + perimeter);
                Console.WriteLine("volume = " + volume);

                ///<summary>
                ///ask the user if they would like to continue
                /// </summary>
                int i2 = 0;
                while (i2 == 0)
                {
                    Console.WriteLine("continue? (y/n)");
                    string runAgain = Console.ReadLine();

                    if (runAgain == "y")
                    {
                        i = 0;
                        i2 = 1;
                        Console.WriteLine("");
                        Console.WriteLine("Welcome back to the Grand Circus Room Detail Generator!");
                    }
                    else if (runAgain == "n")
                    {
                        i = 1;
                        i2 = 1;
                    }
                    else
                    {
                        Console.WriteLine("I don't understand. Please use lowercase y or n.");
                        i2 = 0;
                    }
                }
            }
        }
    }
}
