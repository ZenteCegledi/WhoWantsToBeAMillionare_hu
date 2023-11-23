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
            this.questionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            // questionLabel
            // 
            this.questionLabel.BackColor = System.Drawing.Color.Transparent;
            this.questionLabel.Font = new System.Drawing.Font("Russo One", 24F);
            this.questionLabel.ForeColor = System.Drawing.Color.White;
            this.questionLabel.Location = new System.Drawing.Point(185, 276);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(822, 112);
            this.questionLabel.TabIndex = 4;
            this.questionLabel.Text = "???";
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Russo One", 20F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(215, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 88);
            this.label1.TabIndex = 5;
            this.label1.Text = "???";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Russo One", 20F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(685, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 88);
            this.label2.TabIndex = 6;
            this.label2.Text = "???";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Russo One", 20F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(685, 512);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(327, 88);
            this.label3.TabIndex = 8;
            this.label3.Text = "???";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Russo One", 20F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(215, 512);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(327, 88);
            this.label4.TabIndex = 7;
            this.label4.Text = "???";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WhoWantsToBeAMillionare_HUN.Properties.Resources.millionare_background6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.leaveWithPrize);
            this.Controls.Add(this.prizeLabel);
            this.Controls.Add(this.currentQuestionLabel);
            this.Controls.Add(this.stopGame);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Legyen Ön is Milliomos";
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
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}