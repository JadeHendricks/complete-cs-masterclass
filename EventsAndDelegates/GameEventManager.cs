using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    internal class GameEventManager
    {
        //a new delegate type called GameEvent
        //a multicast delegate is a delegate that works as a list and can store a list to more than one method

        //a new delegate type called GameEvent
        public delegate void GameEvent();

        //create two delegates variables called OnGameStart and OnGameOver
        //using event keyword here will prevent us from overwritting our events in other classes if that is something that is required
        public static event GameEvent OnGameStart, OnGameOver;

        //adding two public static methods to trigger the methods in our main method
        //a static method to trigger OnGameStart
        public static void TriggerGameStart()
        {
            //check if the OnGameStart event is to empty, meaning that other methods are already subscribed
            if (OnGameStart != null)
            {
                //print simple message
                Console.WriteLine("The game has Started!");
                //call the OnGameStart that will trigger all the methods subscribed to this event
                OnGameStart();
            }
        }

        public static void TriggerGameOver()
        {
            //check if the OnGameStart event is ot empty, meaning that other methods are already subscribed
            if (OnGameOver != null)
            {
                //print simple message
                Console.WriteLine("The game is over...");
                //call the OnGameStart that will trigger all the methods subscribed to this event
                OnGameOver();
            }
        }
    }
}
