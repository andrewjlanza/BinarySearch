using System;

namespace BinarySearch
{
  class Program
  {
    static void Main(string[] args)
    {
      //  set a number range (min/max)

      var min = 0;
      var max = 100;
      var input = "";
      var currentPick = (max + min) / 2;
      var pick = (max + min) / 2;

      // tell user to pick a number
      System.Console.WriteLine($"Think of a number between {min} and {max}");

      while (input != "equal")
      {
        // ask the user if higher or lower than our pick
        System.Console.WriteLine($"Is your number higher or lower or equal to {(max + min) / 2}?");
        //why not var input vvbelowvv
        input = Console.ReadLine();

        if (input == "higher")
        {
          min = ((max + min) / 2) + 1;
        }
        else if (input == "lower")
        {
          max = ((max + min) / 2) - 1;
        }
        else if (input == "equal")
        {
          System.Console.WriteLine("Lols nice try");
        };
      }
    }

    // var input = Console.ReadLine("hey");
    // 

    //reset the number range based on user answer

    //repeat until guessed 


  }
}






