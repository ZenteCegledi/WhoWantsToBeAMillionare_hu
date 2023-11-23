namespace WhoWantsToBeAMillionare_HUN
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            this.stopGame = new System.Windows.Forms.Label();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.currentQuestionLabel = new System.Windows.Forms.Label();
            this.newQuestionTimer = new System.Windows.Forms.Timer(this.components);
            this.prizeLabel = new System.Windows.Forms.Label();
            this.leaveWithPrize = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // stopGame
            // 
            this.stopGame.BackColor = System.Drawing.Color.Transparent;
            this.stopGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stopGame.Location = new System.Drawing.Point(770, 611);
            this.stopGame.Name = "stopGame";
            this.stopGame.Size = new System.Drawing.Size(231, 41);
            this.stopGame.TabIndex = 0;
            this.stopGame.Click += new System.EventHandler(this.stopGame_Click);
            // 
            // currentQuestionLabel
            // 
            this.currentQuestionLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentQuestionLabel.Font = new System.Drawing.Font("Russo One", 15F);
            this.currentQuestionLabel.ForeColor = System.Drawing.Color.White;
            this.currentQuestionLabel.Location = new System.Drawing.Point(180, 227);
            this.currentQuestionLabel.Name = "currentQuestionLabel";
            this.currentQuestionLabel.Size = new System.Drawing.Size(192, 33);
            this.currentQuestionLabel.TabIndex = 1;
            this.currentQuestionLabel.Text = "??. kérdés";
            this.currentQuestionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newQuestionTimer
            // 
            this.newQuestionTimer.Interval = 2000;
            this.newQuestionTimer.Tick += new System.EventHandler(this.newQuestionTimer_Tick);
            // 
            // prizeLabel
            // 
            this.prizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.prizeLabel.Font = new System.Drawing.Font("Russo One", 15F);
            this.prizeLabel.ForeColor = System.Drawing.Color.White;
            this.prizeLabel.Location = new System.Drawing.Point(815, 226);
            this.prizeLabel.Name = "prizeLabel";
            this.prizeLabel.Size = new System.Drawing.Size(192, 33);
            this.prizeLabel.TabIndex = 2;
            this.prizeLabel.Text = "???";
            this.prizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leaveWithPrize
            // 
            this.leaveWithPrize.BackColor = System.Drawing.Color.Transparent;
            this.leaveWithPrize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.leaveWithPrize.Location = new System.Drawing.Point(181, 611);
            this.leaveWithPrize.Name = "leaveWithPrize";
            this.leaveWithPrize.Size = new System.Drawing.Size(231, 41);
            this.leaveWithPrize.TabIndex = 3;
            this.leaveWithPrize.Click += new System.EventHandler(this.leaveWithPrize_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WhoWantsToBeAMillionare_HUN.Properties.Resources.millionare_background6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.leaveWithPrize);
            this.Controls.Add(this.prizeLabel);
            this.Controls.Add(this.currentQuestionLabel);
            this.Controls.Add(this.stopGame);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label stopGame;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.Label currentQuestionLabel;
        private System.Windows.Forms.Timer newQuestionTimer;
        private System.Windows.Forms.Label prizeLabel;
        private System.Windows.Forms.Label leaveWithPrize;
    }
}