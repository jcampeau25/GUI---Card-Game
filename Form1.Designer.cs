namespace GUI___Card_Game
{
    partial class Form1
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
            this.btnHigher = new System.Windows.Forms.Button();
            this.btnLower = new System.Windows.Forms.Button();
            this.imgCard = new System.Windows.Forms.PictureBox();
            this.btnAdd10 = new System.Windows.Forms.Button();
            this.btnAdd100 = new System.Windows.Forms.Button();
            this.btnMinus10 = new System.Windows.Forms.Button();
            this.btnMinus100 = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblBet = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnCashout = new System.Windows.Forms.Button();
            this.lblEarned = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblRules1 = new System.Windows.Forms.Label();
            this.lblRules2 = new System.Windows.Forms.Label();
            this.lblRules3 = new System.Windows.Forms.Label();
            this.lblRules4 = new System.Windows.Forms.Label();
            this.lblRules5 = new System.Windows.Forms.Label();
            this.lblRules6 = new System.Windows.Forms.Label();
            this.lblRules7 = new System.Windows.Forms.Label();
            this.lblRules8 = new System.Windows.Forms.Label();
            this.lblRules9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgCard)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHigher
            // 
            this.btnHigher.BackColor = System.Drawing.Color.Gray;
            this.btnHigher.Enabled = false;
            this.btnHigher.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHigher.ForeColor = System.Drawing.Color.Black;
            this.btnHigher.Location = new System.Drawing.Point(310, 243);
            this.btnHigher.Name = "btnHigher";
            this.btnHigher.Size = new System.Drawing.Size(88, 46);
            this.btnHigher.TabIndex = 1;
            this.btnHigher.Text = "HIGHER";
            this.btnHigher.UseVisualStyleBackColor = false;
            this.btnHigher.Click += new System.EventHandler(this.btnHigher_Click);
            // 
            // btnLower
            // 
            this.btnLower.BackColor = System.Drawing.Color.Gray;
            this.btnLower.Enabled = false;
            this.btnLower.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLower.ForeColor = System.Drawing.Color.Black;
            this.btnLower.Location = new System.Drawing.Point(417, 243);
            this.btnLower.Name = "btnLower";
            this.btnLower.Size = new System.Drawing.Size(88, 46);
            this.btnLower.TabIndex = 2;
            this.btnLower.Text = "LOWER";
            this.btnLower.UseVisualStyleBackColor = false;
            this.btnLower.Click += new System.EventHandler(this.btnLower_Click);
            // 
            // imgCard
            // 
            this.imgCard.BackColor = System.Drawing.Color.White;
            this.imgCard.Image = global::GUI___Card_Game.Properties.Resources.card_back;
            this.imgCard.Location = new System.Drawing.Point(344, 49);
            this.imgCard.Name = "imgCard";
            this.imgCard.Size = new System.Drawing.Size(127, 188);
            this.imgCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCard.TabIndex = 0;
            this.imgCard.TabStop = false;
            // 
            // btnAdd10
            // 
            this.btnAdd10.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd10.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd10.ForeColor = System.Drawing.Color.Black;
            this.btnAdd10.Location = new System.Drawing.Point(12, 344);
            this.btnAdd10.Name = "btnAdd10";
            this.btnAdd10.Size = new System.Drawing.Size(80, 44);
            this.btnAdd10.TabIndex = 3;
            this.btnAdd10.Text = "Bet +10";
            this.btnAdd10.UseVisualStyleBackColor = false;
            this.btnAdd10.Click += new System.EventHandler(this.btnAdd10_Click);
            // 
            // btnAdd100
            // 
            this.btnAdd100.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd100.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd100.ForeColor = System.Drawing.Color.Black;
            this.btnAdd100.Location = new System.Drawing.Point(12, 394);
            this.btnAdd100.Name = "btnAdd100";
            this.btnAdd100.Size = new System.Drawing.Size(80, 44);
            this.btnAdd100.TabIndex = 4;
            this.btnAdd100.Text = "Bet +100";
            this.btnAdd100.UseVisualStyleBackColor = false;
            this.btnAdd100.Click += new System.EventHandler(this.btnAdd100_Click);
            // 
            // btnMinus10
            // 
            this.btnMinus10.BackColor = System.Drawing.SystemColors.Control;
            this.btnMinus10.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus10.ForeColor = System.Drawing.Color.Black;
            this.btnMinus10.Location = new System.Drawing.Point(98, 344);
            this.btnMinus10.Name = "btnMinus10";
            this.btnMinus10.Size = new System.Drawing.Size(80, 44);
            this.btnMinus10.TabIndex = 5;
            this.btnMinus10.Text = "Bet -10";
            this.btnMinus10.UseVisualStyleBackColor = false;
            this.btnMinus10.Click += new System.EventHandler(this.btnMinus10_Click);
            // 
            // btnMinus100
            // 
            this.btnMinus100.BackColor = System.Drawing.SystemColors.Control;
            this.btnMinus100.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus100.ForeColor = System.Drawing.Color.Black;
            this.btnMinus100.Location = new System.Drawing.Point(98, 394);
            this.btnMinus100.Name = "btnMinus100";
            this.btnMinus100.Size = new System.Drawing.Size(80, 44);
            this.btnMinus100.TabIndex = 6;
            this.btnMinus100.Text = "Bet -100";
            this.btnMinus100.UseVisualStyleBackColor = false;
            this.btnMinus100.Click += new System.EventHandler(this.btnMinus100_Click);
            // 
            // btnMax
            // 
            this.btnMax.BackColor = System.Drawing.SystemColors.Control;
            this.btnMax.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMax.ForeColor = System.Drawing.Color.Black;
            this.btnMax.Location = new System.Drawing.Point(184, 344);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(80, 44);
            this.btnMax.TabIndex = 7;
            this.btnMax.Text = "Bet Max";
            this.btnMax.UseVisualStyleBackColor = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Control;
            this.btnClear.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(184, 394);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 44);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear Bet";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.BackColor = System.Drawing.Color.Transparent;
            this.lblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMoney.Location = new System.Drawing.Point(12, 9);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(162, 29);
            this.lblMoney.TabIndex = 9;
            this.lblMoney.Text = "Money: $1000";
            // 
            // lblBet
            // 
            this.lblBet.AutoSize = true;
            this.lblBet.BackColor = System.Drawing.Color.Transparent;
            this.lblBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBet.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBet.Location = new System.Drawing.Point(12, 312);
            this.lblBet.Name = "lblBet";
            this.lblBet.Size = new System.Drawing.Size(87, 29);
            this.lblBet.TabIndex = 10;
            this.lblBet.Text = "Bet: $0";
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.SystemColors.Control;
            this.btnPlay.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.Black;
            this.btnPlay.Location = new System.Drawing.Point(344, 326);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(127, 67);
            this.btnPlay.TabIndex = 11;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnCashout
            // 
            this.btnCashout.BackColor = System.Drawing.SystemColors.Control;
            this.btnCashout.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashout.ForeColor = System.Drawing.Color.Black;
            this.btnCashout.Location = new System.Drawing.Point(344, 326);
            this.btnCashout.Name = "btnCashout";
            this.btnCashout.Size = new System.Drawing.Size(127, 67);
            this.btnCashout.TabIndex = 12;
            this.btnCashout.Text = "Cashout";
            this.btnCashout.UseVisualStyleBackColor = false;
            this.btnCashout.Click += new System.EventHandler(this.btnCashout_Click);
            // 
            // lblEarned
            // 
            this.lblEarned.AutoSize = true;
            this.lblEarned.BackColor = System.Drawing.Color.Transparent;
            this.lblEarned.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEarned.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEarned.Location = new System.Drawing.Point(12, 38);
            this.lblEarned.Name = "lblEarned";
            this.lblEarned.Size = new System.Drawing.Size(143, 29);
            this.lblEarned.TabIndex = 13;
            this.lblEarned.Text = "This Round:";
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnQuit.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.White;
            this.btnQuit.Location = new System.Drawing.Point(708, 394);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(80, 44);
            this.btnQuit.TabIndex = 15;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblRules1
            // 
            this.lblRules1.AutoSize = true;
            this.lblRules1.BackColor = System.Drawing.Color.Transparent;
            this.lblRules1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRules1.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRules1.Location = new System.Drawing.Point(544, 67);
            this.lblRules1.Name = "lblRules1";
            this.lblRules1.Size = new System.Drawing.Size(198, 16);
            this.lblRules1.TabIndex = 17;
            this.lblRules1.Text = "Select your bet using the buttons";
            // 
            // lblRules2
            // 
            this.lblRules2.AutoSize = true;
            this.lblRules2.BackColor = System.Drawing.Color.Transparent;
            this.lblRules2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRules2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRules2.Location = new System.Drawing.Point(544, 83);
            this.lblRules2.Name = "lblRules2";
            this.lblRules2.Size = new System.Drawing.Size(102, 16);
            this.lblRules2.TabIndex = 18;
            this.lblRules2.Text = "in the bottom left";
            // 
            // lblRules3
            // 
            this.lblRules3.AutoSize = true;
            this.lblRules3.BackColor = System.Drawing.Color.Transparent;
            this.lblRules3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRules3.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRules3.Location = new System.Drawing.Point(544, 99);
            this.lblRules3.Name = "lblRules3";
            this.lblRules3.Size = new System.Drawing.Size(252, 16);
            this.lblRules3.TabIndex = 19;
            this.lblRules3.Text = "Press \"PLAY\" when you are ready to play";
            // 
            // lblRules4
            // 
            this.lblRules4.AutoSize = true;
            this.lblRules4.BackColor = System.Drawing.Color.Transparent;
            this.lblRules4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRules4.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRules4.Location = new System.Drawing.Point(544, 115);
            this.lblRules4.Name = "lblRules4";
            this.lblRules4.Size = new System.Drawing.Size(235, 16);
            this.lblRules4.TabIndex = 20;
            this.lblRules4.Text = "Press \"HIGHER\" or \"LOWER\" to make";
            // 
            // lblRules5
            // 
            this.lblRules5.AutoSize = true;
            this.lblRules5.BackColor = System.Drawing.Color.Transparent;
            this.lblRules5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRules5.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRules5.Location = new System.Drawing.Point(544, 131);
            this.lblRules5.Name = "lblRules5";
            this.lblRules5.Size = new System.Drawing.Size(73, 16);
            this.lblRules5.TabIndex = 21;
            this.lblRules5.Text = "your guess";
            // 
            // lblRules6
            // 
            this.lblRules6.AutoSize = true;
            this.lblRules6.BackColor = System.Drawing.Color.Transparent;
            this.lblRules6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRules6.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRules6.Location = new System.Drawing.Point(544, 147);
            this.lblRules6.Name = "lblRules6";
            this.lblRules6.Size = new System.Drawing.Size(258, 16);
            this.lblRules6.TabIndex = 22;
            this.lblRules6.Text = "Every right answer will add your bet to your";
            // 
            // lblRules7
            // 
            this.lblRules7.AutoSize = true;
            this.lblRules7.BackColor = System.Drawing.Color.Transparent;
            this.lblRules7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRules7.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRules7.Location = new System.Drawing.Point(544, 163);
            this.lblRules7.Name = "lblRules7";
            this.lblRules7.Size = new System.Drawing.Size(94, 16);
            this.lblRules7.TabIndex = 23;
            this.lblRules7.Text = "earned money";
            // 
            // lblRules8
            // 
            this.lblRules8.AutoSize = true;
            this.lblRules8.BackColor = System.Drawing.Color.Transparent;
            this.lblRules8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRules8.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRules8.Location = new System.Drawing.Point(544, 179);
            this.lblRules8.Name = "lblRules8";
            this.lblRules8.Size = new System.Drawing.Size(246, 16);
            this.lblRules8.TabIndex = 24;
            this.lblRules8.Text = "You can cash out whenever you want but";
            // 
            // lblRules9
            // 
            this.lblRules9.AutoSize = true;
            this.lblRules9.BackColor = System.Drawing.Color.Transparent;
            this.lblRules9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRules9.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRules9.Location = new System.Drawing.Point(544, 195);
            this.lblRules9.Name = "lblRules9";
            this.lblRules9.Size = new System.Drawing.Size(258, 16);
            this.lblRules9.TabIndex = 25;
            this.lblRules9.Text = "if you push your luck too much you will lose";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(544, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(171, 16);
            this.label10.TabIndex = 26;
            this.label10.Text = "all of the money you earned";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(614, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 29);
            this.label1.TabIndex = 27;
            this.label1.Text = "Rules";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(544, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Ace is low";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblRules9);
            this.Controls.Add(this.lblRules8);
            this.Controls.Add(this.lblRules7);
            this.Controls.Add(this.lblRules6);
            this.Controls.Add(this.lblRules5);
            this.Controls.Add(this.lblRules4);
            this.Controls.Add(this.lblRules3);
            this.Controls.Add(this.lblRules2);
            this.Controls.Add(this.lblRules1);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.lblEarned);
            this.Controls.Add(this.lblBet);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnMinus100);
            this.Controls.Add(this.btnMinus10);
            this.Controls.Add(this.btnAdd100);
            this.Controls.Add(this.btnAdd10);
            this.Controls.Add(this.btnLower);
            this.Controls.Add(this.btnHigher);
            this.Controls.Add(this.imgCard);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnCashout);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Name = "Form1";
            this.Text = "Higher or Lower";
            ((System.ComponentModel.ISupportInitialize)(this.imgCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgCard;
        private System.Windows.Forms.Button btnHigher;
        private System.Windows.Forms.Button btnLower;
        private System.Windows.Forms.Button btnAdd10;
        private System.Windows.Forms.Button btnAdd100;
        private System.Windows.Forms.Button btnMinus10;
        private System.Windows.Forms.Button btnMinus100;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblBet;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnCashout;
        private System.Windows.Forms.Label lblEarned;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblRules1;
        private System.Windows.Forms.Label lblRules2;
        private System.Windows.Forms.Label lblRules3;
        private System.Windows.Forms.Label lblRules4;
        private System.Windows.Forms.Label lblRules5;
        private System.Windows.Forms.Label lblRules6;
        private System.Windows.Forms.Label lblRules7;
        private System.Windows.Forms.Label lblRules8;
        private System.Windows.Forms.Label lblRules9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

