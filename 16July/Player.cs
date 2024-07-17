using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerApp
{
    internal class Player
    {
        private int _playerId;
        private string _playerName;
        private int _playerAge;


        public Player(int playerId, string playerName):this(playerId, playerName, 0) { }
        public Player(int playerId, string playerName, int playerAge)
        {
            _playerId = playerId;
            _playerName = playerName;
            _playerAge = playerAge;
        }

        //if user wants to gave input to set age
        //public void setPlayerAge(int playerAge)
        //{
        //    _playerAge = playerAge;
        //}

        //helps to find player
        public static Player FindPlayer(Player[] players, int playerId)
        {
            foreach(var player in players)
            {
                if(player._playerId == playerId)
                {
                    return player;
                }

            }
            return null;
        }
        
        //helps to print player details
        public static string PrintPlayerDetails(Player[] players, int playerId)
        {
            Player playerInfo =  FindPlayer(players, playerId);
            if(playerInfo != null)
            {
                return playerInfo.ToString();
            }
            return "Player Not Found";
        }

        // the above method will return toString so we need to override the toString method
        //public override string ToString()
        // {
        //     return "Player ID : " + _playerId + " \nPlayer Name : " + _playerName + " \nPlayer Age : " + _playerAge;
        // }

        // return the oldest player
        public static string WhoIsElder(Player[] players)
        {
            int maxAge = 0;
            int elderPlayer = 0;
            string playerName = "";
            foreach(var player in players)
            {
                if(player._playerAge > maxAge)
                {
                    maxAge = player._playerAge;
                    elderPlayer = player._playerId;
                    playerName = player._playerName;
                }
            }
            return $"The max age of player is {maxAge} with player id {elderPlayer} and name {playerName}";

        }
    }
}
