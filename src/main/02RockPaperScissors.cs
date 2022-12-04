using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_Code_2022.src.main
{
    internal class RockPaperScissors
    {
        static public void Main(String[] args)
        {
            var games = ReadInput("D:\\repos\\Advent-of-Code-2022\\lib\\RockPaperScissors.txt");
            var score = 0;

            foreach(string game in games)
            {
                char opponentsTurn = Char.Parse(game.Split()[0]);
                char myTurn = Char.Parse(game.Split()[1]);
                score += CalculatePoints(opponentsTurn, myTurn);
            }
            Console.WriteLine(score);
        }

        static private List<string> ReadInput(string filePath)
        {
            List<string> games = new List<string>();

            foreach (string line in System.IO.File.ReadLines(filePath))
            {
                games.Add(line);
            }
            return games;
        }

        /*
         * A: Rock; B: Paper; C: Scissors
         * X: Rock; Y: Paper; Z: Scissors
         * Possible outcomes:
         * AX: 3 + 1 = 4
         * AY: 6 + 2 = 8
         * AZ: 0 + 3 = 3
         * BX: 0 + 1 = 1
         * BY: 3 + 2 = 5
         * BZ: 6 + 3 = 9
         * CX: 6 + 1 = 7
         * CY: 0 + 2 = 2
         * CZ: 3 + 3 = 6
         */

        static private int CalculatePoints(char opponentsTurn, char myTurn)
        {
            int points = 0;

            switch(opponentsTurn)
            {
                case 'A':
                    points = CaseA(myTurn);
                    break;

                case 'B':
                    points = CaseB(myTurn);
                    break;

                case 'C':
                    points = CaseC(myTurn);
                    break;
            }
            
            return points;
        }

        private static int CaseA(char myTurn)
        {
            int points = 0;

            switch (myTurn)
            {
                case 'X':
                    points = 4;
                    break;

                case 'Y':
                    points = 8;
                    break;

                case 'Z':
                    points = 3;
                    break;
            }
            return points;
        }

        private static int CaseB(char myTurn)
        {
            int points = 0;

            switch (myTurn)
            {
                case 'X':
                    points = 1;
                    break;

                case 'Y':
                    points = 5;
                    break;

                case 'Z':
                    points = 9;
                    break;
            }
            return points;
        }
        
        private static int CaseC(char myTurn)
        {
            int points = 0;

            switch (myTurn)
            {
                case 'X':
                    points = 7;
                    break;

                case 'Y':
                    points = 2;
                    break;

                case 'Z':
                    points = 6;
                    break;
            }
            return points;
        }
    }
}
