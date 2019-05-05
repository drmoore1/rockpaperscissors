using System;

namespace __rock
{
  class Program
  {
    static void Main(string[] args)
    {
      //Intro is splash for instructions
      #region Intro
      System.Console.Clear();
      System.Console.WriteLine("Welcome to Rock Paper Scissors");
      System.Console.WriteLine("The rules are simple, you already know them.");
      System.Console.WriteLine("Press (Q) to quit at any time");
      System.Console.WriteLine("Press any key to begin");
      //System.Console.ReadKey();
      //System.Console.Clear();
      #endregion
      //Variables for use in game
      #region
      int winCount = 0;
      int lossCount = 0;
      int playCount = 0;
      String playerInput = "";
      String tempInput = "";
      String computerSelection = "";
      Int32 computerNumSelect = 0;
      bool inputValid = false;
      //bool gameRun = true;

      #endregion
      //Main Game Logic Routine starts
      //while (gameRun == true)
      while (Console.ReadKey().Key != ConsoleKey.Q)
      {
        Console.Clear();
        System.Console.WriteLine("Total Wins: " + winCount + "   Total Losses: " + lossCount + "   Total Games: " + playCount);
        System.Console.WriteLine("Select your weapon!");
        //while loop to obtain a valid entry updates playerInput to valid string
        while (inputValid == false)
        {
          tempInput = Console.ReadLine();

          playerInput = tempInput.ToLower();
          if (playerInput == "rock")
          {
            inputValid = true;
          }
          else if (playerInput == "paper")
          {
            inputValid = true;
          }
          else if (playerInput == "scissors")
          {
            inputValid = true;
          }
          else
          {
            System.Console.Clear();
            System.Console.WriteLine("Total Wins: " + winCount + "   Total Losses: " + lossCount + "   Total Games: " + playCount);

            System.Console.WriteLine("Please select an appropriate weapon");
          }
        }
        //generate computer selection
        Console.Clear();
        #region computer selection process
        Random rng = new Random();
        computerNumSelect = rng.Next(1, 4);
        if (computerNumSelect == 1)
        {
          computerSelection = "rock";
        }
        else if (computerNumSelect == 2)
        {
          computerSelection = "paper";
        }
        else if (computerNumSelect == 3)
        {
          computerSelection = "scissors";
        }
        #endregion
        System.Console.WriteLine("Total Wins: " + winCount + "   Total Losses: " + lossCount + "   Total Games: " + playCount);
        System.Console.WriteLine("You picked " + playerInput);
        System.Console.WriteLine("Computer picked " + computerSelection);

        #region logic process for win
        if (playerInput == "rock")
        {
          if (computerSelection == "rock")
          {
            System.Console.WriteLine("Its a Tie!");
            System.Console.WriteLine("Q to quit or any other key to continue");
            playCount++;
            inputValid = false;
          }
          else if (computerSelection == "paper")
          {
            System.Console.WriteLine("You Lose, sorry");
            System.Console.WriteLine("Q to quit or any other key to continue");
            playCount++;
            lossCount++;
            inputValid = false;
          }
          else if (computerSelection == "scissors")
          {
            System.Console.WriteLine("You Win!");
            System.Console.WriteLine("Q to quit or any other key to continue");
            playCount++;
            winCount++;
            inputValid = false;
          }
        }
        if (playerInput == "paper")
        {
          if (computerSelection == "rock")
          {
            System.Console.WriteLine("You Win!");
            System.Console.WriteLine("Q to quit or any other key to continue");
            playCount++;
            winCount++;
            inputValid = false;
          }
          else if (computerSelection == "paper")
          {
            System.Console.WriteLine("Its a Tie!");
            System.Console.WriteLine("Q to quit or any other key to continue");
            playCount++;
            inputValid = false;
          }
          else if (computerSelection == "scissors")
          {
            System.Console.WriteLine("You Lose, Sorry");
            System.Console.WriteLine("Q to quit or any other key to continue");
            playCount++;
            lossCount++;
            inputValid = false;
          }
        }
        if (playerInput == "scissors")
        {
          if (computerSelection == "rock")
          {
            System.Console.WriteLine("You Lose, Sorry");
            System.Console.WriteLine("Q to quit or any other key to continue");
            playCount++;
            lossCount++;
            inputValid = false;
          }
          else if (computerSelection == "paper")
          {
            System.Console.WriteLine("You Win!");
            System.Console.WriteLine("Q to quit or any other key to continue");
            playCount++;
            winCount++;
            inputValid = false;
          }
          else if (computerSelection == "scissors")
          {
            System.Console.WriteLine("Its a Tie!");
            System.Console.WriteLine("Q to quit or any other key to continue");
            playCount++;
            inputValid = false;
          }
        }
        #endregion




      }








    }


  }
}


