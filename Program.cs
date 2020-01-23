using System;

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
            Console.WriteLine("You chose Rock. Comp chose Rock");
            Console.WriteLine("DRAW!");
          }
          else if (compChoice == 1)
          {
            Console.WriteLine("Comp chose Paper");
          }
          else if (compChoice == 2)
          {
            Console.WriteLine("Comp chose Scissors");
          }
          validate = false;
        }
        else if (userChoice == "paper")
        {
          Console.WriteLine("You chose Paper");
          validate = false;
        }
        else if (userChoice == "scissors")
        {
          Console.WriteLine("You chose Scissors");
          validate = false;
        }
        else
        {
          Console.WriteLine("Wrong");
        }
      }

      if (compChoice == 0)
      {
        Console.WriteLine("Comp chose Rock");
      }
      else if (compChoice == 1)
      {
        Console.WriteLine("Comp chose Paper");
      }
      else if (compChoice == 2)
      {
        Console.WriteLine("Comp chose Scissors");
      }

      //END
    }
  }
}
