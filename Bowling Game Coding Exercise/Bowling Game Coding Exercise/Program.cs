using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling_Game_Coding_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tests
            print("Input String: X-X-X-X-X-X-X-X-X-X-XX");
            Game game1 = new Game("X-X-X-X-X-X-X-X-X-X-XX");
            print("Output: " + game1.gameScore);
            print("Should be: 300");

            print("Input String: 45-54-36-27-09-63-81-18-90-72");
            Game game2 = new Game("45-54-36-27-09-63-81-18-90-72");
            print("Output: " + game2.gameScore);
            print("Should be: 90");

            print("Input String: 5/-5/-5/-5/-5/-5/-5/-5/-5/-5/-5");
            Game game3 = new Game("5/-5/-5/-5/-5/-5/-5/-5/-5/-5/-5");
            print("Output: " + game3.gameScore);
            print("Should be: 150");

            print("Input String: 5/-54-54-X-5/-09-X-5/-5/-5/-5");
            Game game4 = new Game("5/-54-54-X-5/-09-X-5/-5/-5/-5");
            print("Output: " + game4.gameScore);
            int num = (10 + 5) + (9) + (9) + (10 + 10) + (10 + 0) + (9) + (10 + 10) + (10 + 5) + (10 + 5) + (10 + 5);
            print("Should be: " + num);

            Console.ReadLine();
        }


        static void print(string message)
        {
            Console.Out.WriteLine(message);
        }
    }
}
