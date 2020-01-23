using System;
using System.Collections.Generic;

namespace rock_paper_scissors
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      bool validate = true;
      Random random = new Random();
      int compChoice = random.Next(3);

      while (validate)
      {
        Console.WriteLine("Choose: Rock, Paper, Scissors");
        string userChoice = Console.ReadLine().ToLower();
        if (userChoice == "rock")
        {
          if (compChoice == 0)
          {
            Console.WriteLine("You chose Rock. AI chose Rock.");
            Console.WriteLine("DRAW!");
          }
          else if (compChoice == 1)
          {
            Console.WriteLine("You chose Rock. AI chose Paper.");
            Console.WriteLine("YOU LOSE!");

          }
          else if (compChoice == 2)
          {
            Console.WriteLine("You chose Rock. AI chose Scissors.");
            Console.WriteLine("YOU WIN!!!");
          }
          validate = false;
        }
        else if (userChoice == "paper")
        {
          if (compChoice == 0)
          {
            Console.WriteLine("You chose Paper. AI chose Rock.");
            Console.WriteLine("YOU WIN!!!");
          }
          else if (compChoice == 1)
          {
            Console.WriteLine("You chose Paper. AI chose Paper.");
            Console.WriteLine("DRAW!");

          }
          else if (compChoice == 2)
          {
            Console.WriteLine("You chose Paper. AI chose Scissors.");
            Console.WriteLine("YOU LOSE!");
          }
          validate = false;
        }
        else if (userChoice == "scissors")
        {
          if (compChoice == 0)
          {
            Console.WriteLine("You chose Scissors. AI chose Rock.");
            Console.WriteLine("YOU LOSE!");
          }
          else if (compChoice == 1)
          {
            Console.WriteLine("You chose Scissors. AI chose Paper.");
            Console.WriteLine("YOU WIN!!!");

          }
          else if (compChoice == 2)
          {
            Console.WriteLine("You chose Scissors. AI chose Scissors.");
            Console.WriteLine("DRAW!");
          }
          validate = false;
        }
        else
        {
          Console.WriteLine("You chose \"" + userChoice + "\". Why??");
          Console.WriteLine("Choose Again!");
        }
      }

      //Dictionary<int, string> choices = new Dictionary<int, string>();

      //END
    }
  }
}
