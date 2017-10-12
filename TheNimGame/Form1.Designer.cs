namespace TheNimGame
{
    partial class form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.lblwelcome = new System.Windows.Forms.Label();
            this.lblPlayer2Name = new System.Windows.Forms.Label();
            this.lblPlayer1Name = new System.Windows.Forms.Label();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.btnOK1 = new System.Windows.Forms.Button();
            this.txtPlayer2Name = new System.Windows.Forms.TextBox();
            this.txtPlayer1Name = new System.Windows.Forms.TextBox();
            this.btnOK2 = new System.Windows.Forms.Button();
            this.lblReady = new System.Windows.Forms.Label();
            this.btnReadytoPlay = new System.Windows.Forms.Button();
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.btnEndTurn = new System.Windows.Forms.Button();
            this.lblYourTurn = new System.Windows.Forms.Label();
            this.txtCurrentPlayer = new System.Windows.Forms.TextBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblGameInstruction = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblwelcome
            // 
            this.lblwelcome.AutoSize = true;
            this.lblwelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblwelcome.Location = new System.Drawing.Point(37, 27);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(301, 26);
            this.lblwelcome.TabIndex = 0;
            this.lblwelcome.Text = "Welcome to the game of Nim!";
            // 
            // lblPlayer2Name
            // 
            this.lblPlayer2Name.AutoSize = true;
            this.lblPlayer2Name.Enabled = false;
            this.lblPlayer2Name.Location = new System.Drawing.Point(64, 178);
            this.lblPlayer2Name.Name = "lblPlayer2Name";
            this.lblPlayer2Name.Size = new System.Drawing.Size(145, 17);
            this.lblPlayer2Name.TabIndex = 1;
            this.lblPlayer2Name.Text = "Second Player Name:";
            // 
            // lblPlayer1Name
            // 
            this.lblPlayer1Name.AutoSize = true;
            this.lblPlayer1Name.Location = new System.Drawing.Point(64, 134);
            this.lblPlayer1Name.Name = "lblPlayer1Name";
            this.lblPlayer1Name.Size = new System.Drawing.Size(124, 17);
            this.lblPlayer1Name.TabIndex = 2;
            this.lblPlayer1Name.Text = "First Player Name:";
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.BackColor = System.Drawing.SystemColors.Info;
            this.lblInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.Location = new System.Drawing.Point(104, 71);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(676, 24);
            this.lblInstruction.TabIndex = 3;
            this.lblInstruction.Text = "Welcome to the Game of NIM. To play enter your name and click the OK button.";
            // 
            // btnOK1
            // 
            this.btnOK1.Location = new System.Drawing.Point(367, 128);
            this.btnOK1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK1.Name = "btnOK1";
            this.btnOK1.Size = new System.Drawing.Size(45, 23);
            this.btnOK1.TabIndex = 4;
            this.btnOK1.Text = "OK";
            this.btnOK1.UseVisualStyleBackColor = true;
            this.btnOK1.Click += new System.EventHandler(this.btnOK1_Click);
            // 
            // txtPlayer2Name
            // 
            this.txtPlayer2Name.Enabled = false;
            this.txtPlayer2Name.Location = new System.Drawing.Point(220, 174);
            this.txtPlayer2Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPlayer2Name.Name = "txtPlayer2Name";
            this.txtPlayer2Name.Size = new System.Drawing.Size(100, 22);
            this.txtPlayer2Name.TabIndex = 5;
            // 
            // txtPlayer1Name
            // 
            this.txtPlayer1Name.Location = new System.Drawing.Point(220, 130);
            this.txtPlayer1Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPlayer1Name.Name = "txtPlayer1Name";
            this.txtPlayer1Name.Size = new System.Drawing.Size(100, 22);
            this.txtPlayer1Name.TabIndex = 6;
            // 
            // btnOK2
            // 
            this.btnOK2.Enabled = false;
            this.btnOK2.Location = new System.Drawing.Point(367, 178);
            this.btnOK2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK2.Name = "btnOK2";
            this.btnOK2.Size = new System.Drawing.Size(45, 23);
            this.btnOK2.TabIndex = 7;
            this.btnOK2.Text = "OK";
            this.btnOK2.UseVisualStyleBackColor = true;
            this.btnOK2.Click += new System.EventHandler(this.btnOK2_Click);
            // 
            // lblReady
            // 
            this.lblReady.AutoSize = true;
            this.lblReady.Enabled = false;
            this.lblReady.Location = new System.Drawing.Point(64, 256);
            this.lblReady.Name = "lblReady";
            this.lblReady.Size = new System.Drawing.Size(155, 17);
            this.lblReady.TabIndex = 8;
            this.lblReady.Text = "When ready, click start!";
            // 
            // btnReadytoPlay
            // 
            this.btnReadytoPlay.Enabled = false;
            this.btnReadytoPlay.Location = new System.Drawing.Point(249, 242);
            this.btnReadytoPlay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReadytoPlay.Name = "btnReadytoPlay";
            this.btnReadytoPlay.Size = new System.Drawing.Size(105, 46);
            this.btnReadytoPlay.TabIndex = 9;
            this.btnReadytoPlay.Text = "Start";
            this.btnReadytoPlay.UseVisualStyleBackColor = true;
            this.btnReadytoPlay.Click += new System.EventHandler(this.btnReadytoPlay_Click);
            // 
            // pnlBoard
            // 
            this.pnlBoard.Location = new System.Drawing.Point(149, 380);
            this.pnlBoard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(817, 489);
            this.pnlBoard.TabIndex = 10;
            // 
            // btnEndTurn
            // 
            this.btnEndTurn.Enabled = false;
            this.btnEndTurn.Location = new System.Drawing.Point(973, 463);
            this.btnEndTurn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEndTurn.Name = "btnEndTurn";
            this.btnEndTurn.Size = new System.Drawing.Size(105, 46);
            this.btnEndTurn.TabIndex = 11;
            this.btnEndTurn.Text = "End Turn";
            this.btnEndTurn.UseVisualStyleBackColor = true;
            this.btnEndTurn.Click += new System.EventHandler(this.btnEndTurn_Click);
            // 
            // lblYourTurn
            // 
            this.lblYourTurn.AutoSize = true;
            this.lblYourTurn.Enabled = false;
            this.lblYourTurn.Location = new System.Drawing.Point(111, 310);
            this.lblYourTurn.Name = "lblYourTurn";
            this.lblYourTurn.Size = new System.Drawing.Size(108, 17);
            this.lblYourTurn.TabIndex = 12;
            this.lblYourTurn.Text = "Current PLayer:";
            // 
            // txtCurrentPlayer
            // 
            this.txtCurrentPlayer.Enabled = false;
            this.txtCurrentPlayer.Location = new System.Drawing.Point(232, 305);
            this.txtCurrentPlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCurrentPlayer.Name = "txtCurrentPlayer";
            this.txtCurrentPlayer.ReadOnly = true;
            this.txtCurrentPlayer.Size = new System.Drawing.Size(121, 22);
            this.txtCurrentPlayer.TabIndex = 13;
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnQuit.Location = new System.Drawing.Point(979, 785);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(100, 28);
            this.btnQuit.TabIndex = 14;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblGameInstruction
            // 
            this.lblGameInstruction.AutoSize = true;
            this.lblGameInstruction.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lblGameInstruction.Enabled = false;
            this.lblGameInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameInstruction.Location = new System.Drawing.Point(361, 290);
            this.lblGameInstruction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGameInstruction.Name = "lblGameInstruction";
            this.lblGameInstruction.Size = new System.Drawing.Size(563, 80);
            this.lblGameInstruction.TabIndex = 15;
            this.lblGameInstruction.Text = resources.GetString("lblGameInstruction.Text");
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1116, 828);
            this.Controls.Add(this.lblGameInstruction);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.txtCurrentPlayer);
            this.Controls.Add(this.lblYourTurn);
            this.Controls.Add(this.btnEndTurn);
            this.Controls.Add(this.pnlBoard);
            this.Controls.Add(this.btnReadytoPlay);
            this.Controls.Add(this.lblReady);
            this.Controls.Add(this.btnOK2);
            this.Controls.Add(this.txtPlayer1Name);
            this.Controls.Add(this.txtPlayer2Name);
            this.Controls.Add(this.btnOK1);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.lblPlayer1Name);
            this.Controls.Add(this.lblPlayer2Name);
            this.Controls.Add(this.lblwelcome);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Nim Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblwelcome;
        private System.Windows.Forms.Label lblPlayer2Name;
        private System.Windows.Forms.Label lblPlayer1Name;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Button btnOK1;
        private System.Windows.Forms.TextBox txtPlayer2Name;
        private System.Windows.Forms.TextBox txtPlayer1Name;
        private System.Windows.Forms.Button btnOK2;
        private System.Windows.Forms.Label lblReady;
        private System.Windows.Forms.Button btnReadytoPlay;
        private System.Windows.Forms.Panel pnlBoard;
        private System.Windows.Forms.Button btnEndTurn;
        private System.Windows.Forms.Label lblYourTurn;
        private System.Windows.Forms.TextBox txtCurrentPlayer;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblGameInstruction;
    }
}

