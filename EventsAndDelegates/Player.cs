using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    internal class Player
    {
        //Player Name
        public string PlayerName { get; set; }

        //Simple Constructor
        public Player(string name)
        {
            this.PlayerName = name;
            //subscribe to the OnGameStart and OnGameOver events.
            //when a new object gets created it's methods will automatically add to the delegates or in other words they will be subscribed to
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;
        }

        //at the start of the game, spawn the player
        private void StartGame()
        {
            Console.WriteLine($"Spawning Player with ID: {PlayerName}");
        }

        //when the game is over, remove the player from the game
        private void GameOver()
        {
            Console.WriteLine($"Removing Player with ID : {PlayerName}");
        }
    }
}
