using System;

namespace Mission2Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] calculatedResults = new int[11];
            int[] answer = new int[11];
            int rolls;
            int sum;
            SixSidedDice dice1 = new SixSidedDice();
            SixSidedDice dice2 = new SixSidedDice();


            Console.WriteLine("Welcome to Dice Throwing Simulator!");
            Console.Write("How many dice rolls would you like to simulate? ");
            rolls = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls");
            Console.WriteLine("Total rolls: " + rolls + "\n");

            //Roll
            for (int i=0; i<rolls; i++)
            {
                sum = dice1.RollDice() + dice2.RollDice();
                answer = CalcResults(sum,calculatedResults);
            }

            PrintResults(answer,rolls);

            Console.WriteLine("\nThank you for using the Dice Rolling Simulator, Goodbye!");

        }
        public static void PrintResults(int[] answer, int rolls)
        {
            int displaySum;
            float percentage;
            string stars;
            for (int i = 0; i < 11; i++)
            {
                displaySum = i + 2;
                percentage = ((float)answer[i] / (float)rolls)*100*1.0f;

                stars = GenerateStars(percentage);

                Console.WriteLine(displaySum + ": " + stars);
            }
        }
        public static string GenerateStars(float percent)
        {
            string stars = "";
            int newPercent = (int)Math.Round(percent);

            for (int i=0; i<newPercent; i++)
            {
                stars = "*" + stars;
            }

            return stars;
        }
        public static int[] CalcResults(int sum, int[] calculatedResults)
        {
                switch (sum)
                {
                    case 2:
                        // code block
                        calculatedResults[0] = 1 + calculatedResults[0];
                        break;
                    case 3:
                        // code block
                        calculatedResults[1] = 1 + calculatedResults[1];
                        break;
                    case 4:
                        // code block
                        calculatedResults[2] = 1 + calculatedResults[2];
                        break;
                    case 5:
                        // code block
                        calculatedResults[3] = 1 + calculatedResults[3];
                        break;
                    case 6:
                        // code block
                        calculatedResults[4] = 1 + calculatedResults[4];
                        break;
                    case 7:
                        // code block
                        calculatedResults[5] = 1 + calculatedResults[5];
                        break;
                    case 8:
                        // code block
                        calculatedResults[6] = 1 + calculatedResults[6];
                        break;
                    case 9:
                        // code block
                        calculatedResults[7] = 1 + calculatedResults[7];
                        break;
                    case 10:
                        // code block
                        calculatedResults[8] = 1 + calculatedResults[8];
                        break;
                    case 11:
                        // code block
                        calculatedResults[9] = 1 + calculatedResults[9];
                        break;
                    case 12:
                        // code block
                        calculatedResults[10] = 1 + calculatedResults[10];
                        break;
                    default:
                        // code block
                        break;

                }

            return calculatedResults;

        }
    }
}
