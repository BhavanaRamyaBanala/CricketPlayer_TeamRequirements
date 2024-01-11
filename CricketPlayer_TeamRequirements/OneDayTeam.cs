using System;
using System.Collections.Generic;
using System.Linq;


namespace CricketPlayer_TeamRequirements
{
    public class OneDayTeam : ITeam
    {
        private List<Player> players;

        public OneDayTeam()
        {
            players = new List<Player>();
            players.Capacity = 11;
        }

        public void AddPlayer(Player player)
        {
            if (players.Count < 11)
            {
                players.Add(player);
                Console.WriteLine($"Player {player.Name} is added succesfully to the team.");
            }
            else
            {
                Console.WriteLine("The team cannot have more than 11 players.");
            }
        }

        public void RemovePlayer(int playerId)
        {
            Player playerToRemove = players.FirstOrDefault(p => p.Id == playerId);
            if (playerToRemove != null)
            {
                players.Remove(playerToRemove);
                Console.WriteLine($"Player {playerToRemove.Name} is removed successfully from the team.");
            }
            else
            {
                Console.WriteLine($"Player with Id {playerId} not found in the team.");
            }
        }

        public Player GetPlayerById(int playerId)
        {
            return players.FirstOrDefault(p => p.Id == playerId);
        }

        public List<Player> GetPlayersByName(string playerName)
        {
            return players.Where(p => p.Name.Equals(playerName, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<Player> GetAllPlayers()
        {
            return players.ToList();
        }
    }
}