
// Class: ERAU ISTA220 PROGRAMMING FUNDAMENTALS
// STUDENT: HAYDEN BARNES 
// INSTRUCTOR: CHRISTINE E LEE, INSTRUCTOR
// DATE: 07/08/2020

/******************************************************************
 * This prject contains the code to create the sum of 10 numbers, and averages
 * of specific and non-specific numbers
 * 
 * It is a console application that displays on a console window.
 * 
 * Revisions: Rewrote code to execute in a for loop to eliminate lines of code
 * for better readability
 * 
 * Reviosions Date: 20200711
 * 
 * Revised By: Hayden Barnes
 * 
 *****************************************************************/


using System;

namespace CalculatingAverages
{
    class program
    {
        static void Main(string[] args)
        {

            bool displayMenu = true;
            while (displayMenu == true)
            {
                displayMenu = MainMenu();
            }

        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Adding 10 Numbers");
            Console.WriteLine("2) Average 10 scores");
            Console.WriteLine("3) Average (10) scores and letter grade");
            Console.WriteLine("4) Average a non-specific number of scores");
            Console.WriteLine("5) Exit");
            string result = Console.ReadLine();
            if (result == "1")
            {
                AddNumbers();
                return true;
            }
            else if (result == "2")
            {
                AvgScores();
                return true;
            }

            else if (result == "3")
            {
                SpecificScores();
                return true;
            }
            else if (result == "4")
            {
                NonSpecificScores();
                return true;
            }
            else if (result == "5")
            {
                Exit();
                return false;
            }
            else
            {
                Console.WriteLine("Please choose a valid option.");
                Console.ReadLine();
                return true;
            }

        }
        private static void AddNumbers()
        {

            Console.Clear();
            Console.WriteLine("Adding 10 numbers (1-100)");
            Console.WriteLine("______________________________________");
            int count = 0;
            double sum = 0;
            double number;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter a {0} number: ", count + 1);
                number = Int32.Parse(Console.ReadLine());
                if (number < 0 | number > 100)//willnot allow a number to be counted if out of range
                {
                    Console.WriteLine("Enter a valid number from 1-100", count - 1);
                    --i;
                    //prefix decrement to not count the attempt against the total
                }
                else
                {
                    sum += number;
                    count++;
                }

            }

                Console.WriteLine("Your total is: {0}", sum);
                Console.WriteLine("Press Enter to return to Main Menu");
                Console.ReadLine();



            // REFERENCE: https://www.csharp-console-examples.com/loop/while-loop/find-sum-and-average-of-n-numbers-in-c-using-while-loop/


        }
        private static void AvgScores()
        {

            Console.Clear();
            Console.WriteLine("Averaging 10 scores (1-100)");
            Console.WriteLine("______________________________________");
            int count = 0;
            double sum = 0;
            double number;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter a {0} score: ", count + 1);
                number = Int32.Parse(Console.ReadLine());
                if (number < 0 | number > 100)//willnot allow a number to be counted if out of range
                {
                    Console.WriteLine("Enter a valid number from 1-100", count - 1);
                    --i;
                    //prefix decrement to not count the attempt against the total
                }
                else
                {
                    sum += number;
                    count++;
                }

            }

            Console.WriteLine("Your average score is: {0}", (sum/10));
            Console.WriteLine("Press Enter to return to Main Menu");
            Console.ReadLine();

            //REFERENCE: https://www.w3resource.com/csharp-exercises/function/csharp-function-exercise-3.php
        }
        private static void SpecificScores()
        {
            int count = 0;
            double sum = 0;
            double number;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter a {0} score: ", count + 1);
                number = Int32.Parse(Console.ReadLine());
                if (number < 0 | number > 100)//willnot allow a number to be counted if out of range
                {
                    Console.WriteLine("Enter a valid number from 1-100", count - 1);
                    --i;
                    //prefix decrement to not count the attempt against the total
                }
                else
                {
                    sum += number;
                    count++;
                }

            }

            double avg = (sum / 10);


            Console.WriteLine($"Your average score is: {avg}");

            if ( avg <= 60)
            {
                Console.WriteLine("Letter Grade average: F");
            }
            else if (avg <= 64)
            {
                Console.WriteLine("Letter Grade average: D-");
            }
            else if (avg <= 66)
            {
                Console.WriteLine("Letter Grade average: D");
            }
            else if (avg <= 69)
            {
                Console.WriteLine("Letter Grade average: D+");
            }
            else if (avg <= 74)
            {
                Console.WriteLine("Letter Grade average: C-");
            }
            else if (avg <= 76)
            {
                Console.WriteLine("Letter Grade average: C");
            }
            else if (avg <= 79)
            {
                Console.WriteLine("Letter Grade average: C+");
            }
            else if (avg <= 84)
            {
                Console.WriteLine("Letter Grade average: B-");
            }
            else if (avg <= 86)
            {
                Console.WriteLine("Letter Grade average: B");
            }
            else if (avg <= 89)
            {
                Console.WriteLine("Letter Grade average: B+");
            }
            else if (avg <= 94)
            {
                Console.WriteLine("Letter Grade average: A-");
            }
            else if (avg <= 97)
            {
                Console.WriteLine("Letter Grade average: A");
            }
            else
            {
                Console.WriteLine("Letter Grade average: A+");
            }

            //REFERENCES: https://stackoverflow.com/questions/40142608/c-sharp-grade-calculator

        }
        private static void NonSpecificScores()
        {
            Console.Clear();
            Console.WriteLine("Average any amount of scores (1-100)");
            Console.WriteLine("______________________________________");
            Console.Write("How many test will you average: ");
            double s = Convert.ToDouble(Console.ReadLine());

            int count = 0;
            double sum = 0;
            double number;

            for (int i = 0; i < s; i++)
            {
                Console.Write("Enter a {0} score: ", count + 1);
                number = Int32.Parse(Console.ReadLine());
                if (number < 0 | number > 100)//willnot allow a number to be counted if out of range
                {
                    Console.WriteLine("Enter a valid number from 1-100", count - 1);
                    --i;
                    //prefix decrement to not count the attempt against the total
                }
                else
                {
                    sum += number;
                    count++;
                }

            }

            double avg = (sum / s);


            Console.WriteLine($"Your average is: {avg}");

            if (avg <= 60)
            {
                Console.WriteLine("Letter Grade average: F");
            }
            else if (avg <= 64)
            {
                Console.WriteLine("Letter Grade average: D-");
            }
            else if (avg <= 66)
            {
                Console.WriteLine("Letter Grade average: D");
            }
            else if (avg <= 69)
            {
                Console.WriteLine("Letter Grade average: D+");
            }
            else if (avg <= 74)
            {
                Console.WriteLine("Letter Grade average: C-");
            }
            else if (avg <= 76)
            {
                Console.WriteLine("Letter Grade average: C");
            }
            else if (avg <= 79)
            {
                Console.WriteLine("Letter Grade average: C+");
            }
            else if (avg <= 84)
            {
                Console.WriteLine("Letter Grade average: B-");
            }
            else if (avg <= 86)
            {
                Console.WriteLine("Letter Grade average: B");
            }
            else if (avg <= 89)
            {
                Console.WriteLine("Letter Grade average: B+");
            }
            else if (avg <= 94)
            {
                Console.WriteLine("Letter Grade average: A-");
            }
            else if (avg <= 97)
            {
                Console.WriteLine("Letter Grade average: A");
            }
            else
            {
                Console.WriteLine("Letter Grade average: A+");
            }


        }
        private static void Exit()
        {
            Console.Clear();
            Console.WriteLine("Are you sure?");
            Console.WriteLine("Y or N?");
            string result = Console.ReadLine();

            if (result == "Y")
            {
                Console.Clear();
                Console.WriteLine("Thank you! Goodbye!");
            }
            else if (result == "y")
            {
                Console.Clear();
                Console.WriteLine("Thank you! Goodbye!");
            }
            else if (result == "N")
            {
                MainMenu();
            }
            else if (result == "n")
            {
                MainMenu();
            }

        }
    }

}
    