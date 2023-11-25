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
            this.answerBLabel = new System.Windows.Forms.Label();
            this.answerCLabel = new System.Windows.Forms.Label();
            this.displayNextTimer = new System.Windows.Forms.Timer(this.components);
            this.elapsedTime = new System.Windows.Forms.Label();
            this.answerDLabel = new System.Windows.Forms.Label();
            this.answerALabel = new System.Windows.Forms.Label();
            this.displayCorrectAnswerTimer = new System.Windows.Forms.Timer(this.components);
            this.winTimer = new System.Windows.Forms.Timer(this.components);
            this.endGameTimer = new System.Windows.Forms.Timer(this.components);
            this.crossDiagram = new System.Windows.Forms.PictureBox();
            this.crossIdea = new System.Windows.Forms.PictureBox();
            this.crossFifty = new System.Windows.Forms.PictureBox();
            this.diagramButtonLabel = new System.Windows.Forms.Label();
            this.ideaButtonLabel = new System.Windows.Forms.Label();
            this.fiftyPercentButtonLabel = new System.Windows.Forms.Label();
            this.percentA = new System.Windows.Forms.Label();
            this.percentC = new System.Windows.Forms.Label();
            this.percentD = new System.Windows.Forms.Label();
            this.percentB = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.crossDiagram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossIdea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossFifty)).BeginInit();
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
            // mainTimer
            // 
            this.mainTimer.Enabled = true;
            this.mainTimer.Interval = 1000;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
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
            this.newQuestionTimer.Interval = 3000;
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
            this.leaveWithPrize.Cursor = System.Windows.Forms.Cursors.No;
            this.leaveWithPrize.Location = new System.Drawing.Point(181, 611);
            this.leaveWithPrize.Name = "leaveWithPrize";
            this.leaveWithPrize.Size = new System.Drawing.Size(231, 41);
            this.leaveWithPrize.TabIndex = 3;
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
            // answerBLabel
            // 
            this.answerBLabel.BackColor = System.Drawing.Color.Transparent;
            this.answerBLabel.Cursor = System.Windows.Forms.Cursors.No;
            this.answerBLabel.Font = new System.Drawing.Font("Russo One", 20F);
            this.answerBLabel.ForeColor = System.Drawing.Color.White;
            this.answerBLabel.Location = new System.Drawing.Point(612, 404);
            this.answerBLabel.Name = "answerBLabel";
            this.answerBLabel.Padding = new System.Windows.Forms.Padding(65, 0, 30, 0);
            this.answerBLabel.Size = new System.Drawing.Size(435, 88);
            this.answerBLabel.TabIndex = 6;
            this.answerBLabel.Text = "???";
            this.answerBLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answerCLabel
            // 
            this.answerCLabel.BackColor = System.Drawing.Color.Transparent;
            this.answerCLabel.Cursor = System.Windows.Forms.Cursors.No;
            this.answerCLabel.Font = new System.Drawing.Font("Russo One", 20F);
            this.answerCLabel.ForeColor = System.Drawing.Color.White;
            this.answerCLabel.Location = new System.Drawing.Point(140, 512);
            this.answerCLabel.Name = "answerCLabel";
            this.answerCLabel.Padding = new System.Windows.Forms.Padding(65, 0, 30, 0);
            this.answerCLabel.Size = new System.Drawing.Size(441, 88);
            this.answerCLabel.TabIndex = 7;
            this.answerCLabel.Text = "???";
            this.answerCLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayNextTimer
            // 
            this.displayNextTimer.Interval = 750;
            this.displayNextTimer.Tick += new System.EventHandler(this.displayNextTimer_Tick);
            // 
            // elapsedTime
            // 
            this.elapsedTime.BackColor = System.Drawing.Color.Transparent;
            this.elapsedTime.Font = new System.Drawing.Font("Russo One", 15F);
            this.elapsedTime.ForeColor = System.Drawing.Color.White;
            this.elapsedTime.Location = new System.Drawing.Point(148, 24);
            this.elapsedTime.Name = "elapsedTime";
            this.elapsedTime.Size = new System.Drawing.Size(73, 42);
            this.elapsedTime.TabIndex = 9;
            this.elapsedTime.Text = "00:00";
            this.elapsedTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answerDLabel
            // 
            this.answerDLabel.BackColor = System.Drawing.Color.Transparent;
            this.answerDLabel.Cursor = System.Windows.Forms.Cursors.No;
            this.answerDLabel.Font = new System.Drawing.Font("Russo One", 20F);
            this.answerDLabel.ForeColor = System.Drawing.Color.White;
            this.answerDLabel.Location = new System.Drawing.Point(618, 512);
            this.answerDLabel.Name = "answerDLabel";
            this.answerDLabel.Padding = new System.Windows.Forms.Padding(65, 0, 30, 0);
            this.answerDLabel.Size = new System.Drawing.Size(429, 88);
            this.answerDLabel.TabIndex = 10;
            this.answerDLabel.Text = "???";
            this.answerDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answerALabel
            // 
            this.answerALabel.BackColor = System.Drawing.Color.Transparent;
            this.answerALabel.Cursor = System.Windows.Forms.Cursors.No;
            this.answerALabel.Font = new System.Drawing.Font("Russo One", 20F);
            this.answerALabel.ForeColor = System.Drawing.Color.White;
            this.answerALabel.Location = new System.Drawing.Point(140, 404);
            this.answerALabel.Name = "answerALabel";
            this.answerALabel.Padding = new System.Windows.Forms.Padding(65, 0, 30, 0);
            this.answerALabel.Size = new System.Drawing.Size(441, 88);
            this.answerALabel.TabIndex = 11;
            this.answerALabel.Text = "???";
            this.answerALabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayCorrectAnswerTimer
            // 
            this.displayCorrectAnswerTimer.Interval = 2500;
            this.displayCorrectAnswerTimer.Tick += new System.EventHandler(this.displayCorrectAnswerTimer_Tick);
            // 
            // winTimer
            // 
            this.winTimer.Interval = 237;
            this.winTimer.Tick += new System.EventHandler(this.winTimer_Tick);
            // 
            // endGameTimer
            // 
            this.endGameTimer.Interval = 3500;
            this.endGameTimer.Tick += new System.EventHandler(this.endGameTimer_Tick);
            // 
            // crossDiagram
            // 
            this.crossDiagram.BackColor = System.Drawing.Color.Transparent;
            this.crossDiagram.Cursor = System.Windows.Forms.Cursors.No;
            this.crossDiagram.Image = global::WhoWantsToBeAMillionare_HUN.Properties.Resources.multiply;
            this.crossDiagram.InitialImage = null;
            this.crossDiagram.Location = new System.Drawing.Point(843, 21);
            this.crossDiagram.Name = "crossDiagram";
            this.crossDiagram.Size = new System.Drawing.Size(72, 71);
            this.crossDiagram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.crossDiagram.TabIndex = 13;
            this.crossDiagram.TabStop = false;
            this.crossDiagram.Visible = false;
            // 
            // crossIdea
            // 
            this.crossIdea.BackColor = System.Drawing.Color.Transparent;
            this.crossIdea.Cursor = System.Windows.Forms.Cursors.No;
            this.crossIdea.Image = global::WhoWantsToBeAMillionare_HUN.Properties.Resources.multiply;
            this.crossIdea.InitialImage = null;
            this.crossIdea.Location = new System.Drawing.Point(964, 21);
            this.crossIdea.Name = "crossIdea";
            this.crossIdea.Size = new System.Drawing.Size(72, 71);
            this.crossIdea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.crossIdea.TabIndex = 14;
            this.crossIdea.TabStop = false;
            this.crossIdea.Visible = false;
            // 
            // crossFifty
            // 
            this.crossFifty.BackColor = System.Drawing.Color.Transparent;
            this.crossFifty.Cursor = System.Windows.Forms.Cursors.No;
            this.crossFifty.Image = global::WhoWantsToBeAMillionare_HUN.Properties.Resources.multiply;
            this.crossFifty.InitialImage = null;
            this.crossFifty.Location = new System.Drawing.Point(1084, 20);
            this.crossFifty.Name = "crossFifty";
            this.crossFifty.Size = new System.Drawing.Size(72, 71);
            this.crossFifty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.crossFifty.TabIndex = 15;
            this.crossFifty.TabStop = false;
            this.crossFifty.Visible = false;
            // 
            // diagramButtonLabel
            // 
            this.diagramButtonLabel.BackColor = System.Drawing.Color.Transparent;
            this.diagramButtonLabel.Cursor = System.Windows.Forms.Cursors.No;
            this.diagramButtonLabel.Location = new System.Drawing.Point(843, 20);
            this.diagramButtonLabel.Name = "diagramButtonLabel";
            this.diagramButtonLabel.Size = new System.Drawing.Size(72, 70);
            this.diagramButtonLabel.TabIndex = 16;
            // 
            // ideaButtonLabel
            // 
            this.ideaButtonLabel.BackColor = System.Drawing.Color.Transparent;
            this.ideaButtonLabel.Cursor = System.Windows.Forms.Cursors.No;
            this.ideaButtonLabel.Location = new System.Drawing.Point(964, 20);
            this.ideaButtonLabel.Name = "ideaButtonLabel";
            this.ideaButtonLabel.Size = new System.Drawing.Size(72, 70);
            this.ideaButtonLabel.TabIndex = 17;
            // 
            // fiftyPercentButtonLabel
            // 
            this.fiftyPercentButtonLabel.BackColor = System.Drawing.Color.Transparent;
            this.fiftyPercentButtonLabel.Cursor = System.Windows.Forms.Cursors.No;
            this.fiftyPercentButtonLabel.Location = new System.Drawing.Point(1084, 21);
            this.fiftyPercentButtonLabel.Name = "fiftyPercentButtonLabel";
            this.fiftyPercentButtonLabel.Size = new System.Drawing.Size(72, 70);
            this.fiftyPercentButtonLabel.TabIndex = 18;
            // 
            // percentA
            // 
            this.percentA.BackColor = System.Drawing.Color.Transparent;
            this.percentA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.percentA.Font = new System.Drawing.Font("Russo One", 20F);
            this.percentA.ForeColor = System.Drawing.Color.Aqua;
            this.percentA.Location = new System.Drawing.Point(493, 404);
            this.percentA.Name = "percentA";
            this.percentA.Size = new System.Drawing.Size(74, 88);
            this.percentA.TabIndex = 19;
            this.percentA.Text = "??%";
            this.percentA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.percentA.Visible = false;
            // 
            // percentC
            // 
            this.percentC.BackColor = System.Drawing.Color.Transparent;
            this.percentC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.percentC.Font = new System.Drawing.Font("Russo One", 20F);
            this.percentC.ForeColor = System.Drawing.Color.Aqua;
            this.percentC.Location = new System.Drawing.Point(493, 512);
            this.percentC.Name = "percentC";
            this.percentC.Size = new System.Drawing.Size(74, 88);
            this.percentC.TabIndex = 20;
            this.percentC.Text = "??%";
            this.percentC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.percentC.Visible = false;
            // 
            // percentD
            // 
            this.percentD.BackColor = System.Drawing.Color.Transparent;
            this.percentD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.percentD.Font = new System.Drawing.Font("Russo One", 20F);
            this.percentD.ForeColor = System.Drawing.Color.Aqua;
            this.percentD.Location = new System.Drawing.Point(962, 512);
            this.percentD.Name = "percentD";
            this.percentD.Size = new System.Drawing.Size(74, 88);
            this.percentD.TabIndex = 22;
            this.percentD.Text = "??%";
            this.percentD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.percentD.Visible = false;
            // 
            // percentB
            // 
            this.percentB.BackColor = System.Drawing.Color.Transparent;
            this.percentB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.percentB.Font = new System.Drawing.Font("Russo One", 20F);
            this.percentB.ForeColor = System.Drawing.Color.Aqua;
            this.percentB.Location = new System.Drawing.Point(962, 404);
            this.percentB.Name = "percentB";
            this.percentB.Size = new System.Drawing.Size(74, 88);
            this.percentB.TabIndex = 21;
            this.percentB.Text = "??%";
            this.percentB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.percentB.Visible = false;
            // 
            // timerLabel
            // 
            this.timerLabel.BackColor = System.Drawing.Color.Transparent;
            this.timerLabel.Font = new System.Drawing.Font("Russo One", 15F);
            this.timerLabel.ForeColor = System.Drawing.Color.White;
            this.timerLabel.Location = new System.Drawing.Point(143, 96);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(62, 42);
            this.timerLabel.TabIndex = 23;
            this.timerLabel.Text = "30";
            this.timerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.percentD);
            this.Controls.Add(this.percentB);
            this.Controls.Add(this.percentC);
            this.Controls.Add(this.percentA);
            this.Controls.Add(this.fiftyPercentButtonLabel);
            this.Controls.Add(this.ideaButtonLabel);
            this.Controls.Add(this.diagramButtonLabel);
            this.Controls.Add(this.crossFifty);
            this.Controls.Add(this.crossIdea);
            this.Controls.Add(this.crossDiagram);
            this.Controls.Add(this.answerALabel);
            this.Controls.Add(this.answerDLabel);
            this.Controls.Add(this.elapsedTime);
            this.Controls.Add(this.answerCLabel);
            this.Controls.Add(this.answerBLabel);
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
            ((System.ComponentModel.ISupportInitialize)(this.crossDiagram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossIdea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossFifty)).EndInit();
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
        private System.Windows.Forms.Label answerBLabel;
        private System.Windows.Forms.Label answerCLabel;
        private System.Windows.Forms.Timer displayNextTimer;
        private System.Windows.Forms.Label elapsedTime;
        private System.Windows.Forms.Label answerDLabel;
        private System.Windows.Forms.Label answerALabel;
        private System.Windows.Forms.Timer displayCorrectAnswerTimer;
        private System.Windows.Forms.Timer winTimer;
        private System.Windows.Forms.Timer endGameTimer;
        private System.Windows.Forms.PictureBox crossDiagram;
        private System.Windows.Forms.PictureBox crossIdea;
        private System.Windows.Forms.PictureBox crossFifty;
        private System.Windows.Forms.Label diagramButtonLabel;
        private System.Windows.Forms.Label ideaButtonLabel;
        private System.Windows.Forms.Label fiftyPercentButtonLabel;
        private System.Windows.Forms.Label percentA;
        private System.Windows.Forms.Label percentC;
        private System.Windows.Forms.Label percentD;
        private System.Windows.Forms.Label percentB;
        private System.Windows.Forms.Label timerLabel;
    }
}