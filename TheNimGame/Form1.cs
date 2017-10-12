using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Phu Ly 
// PROJECT 1-GAME_OF_NIM
// 10/2/2017


namespace TheNimGame
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();

        }
        private List<Player> playersList = new List<Player>(2);
        private Player currentPlayer;
        private Player PreviousPlayer;
        private Player player1;
        private Player player2;
        private bool turn =false;
        private const int maxRows = 4;
        private const int maxCols = 7;
        private BoardModel internalBoardRep = new BoardModel(maxRows);

        int marblesSelectedCount = 0;  // Total number of marbles selected in current turn
        int rowID;                     // row number of row just slected by current player
        int totalMarble = 16;             //total number of marble

        private string playerAName;
        private string playerBName;
        private Button[,] newButton = new Button[maxRows, maxCols];
        private Button[] newRowButton = new Button[maxRows];

        // Creates the Nim Board for play
        private void createBoard()
        {
            // Dynamically Creates a 4x7 grid and associated row buttons  
            // Written by Bill Hall with Joe Jupin and FLF
            // This should be enough help for all of you to adapt this to your own needs
            pnlBoard.Visible = true;

            Size size = new Size(50, 50);
            Point loc = new Point(0, 0);
            int padding = 10;
            int topMargin = 70;

            // The board is treated like a maxRows x MaxCols array
            for (int row = 0; row < maxRows; row++)
            {
                // For each new row, insert at left the Row i Button
                loc.Y = (topMargin + 10) + row * (size.Height + padding);
                int rowBtnExtraLeftPadding = 15;
                newRowButton[row] = new System.Windows.Forms.Button();
                newRowButton[row].Location = new Point(rowBtnExtraLeftPadding, loc.Y);
                newRowButton[row].Size = new Size(75, 23);
                newRowButton[row].Text = "Row " + (row + 1) + " -->";
                newRowButton[row].Enabled = true;
                newRowButton[row].Visible = true;
                newRowButton[row].Name = "rowBtn" + row;
                newRowButton[row].Click += new EventHandler(RowButton_Click);
                newRowButton[row].BackColor = System.Drawing.Color.White;
            
                // Add row button to the form
                pnlBoard.Controls.Add(newRowButton[row]);

                loc.Y = topMargin + row * (size.Height + padding);
                int extraLeftPadding = 100;
                for (int col = 0; col < maxCols; col++)
                {

                    newButton[row, col] = new System.Windows.Forms.Button();
                    newButton[row, col].Location = new Point(extraLeftPadding + col * (size.Width + padding), loc.Y);
                    newButton[row, col].Size = size;
                    newButton[row, col].Text = "";
                    newButton[row, col].Enabled = false;
                    newButton[row, col].Visible = true;
                    newButton[row, col].Name = "btn" + row + col;

                    // Associates the same event handler with each of the buttons generated
                    newButton[row, col].Click += new EventHandler(Button_Click);

                    // Add button to the form
                    pnlBoard.Controls.Add(newButton[row, col]);
                } // end for col
            } // end for row

            lblYourTurn.Visible = true;
            txtCurrentPlayer.Visible = true;
            // Set up the board with the 16 marbles
            newButton[0, maxCols / 2].Text = "X";
            for (int i = maxCols / 2 - 1; i <= maxCols / 2 + 1; i++)
                newButton[1, i].Text = "X";
            for (int i = maxCols / 2 - 2; i <= maxCols / 2 + 2; i++)
                newButton[2, i].Text = "X";

            for (int i = maxCols / 2 - 3; i <= maxCols / 2 + 3; i++)
                newButton[3, i].Text = "X";



        } // end createBoard
        // This is the handler for the four row buttons
        // It uses sender argument to determine which row button was selected
        // The argument is of type object and must be converted to type button in
        //    order to change its properties
        private void RowButton_Click(object sender, EventArgs e)
        {
            rowID = convertCharToInt(((Button)sender).Name[6]);
            //  MessageBox.Show("Row Button [" + (rowID+1) + "] has been selected!");
            // BackColor = System.Drawing.Color.Green;
            for (int i = 0; i < maxRows; i++) newRowButton[i].Enabled = false;
            if (rowID == 0) newButton[rowID, maxCols / 2].Enabled = true;
            newButton[rowID, maxCols / 2].BackColor = System.Drawing.Color.Red;
            if (rowID == 1) for (int i = maxCols / 2 - 1; i <= maxCols / 2 + 1; i++)
                {
                    newButton[rowID, i].Enabled = true;
                    newButton[rowID, i].BackColor = System.Drawing.Color.Red;
                }
            if (rowID == 2) for (int i = maxCols / 2 - 2; i <= maxCols / 2 + 2; i++)
                {
                    newButton[rowID, i].Enabled = true;
                    newButton[rowID, i].BackColor = System.Drawing.Color.Red;
                }
            if (rowID == 3) for (int i = maxCols / 2 - 3; i <= maxCols / 2 + 3; i++)
                {
                    newButton[rowID, i].Enabled = true;
                    newButton[rowID, i].BackColor = System.Drawing.Color.Red;
                }
            btnEndTurn.Enabled = true;
        } // end button clickhandler 

        // This is the handler for all 16 clickable marble buttons
        // It uses sender argument to determine which marble button was selected
        // The argument is of type object and must be converted to type button in
        //    order to change its properties
        private void Button_Click(object sender, EventArgs e)
        {
            if (totalMarble>1)
            {
                ((Button)sender).Visible = false;
                marblesSelectedCount++;
            }
            else
            {
                MessageBox.Show("YOU CANT DO THAT OR YOU WILL LOSE. PLEASE REMOVE ALL THE MARBLE EXCEPT ONE", "ERROR");
            }
            totalMarble--;
            

        } // end button clickhandler         

        // Convert a charcter to its equivalent integer
        int convertCharToInt(Char c)
        {
            return ((int)(c) - (int)('0'));
        }  // end convertCharToInt

        //check to see if name is blank, if blank display messagebox
        private void btnOK1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPlayer1Name.Text))
            {
                MessageBox.Show("Please enter a valid name!", "Invalid name");

                txtPlayer1Name.Text = "";
            }
            else
            {
                lblPlayer2Name.Enabled = true;
                txtPlayer2Name.Enabled = true;
                btnOK2.Enabled = true;
                btnOK1.Enabled = false;
            }

            player1 = new Player(txtPlayer1Name.Text, 0);
            playersList.Add(player1);    //create new player object
            playerAName = player1.Name;
            txtPlayer2Name.Focus();
            
        }
        //check if name is the same or blank
        //display messagebox if false
        private void btnOK2_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtPlayer2Name.Text))
            {
                MessageBox.Show("Please enter a valid name!", "Invalid name");
                txtPlayer2Name.Text = "";
                txtPlayer2Name.Focus();
            }
            else if (txtPlayer2Name.Text.Equals(txtPlayer1Name.Text))
            {
                MessageBox.Show("Name cannot be the same as Player 1, Please re-enter name! ", "Invalid name");
                txtPlayer2Name.Text = "";
                txtPlayer2Name.Focus();
            }
            else
            {
                btnReadytoPlay.Enabled = true;
                lblReady.Enabled = true;
                btnOK2.Enabled = false;
            }
            player2 = new Player(txtPlayer2Name.Text, 0); //create new player object
            playersList.Add(player2);
            playerBName = player2.Name;
        }



        //display btn and creatBoard
        private void btnReadytoPlay_Click(object sender, EventArgs e)
        {
            txtCurrentPlayer.Enabled = true;
            lblYourTurn.Enabled = true;
            lblGameInstruction.Enabled = true;
            createBoard();

            currentPlayer = player1;
            txtCurrentPlayer.Text = currentPlayer.Name;
            btnReadytoPlay.Enabled = false;
        }

        private void btnEndTurn_Click(object sender, EventArgs e)
        {

            if (marblesSelectedCount > 0)
            {
                MessageBox.Show(string.Format("{0} has selected {1} marble this turn!", currentPlayer.Name, marblesSelectedCount));

                turnRotate(); // rotate turn betwweeen players
                internalBoardRep.setValue(rowID, marblesSelectedCount);  
                internalBoardRep.subtractMarble();
                //internalBoardRep.print();
                // MessageBox.Show(string.Format("{0} has selected {1} marble this turn!", currentPlayer.Name,marblesSelectedCount));
                for (int i = 0; i < maxRows; i++) // this for loop enable row button that is now empty
                {
                    if (!internalBoardRep.checkForEmptyRow(i))
                    {
                        newRowButton[i].Enabled = true;
                    }
                }
                disableRowButton(); //disable 
                disableColumBtn();// disable button 
                marblesSelectedCount = 0;
                //check for winner
                if (internalBoardRep.isWinner())
                {
                    MessageBox.Show(string.Format("{0} IS THE WINNER OF THIS NIM GAME!", PreviousPlayer.Name));
                    disableVisibleRowButton();
                    btnEndTurn.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Please select at least 1 marble");
            }
        }
        //code to rotate turn between players
        private void turnRotate()
        {
            if (turn)
            {
                currentPlayer = player1;
                PreviousPlayer = player2;
                txtCurrentPlayer.Text = currentPlayer.Name;
            }
            else
            {
                currentPlayer = player2;
                PreviousPlayer = player1;
                txtCurrentPlayer.Text = currentPlayer.Name;
            }
            if (!(totalMarble == 1))
            {
                turn = !turn;
            }
        }
        //disable the button method 
        private void disableColumBtn()
        {
            for (int i = 0; i < maxRows; i++)
            {
                if (!internalBoardRep.checkForEmptyRow(i))
                {
                    if (rowID == 1) for (i = maxCols / 2 - 1; i <= maxCols / 2 + 1; i++) newButton[rowID, i].Enabled = false;
                    if (rowID == 2) for (i = maxCols / 2 - 2; i <= maxCols / 2 + 2; i++) newButton[rowID, i].Enabled = false;
                    if (rowID == 3) for (i = maxCols / 2 - 3; i <= maxCols / 2 + 3; i++) newButton[rowID, i].Enabled = false;
                }
            }
        }
        //disable row method
        private void disableRowButton()
        {
            for (int i = 0; i < maxRows; i++)
            {
                if (internalBoardRep.checkForEmptyRow(i))
                {
                    newRowButton[i].Visible = false;
                }
            }
        }

        //make the row dissapear by checking if the board is empty,if empty make it visable.
        private void disableVisibleRowButton()
        {
            for (int i = 0; i < maxRows; i++)
            {
                if (!internalBoardRep.checkForEmptyRow(i))
                {
                    newRowButton[i].Visible = false;
                }
            }
        }

        //quit the game
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
