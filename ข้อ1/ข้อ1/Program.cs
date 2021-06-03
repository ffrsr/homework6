using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ข้อ1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Score: 0, Difficulty: Easy ");

            int inputLevel = 0;
            double S = 0;
            mainmenu(ref inputLevel, ref S);


            Console.ReadLine();
        }


        enum Difficulty
        {
            Easy,
            Normal,
            Hard
        }

        struct Problem
        {
            public string Message;
            public int Answer;

            public Problem(string message, int answer)
            {
                Message = message;
                Answer = answer;
            }

        }

        static Problem[] GenerateRandomProblems(int numProblem)
        {
            Problem[] randomProblems = new Problem[numProblem];

            Random rnd = new Random();
            int x, y;

            for (int i = 0; i < numProblem; i++)
            {
                x = rnd.Next(50);
                y = rnd.Next(50);
                if (rnd.NextDouble() >= 0.5)
                    randomProblems[i] =
                    new Problem(String.Format("{0} + {1} = ?", x, y), x + y);
                else
                    randomProblems[i] =
                    new Problem(String.Format("{0} - {1} = ?", x, y), x - y);
            }

            return randomProblems;

        }

        static void mainmenu(ref int inputLevel, ref double S)
        {

            int input;

            do
            {
                input = int.Parse(Console.ReadLine());

                if (input == 0)
                {
                    play(ref inputLevel, ref S);

                }
                else if (input == 1)
                {
                    setting(ref inputLevel, ref S);
                }
                else if (input == 2)
                {
                    exit();
                }
                else
                {
                    Console.WriteLine("Please input 0-2.");
                }

            } while (input != 0 || input != 1 || input != 2);
        }

        static void play(ref int inputLevel, ref double S)
        {

            if (inputLevel == 0)
            {
                for (int score = 1; score < 4; score++)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        int numEasy = 3;
                        Problem[] Question = GenerateRandomProblems(numEasy);
                        long T1 = DateTimeOffset.Now.ToUnixTimeSeconds();
                        Console.WriteLine(Question[i].Message);
                        int ans = int.Parse(Console.ReadLine());
                        long T2 = DateTimeOffset.Now.ToUnixTimeSeconds();


                        if (ans == Question[i].Answer)
                        {
                            S = (score / 3.0) * ((25.0 - 0 * 0) / Math.Max((T2 - T1), (25.0 - 0 * 0))) * Math.Pow((2.0 * 0 + 1.0), 2);
                            Console.WriteLine("Score: {0}, Difficulty: {1} ", S, Difficulty.Easy);
                            score++;
                        }
                    }
                }

                mainmenu(ref inputLevel, ref S);
            }

            else if (inputLevel == 1)
            {
                for (int score = 1; score < 6; score++)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        int numEasy = 5;
                        Problem[] Question = GenerateRandomProblems(numEasy);
                        long T1 = DateTimeOffset.Now.ToUnixTimeSeconds();
                        Console.WriteLine(Question[i].Message);
                        int ans = int.Parse(Console.ReadLine());
                        long T2 = DateTimeOffset.Now.ToUnixTimeSeconds();


                        if (ans == Question[i].Answer)
                        {
                            S = (score / 5.0) * ((25.0 - 1 * 1) / Math.Max((T2 - T1), (25.0 - 1 * 1))) * Math.Pow((2.0 * 1 + 1.0), 2);
                            Console.WriteLine("Score: {0}, Difficulty: {1} ", S, Difficulty.Normal);
                            score++;
                        }
                    }
                }
                mainmenu(ref inputLevel, ref S);
            }
            else if (inputLevel == 2)
            {
                for (int score = 1; score < 8; score++)
                {
                    for (int i = 0; i < 7; i++)
                    {
                        int numEasy = 7;
                        Problem[] Question = GenerateRandomProblems(numEasy);
                        long T1 = DateTimeOffset.Now.ToUnixTimeSeconds();
                        Console.WriteLine(Question[i].Message);
                        int ans = int.Parse(Console.ReadLine());
                        long T2 = DateTimeOffset.Now.ToUnixTimeSeconds();


                        if (ans == Question[i].Answer)
                        {
                            S = (score / 7.0) * ((25.0 - 2 * 2) / Math.Max((T2 - T1), (25.0 - 2 * 2))) * Math.Pow((2.0 * 2 + 1.0), 2);
                            Console.WriteLine("Score: {0}, Difficulty: {1} ", S, Difficulty.Normal);
                            score++;
                        }
                    }
                }
                mainmenu(ref inputLevel, ref S);
            }

        }

        static void setting(ref int inputLevel, ref double S)
        {
            Console.WriteLine("Score: {0}, Difficulty: {1} ", S, Difficulty.Easy);

            do
            {
                inputLevel = int.Parse(Console.ReadLine()); ;

                if (inputLevel == 0)
                {
                    Console.WriteLine("Score: {0}, Difficulty: {1} ", S, Difficulty.Easy);
                    mainmenu(ref inputLevel, ref S);

                }
                else if (inputLevel == 1)
                {
                    Console.WriteLine("Score: {0}, Difficulty: {1} ", S, Difficulty.Normal);
                    mainmenu(ref inputLevel, ref S);

                }
                else if (inputLevel == 2)
                {
                    Console.WriteLine("Score: {0}, Difficulty: {1} ", S, Difficulty.Hard);
                    mainmenu(ref inputLevel, ref S);

                }
                else
                {
                    Console.WriteLine("Please input 0-2.");
                }

            } while (inputLevel != 0 || inputLevel != 1 || inputLevel != 2);

        }

        static void exit()
        {

        }




    }
}
