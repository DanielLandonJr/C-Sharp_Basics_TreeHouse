using System;

namespace Treehouse
{
  class Program
  {
    static void Main() 
    {
      double runningTotal = 0;
      bool keepGoing = true;

      while (keepGoing)
      {
        // prompt the user for minutes exercised
        Console.Write("Enter How Many Minutes You Exercised Or Type \"quit\" To Exit: ");

        string entry = Console.ReadLine();

        if(entry.ToLower() == "quit")
        {
          keepGoing = false;
        }
        else
        {
          try
          {
            double minutes = double.Parse(entry);

            if(minutes <= 0)
            {
              Console.WriteLine(minutes + " is not an acceptable number.");
              // causes loop to start over
              continue;
            }
            else if(minutes <= 10)
            {
              Console.WriteLine("Better than nothing, am I right?");
            }
            else if(minutes <= 30)
            {
              Console.WriteLine("Way to go Hot Stuff!");
            }
            else if(minutes <= 60)
            {
              Console.WriteLine("You must be a Ninja Warrior in training!");
            }
            else
            {
              Console.WriteLine("Now your just showing off!");
            }

            // add minutes exercised to running total

            runningTotal = runningTotal + minutes;
          }
          catch(FormatException)
          {
              Console.WriteLine("Invalid Entry!!!");
              // causes loop to start over
              continue;
          }

          // display total minutes exercised on screen
          Console.WriteLine("You've entered " + runningTotal + " minutes.");
        }

        // repeat until the user quits
      }

      Console.WriteLine("Goodbye");
    }
  }
}