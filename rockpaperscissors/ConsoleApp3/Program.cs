using System;
using System.Globalization;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random= new Random();
            bool playAgain = true;
            string endGame;
            string player;
            string computer;

            while ( playAgain )
            {
                player = string.Empty; computer = string.Empty;

                while (player != "rock" && player != "paper" && player != "scissors")
                {

                    Console.WriteLine("Rock/Paper/Scissors?:");
                    player = Console.ReadLine();
                    player = player.ToLower();
                }

                int randomNum = random.Next(1,4);
                switch (randomNum)
                {
                    case 1:
                        computer = "rock";
                        break;
                    case 2:
                        computer = "paper";
                        break;
                    case 3:
                        computer = "scissors";
                        break;

                }
                Console.WriteLine("Player: " + player);
                Console.WriteLine("Computer: " + computer);

                switch (player)
                {
                    case "rock":
                        if (computer == "rock"){
                            Console.WriteLine("draw");
                        }

                        if (computer == "paper"){
                            Console.WriteLine("computer wins");
                        }
                        if (computer == "scissors") {
                            Console.WriteLine("you win!");
                        }

                            
                        break;

                    case "paper":
                        if (computer == "rock")
                            {
                            Console.WriteLine("you win!");
                        }

                        if (computer == "paper"){
                            Console.WriteLine("draw");
                        }
                        if (computer == "scissors") {
                            Console.WriteLine("computer wins!");
                        }


                        break;

                    case "scissors":
                        if (computer == "scissors"){
                            Console.WriteLine("draw");
                        }

                        if (computer == "paper"){
                            Console.WriteLine("you win!");
                        }
                        if (computer == "rock") {
                            Console.WriteLine("computer wins!");
                        }
                        break;
                }
                Console.WriteLine("Would you like to play again? (yes/no) ");
                endGame = Console.ReadLine();
                endGame= endGame.ToLower();

                if (endGame == "yes")
                {
                    playAgain= true;
                }
                else
                {
                    playAgain= false;
                } 

            }

            

          
            

            
                
            
            
            
               
            
            Console.ReadKey();
        }
    }
}
