#Given an array of integers arr, a lucky integer is an integer that has a frequency in the array equal to its value.Return the largest lucky integer in the array. If there is no lucky integer return -1.


#Example 1:
#Input: arr = [2,2,3,4]
#Output: 2
#Explanation: The only lucky number in the array is 2 because frequency[2] == 2.



using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace FindLucky
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 2, 2, 3, 4 };
            int lucky_number = FindLucky(arr1);
            Console.WriteLine("The Lucky number in the given array is {0}", lucky_number);
            Console.WriteLine();
         }
         public static int FindLucky(int[] arr)
        {
            try
            {
                //initialize dic to collect unique numbers and it's counts
                Dictionary<int, int> numcount = new Dictionary<int, int>();

                //iterate within nums array
                //add 1 to count if num exits
                //intialize a key: num ; value:1
                foreach (int s in arr)
                {
                    bool keyExists = numcount.ContainsKey(s);
                    if (keyExists)
                    {
                        numcount[s]++;
                    }
                    else
                    {
                        numcount.Add(s, 1);
                    }
                }
                //list to collect all lucky numbers
                List<int> nums = new List<int>();

                foreach (KeyValuePair<int, int> temp in numcount)
                {
                    if (temp.Value == temp.Key)
                    {
                        nums.Add(temp.Key);
                    }
                }

                //if no lucky numbers
                if (nums.Count == 0)
                {
                    return -1;
                }
                //return the max lucky number
                else
                {
                    return (nums.Max());
                }

            }
            catch (Exception)
            {

                throw;
            }

        }
