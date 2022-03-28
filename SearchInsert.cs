
#Given a sorted array of distinct integers and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.
#Note: The algorithm should have run time complexity of O (log n).

#Example 1:
#Input: nums = [1,3,5,6], target = 5
#Output: 2
#Example 2:
#Input: nums = [1,3,5,6], target = 2
#Output: 1


using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace SearchInsert
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("Question 1:");
            int[] nums1 = { 0, 1, 2, 3, 12 };
            Console.WriteLine("Enter the target number:");
            int target = Int32.Parse(Console.ReadLine());
            int pos = SearchInsert(nums1, target);
            Console.WriteLine("Insert Position of the target is : {0}", pos);
            Console.WriteLine("");
        }
        
        
        public static int SearchInsert(int[] nums, int target)
        {
            try
            {
                //To apply binary search initialize min, max and calulate mid
                //break array into two, if target in 1st eleiminate 2nd
                //keep breaking into halfs till reaches the target
                int min = 0;
                int max = nums.Length - 1;

                while (true)
                {
                    int mid = (min + max) / 2;
                    //found target at the centre
                    if (target == nums[mid])
                    {
                        return (mid + 1);
                    }
                    //if target greater than largest value in array
                    else if (target > nums[max])
                    {
                        return (max + 1);
                    }
                    //if target less than smallest value in array
                    else if (target < nums[min])
                    {
                        return (min + 1);
                    }
                    //check if target in 2nd half
                    else if (target > nums[mid])
                    {
                        min = mid + 1;
                    }
                    //check if target in 1st half
                    else if (target < nums[mid])
                    {
                        max = mid - 1;
                    }
                    //target not in array and we have the a
                    else if (min - max == 1)
                    {
                        return (min + 1);
                    }

                }
            }
            catch (Exception)
            {
                throw;
            }
        }

