using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//PHU LY
namespace TheNimGame
{
    class BoardModel
    {
        const int marblesCountMax = 16;            // Number of marbles on the Board
        int currentMarbleCount = marblesCountMax;
        int rowMax;
        int intRowID=0;
        int intMarbleSelectedCount=0;

        // This is the "internal board".  First element is ignored.
        int[] rowMarbleCounts = { 1, 3, 5, 7 };  // Counts decreased until they reach 0

        // private char[] internalBoardRep = new char[SIZE];  // The board representation itself

        // Parameterless Constructor (currently not used)
        public BoardModel()
        {
            resetGame();
        } // end Parameterless Constructor

        public void setValue(int rowID, int marbleSelectedCount)
        {
            intRowID = rowID;
            intMarbleSelectedCount = marbleSelectedCount;
        }
        public string GetMarbleCount()
        {
            return intMarbleSelectedCount.ToString();
        }
        // Parameterized Constructor - resets the game and sets number of rows
        public BoardModel(int rowCount)
        {
            rowMax = rowCount;
            // resetGame();
        } // end New
         
        public bool checkForEmptyRow(int rowId)
        {
            if (rowMarbleCounts[rowId] == 0)
            {
                return true;
            }
           else
            {
                return false;
            }
        }

        public void subtractMarble()
        {
            rowMarbleCounts[intRowID] = rowMarbleCounts[intRowID] - intMarbleSelectedCount;
            currentMarbleCount = currentMarbleCount - intMarbleSelectedCount;
        }


        public void print()
        {
            string array = "";
            for(int i = 0; i < rowMarbleCounts.Length; i++)
            {
                array = array + rowMarbleCounts[i];
            }
            

            System.Windows.Forms.MessageBox.Show(array);
        }
        
           
                
        
        // Updates key simulation information each time a player takes a turn
        // Returns true if marble counts for a row becomes empty
        public bool recordTurn
            (int rowID,            // IN: represents ID of the row selected by the player
             int currentSelectionCount) // IN: represents number of marbles just selected in that row        
        {
            rowMarbleCounts[rowID] = rowMarbleCounts[rowID] - currentSelectionCount;
            currentMarbleCount = currentMarbleCount - currentSelectionCount;
            if (rowMarbleCounts[rowID] == 0)
                return true;
            else
                return false;
        } // end recordTurn



        // Get and return count of marbles left in row i  (0 <= i <= 3)
        public int getRowCount(int i)
        {
            return rowMarbleCounts[i];

        }  // end getRowCount



        // Resets the board for a new game
        public void resetGame()
        {
            clearInternalBoardRep();
        } // end resetGame



        // Actually clears each cell in the Board by resetting it to Blank
        private void clearInternalBoardRep()
        {
            currentMarbleCount = marblesCountMax;
            for (int i = 0; i < rowMax; i++)
                rowMarbleCounts[i] = 2 * i + 1;
        } // end clearInternalBoardRep   



        // Determines if there is a winner by checking if currentMarbleCount has become 1
        // In this case the player that just played is the winner
        // Returns: True if there is a winner and False otherwise
        public Boolean isWinner()
        {
            Boolean result = false;
            if (currentMarbleCount == 1)
            {
                result = true;
            }
            return result;
            
        } // end hasPlayerWon

    }  // end Board Model Class
}  // end Namespace

   