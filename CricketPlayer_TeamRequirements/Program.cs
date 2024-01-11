using System;
using System.Collections.Generic;


namespace CricketPlayer_TeamRequirements
{
    class Program
    {
        static void Main(string[] args)
        {
            OneDayTeam team = new OneDayTeam();
            string yon;

            do
            {
                try
                {
                    Console.WriteLine("Enter 1:To Add Player 2.To Remove Player 3.Get Player By Id 4.Get Player By Name 5.Get All Players 6.Exit: ");
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter Player Id:");
                            int playerId = int.Parse(Console.ReadLine());

                            Console.WriteLine("Enter Player Name:");
                            string playerName = Console.ReadLine();

                            Console.WriteLine("Enter Player Age:");
                            int playerAge = int.Parse(Console.ReadLine());

                            team.AddPlayer(new Player { Id = playerId, Name = playerName, Age = playerAge });
                            break;

                        case 2:
                            Console.WriteLine("Enter Player Id to remove:");
                            int playerIdToRemove = int.Parse(Console.ReadLine());

                            team.RemovePlayer(playerIdToRemove);
                            break;

                        case 3:
                            Console.WriteLine("Enter Player Id:");
                            int playerIdToGet = int.Parse(Console.ReadLine());

                            Player playerById = team.GetPlayerById(playerIdToGet);
                            if (playerById != null)
                            {
                                Console.WriteLine($"Player Found: Id: {playerById.Id}, Name: {playerById.Name}, Age: {playerById.Age}");
                            }
                            else
                            {
                                Console.WriteLine("Player not found.");
                            }
                            break;

                        case 4:
                            Console.WriteLine("Enter Player Name:");
                            string playerNameToGet = Console.ReadLine();

                            List<Player> playersByName = team.GetPlayersByName(playerNameToGet);
                            if (playersByName.Count > 0)
                            {
                                Console.WriteLine($"Players Found with name '{playerNameToGet}':");
                                foreach (Player player in playersByName)
                                {
                                    Console.WriteLine($"Id: {player.Id}, Name: {player.Name}, Age: {player.Age}");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"No players found with name '{playerNameToGet}'.");
                            }
                            break;

                        case 5:
                            List<Player> allPlayers = team.GetAllPlayers();
                            Console.WriteLine("All Players:");
                            foreach (Player player in allPlayers)
                            {
                                Console.WriteLine($"Id: {player.Id}, Name: {player.Name}, Age: {player.Age}");
                            }
                            break;

                        case 6:
                            Console.WriteLine("Exiting the program.");
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                catch (Exception e) {
                    Console.WriteLine("Enter valid data!!");
                    Console.WriteLine(e.Message);
                }


                Console.WriteLine();
                Console.Write("Do you want to continue( yes / no ) : ");
                yon = Console.ReadLine();


            } while (yon.Equals("yes"));

            Console.ReadLine();
        }
    }
}
