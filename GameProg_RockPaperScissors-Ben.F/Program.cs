using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProg_RockPaperScissors_Ben.F
{
    class Program
    {
        //variables 
        static Random random = new Random();
        static int gameswon = 0;
        static int gameslost = 0;
        static int gamenum = 0;
        static string[] answers = { "rock", "paper", "scissors" };
        //                            0        1         2
        static string cpuanswer()
        {
            int randomNumber = random.Next(1, 4);

            if (randomNumber == 1)
            {
                 return answers[0];
            }
            else if (randomNumber == 2)
            {
                return answers[1];
            }
            else
            {
                return answers[2];
            }
        }

        static string playeranswer()
        {

            while (true)
            {
                string MyUserInput = Console.ReadLine();

                if (MyUserInput == answers[0])
                {
                    return answers[0];
                    
                }
                else if (MyUserInput == answers[1]) 
                {
                    return answers[1];
                    
                }

                else if (MyUserInput == answers[2])
                {
                    return answers[2];
                }

                else
                {
                    Console.WriteLine("Not a valid response");
                    continue;
                }
            }
        }

        static void answerCheck(string player, string cpu)
        {

            Console.WriteLine($"You went {player} and the CPU went {cpu}");

            //if player chooses rock
            if (player == answers[0])
            {
                if (cpu == answers[0])
                {
                    Console.WriteLine("You tied");
                }

                else if (cpu == answers[1])
                {
                    Console.WriteLine("You Lost");
                    gameslost++;
                }

                else if (cpu == answers[2])
                {
                    Console.WriteLine("You Won!");
                    gameswon++;
                }

                else
                {
                    Console.WriteLine("Something was invalid");
                }

            }

            //if player chooses paper
            else if (player == answers[1])
            {
                if (cpu == answers[1])
                {
                    Console.WriteLine("You tied");
                }

                else if (cpu == answers[2])
                {
                    Console.WriteLine("You Lost");
                    gameslost++;
                }

                else if (cpu == answers[0])
                {
                    Console.WriteLine("You Won!");
                    gameswon++;
                }

                else
                {
                    Console.WriteLine("Something was invalid");
                }
            }

            //if player chooses scissors
            else if (player == answers[2])
            {
                if (cpu == answers[2])
                {
                    Console.WriteLine("You tied");
                }

                else if (cpu == answers[0])
                {
                    Console.WriteLine("You Lost");
                    gameslost++;
                }

                else if (cpu == answers[1])
                {
                    Console.WriteLine("You Won!");
                    gameswon++;
                }

                else
                {
                    Console.WriteLine("Something was invalid");
                }
            }

            else
            {
                Console.WriteLine("Something was invalid");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors!");

            while (true)
            {
                //setup
                Console.WriteLine("Press any key to Continue...");
                Console.ReadKey();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Score is :" + gameswon + " / " + gameslost);

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Just type in 'rock', 'paper', or scissors'! Make sure its lowercased!");

                //answer reciever
                answerCheck(playeranswer(), cpuanswer());
                
                //win check
                if (gameswon == 3)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Score is :" + gameswon + " / " + gameslost);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("You've WON!");
                    break;
                }

                else if (gameslost == 3)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Score is :" + gameswon + " / " + gameslost);
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("You've LOST! Nice try buddy!");
                    break ;
                }

                else
                {
                    continue;
                }
            }

            Console.ReadKey(true);
            
        }
    }
}
