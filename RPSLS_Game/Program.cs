﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;
            int scorePlayer = 0;
            int scoreCPU = 0;

            Console.WriteLine("Choose between ROCK, PAPER, SCISSORS, LIZARD, SPOCK:     ");
            inputPlayer = Console.ReadLine();

            Random rnd = new Random();

            randomInt = rnd.Next(1, 6);

            switch (randomInt)
            {
                case 1:
                    inputCPU = "ROCK";
                    Console.WriteLine("Computer chose ROCK");
                    if (inputPlayer == "ROCK")
                    {
                        Console.WriteLine("DRAW!!\n\n");
                    }
                    else if (inputPlayer == "PAPER")
                    {
                        Console.WriteLine("PLAYER WINS!!\n\n");
                        scorePlayer++;
                    }
                    else if (inputPlayer == "SCISSORS")
                    {
                        Console.WriteLine("CPU WINS!!\n\n");
                        scoreCPU++;
                    }
                    break;
                case 2:
                    inputCPU = "PAPER";
                    Console.WriteLine("Computer chose PAPER");
                    if (inputPlayer == "PAPER")
                    {
                        Console.WriteLine("DRAW!!\n\n");
                    }
                    else if (inputPlayer == "ROCK")
                    {
                        Console.WriteLine("CPU WINS!!\n\n");
                        scoreCPU++;
                    }
                    else if (inputPlayer == "SCISSORS")
                    {
                        Console.WriteLine("PLAYER WINS!!\n\n");
                        scorePlayer++;
                    }
                    break;
                case 3:
                    inputCPU = "SCISSORS";
                    Console.WriteLine("Computer chose SCISSORS");
                    if (inputPlayer == "SCISSORS")
                    {
                        Console.WriteLine("DRAW!!\n\n");
                    }
                    else if (inputPlayer == "ROCK")
                    {
                        Console.WriteLine("PLAYER WINS!!\n\n");
                        scorePlayer++;
                    }
                    else if (inputPlayer == "PAPER")
                    {
                        Console.WriteLine("CPU WINS!!\n\n");
                        scoreCPU++;
                    }
                    break;
                case 4:
                    inputCPU = "LIZARD";
                    Console.WriteLine("Computer chose LIZARD");
                    if (inputPlayer == "LIZARD")
                    {
                        Console.WriteLine("DRAW!!\n\n");
                    }
                    else if (inputPlayer == "ROCK")
                    {
                        Console.WriteLine("PLAYER WINS!!\n\n");
                        scorePlayer++;
                    }
                    else if (inputPlayer == "SPOCK")
                    {
                        Console.WriteLine("CPU WINS!!\n\n");
                        scoreCPU++;
                    }
                    break;
                case 5:
                    inputCPU = "SPOCK";
                    Console.WriteLine("Computer chose SPOCK");
                    if (inputPlayer == "SPOCK")
                    {
                        Console.WriteLine("DRAW!!\n\n");
                    }
                    else if (inputPlayer == "LIZARD")
                    {
                        Console.WriteLine("PLAYER WINS!!\n\n");
                        scorePlayer++;
                    }
                    else if (inputPlayer == "ROCK")
                    {
                        Console.WriteLine("CPU WINS!!\n\n");
                        scoreCPU++;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid entry!");
                    break;
            }
        }
    }
}

