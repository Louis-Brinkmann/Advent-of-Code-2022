using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_Code_2022.src.main
{
    internal class CalorieCounting
    {
        //static public void Main(string[] args)
        //{
        //    var caloryList = ReadInput("D:\\repos\\Advent-of-Code-2022\\lib\\CalorieCounting.txt");
        //    int[] mostCalories = FindThreeBiggestItemsInList(caloryList);
        //    int total = 0;
        //    foreach(int item in mostCalories )
        //    {
        //        total += item;
        //    }
        //    Console.WriteLine(total);
        //}
        
        static private List<int> ReadInput(string filePath)
        {
            List<int> caloryList = new List<int>();
            caloryList.Add(0);
            int index = 0;

            foreach (string line in System.IO.File.ReadLines(filePath))
            {
                if(line == "")
                {
                    caloryList.Add(0);
                    index++;
                } else
                {
                    caloryList[index] += int.Parse(line);
                }
            }
            return caloryList;
        }

        static private int FindBiggestItemInList(List<int> list)
        {
            int indexOfBiggestItem = 0;
            
            for(int i = 0; i < list.Count; i++)
            {
                if (list[i] > list[indexOfBiggestItem])
                {
                    indexOfBiggestItem = i;
                }
            }
            return list[indexOfBiggestItem];
        }

        static private int[] FindThreeBiggestItemsInList(List<int> list)
        {
            int[] result = new int[3];

            list.Sort();
            result[0] = list[list.Count-1];
            result[1] = list[list.Count-2];
            result[2] = list[list.Count-3];
            return result;
        }
    }
}
