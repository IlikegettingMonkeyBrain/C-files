using System;

class Program
{
    public static void Main(string[] args)
    {
            string user1, user2;
        Console.WriteLine("Welcome to Rock, Paper, And Scissors Game");

        Console.WriteLine("User 1: Enter Rock, Paper, or Scissors");
        user1 = Console.ReadLine();

        Console.WriteLine("User 2: Enter Rock, Paper, or Scissors");
        user2 = Console.ReadLine();

        if (user1 == "Rock")
        {
            if (user2 == "Paper")
            {
                Console.WriteLine("user2 Has Won The Game");
            }
            if (user2 == "Rock")
            {
                Console.WriteLine("Tie");
            }
            if (user2 == "Scissors")
            {
                Console.WriteLine("user1 Has Won The Game");
            }
        }
        else if (user1 == "Paper")
        {
            if (user2 == "Paper")
            {
                Console.WriteLine("Tie");
            }
            if (user2 == "Rock")
            {
                Console.WriteLine("user1 Has Won The Game");
            }
            if (user2 == "Scissors")
            {
                Console.WriteLine("user2 Has Won The Game");
            }
        }
        else
          {
            if (user2 == "Paper")
            {
                Console.WriteLine("user1 Has Won The Game");
            }
            if (user2 == "Rock")
            {
                Console.WriteLine("user2 Has Won The Game");
            }
            if (user2 == "Scissors")
            {
                Console.WriteLine("Tie");
            }
        }
  }
}            
        
