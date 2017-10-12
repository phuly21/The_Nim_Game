using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheNimGame
{
    class Player
    {
        private string hiddenName;
        private int hiddenWinsCount;
        private int hiddenMarblesCount;
        private int hiddenPlayOrder;

        public Player(string name, int playOrder)
        {
            hiddenName = name;
            hiddenPlayOrder = playOrder;
            hiddenWinsCount = 0;
            hiddenMarblesCount = 0;

        } // end New


        // Read only properties
        public int MarblesCount
        {
            get { return hiddenMarblesCount; }
        } // end property Icon

        public string Name
        {
            get { return hiddenName; }
        } // end property Name


        public int Wins
        {
            get { return hiddenWinsCount; }
        } // end property Wins


        // Increment number of wins for this player
        public void won()
        {
            hiddenWinsCount = hiddenWinsCount + 1;
        } // end isWin


        // Update marbles count for this player (not used)
        public void updatePlayerMarblesCount(
            int thisCount)  // IN: count of marbles just taken by this player 
        {
            hiddenMarblesCount = hiddenMarblesCount + thisCount;
        }  // end updatePlayerMarblesCount

    }  // end PlayerModel Class
}  // end Namespace





