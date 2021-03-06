#Alice and Bob are playing a new game of stones. There are N stones placed on the ground, forming a sequence. The stones are labeled from 1 to N. Alice and Bob in turns take exactly two consecutive stones on the ground until there are no consecutive stones on the ground. That is, each player can take stone π and stone π+1, where 1β€πβ€πβ1. If the number of stone left is odd, Alice wins. Otherwise, Bob wins.
#Assume both Alice and Bob play optimally and Alice plays first, do you know who the winner is?

#Input
#The input contains an integer π (1β€πβ€10000000), the number of stones.

#Output
#Output the winner, βAliceβ or βBobβ (without the quotes), on a line.

#Sample Input 1	Sample Output 1
#1			Alice
#Sample Input 2	Sample Output 2
32			Bob

using System;
namespace Two_stones
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            if (x%2 == 1)
            {
                Console.WriteLine("Alice");
            }
            else
            {
                Console.WriteLine("Bob");
            }
            
        }
    }
}
