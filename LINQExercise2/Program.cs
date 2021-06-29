using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Or I could have done it this way
            List<string> games = new List<string>() {"The Sims", "Mario", "Donkey Kong", "Valorant", "Halo"};*/

            List<string> games = new List<string>();
            var completeList = games.Append("The Sims").Append("Mario").Append("Donkey Kong").Append("Valorant").Append("Halo");
            var ordered = completeList.OrderBy(game => game.Length);
            var alpha = completeList.OrderBy(game => game);
            var longest = completeList.OrderByDescending(game => game.Length).Take(1);
            var shortest = completeList.OrderBy(game => game.Length).Take(1);
            var evenCount = completeList.Where(game => game.Length % 2 == 0);
            var oddCount = completeList.Where(game => game.Length % 2 != 0);
            var counted = completeList.Count();
            

            Console.WriteLine("----------------------------");
            Console.WriteLine("Original List of Games");
            Console.WriteLine("- - - - - - - - - - -");
            foreach (var item in completeList)
            {
                
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine("Ordered List by Length");
            Console.WriteLine("- - - - - - - - - - -");
            foreach (var item in ordered)
            {
                
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine("List in Alphabetical Order");
            Console.WriteLine("- - - - - - - - - - -");
            foreach (var item in alpha)
            {

                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine("Longest in List");
            Console.WriteLine("- - - - - - - - - - -");
            foreach (var item in longest)
            {

                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine("Shortest in List");
            Console.WriteLine("- - - - - - - - - - -");
            foreach (var item in shortest)
            {

                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine("Items with Even Length Count");
            Console.WriteLine("- - - - - - - - - - -");
            foreach (var item in evenCount)
            {

                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine("Items with Odd Length Count");
            Console.WriteLine("- - - - - - - - - - -");
            foreach (var item in oddCount)
            {

                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine("Number of Items in List");
            Console.WriteLine("- - - - - - - - - - -");
            Console.WriteLine(counted);
            Console.WriteLine("----------------------------");
            
           
        }
    }
    
}
