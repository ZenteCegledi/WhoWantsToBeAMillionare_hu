namespace WhoWantsToBeAMillionare_HUN
{
    partial class MainMenu
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
            this.close = new System.Windows.Forms.Button();
            this.timerSecondsTracker = new System.Windows.Forms.TrackBar();
            this.ranklistButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timerLabel = new System.Windows.Forms.Label();
            this.timerSecondsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.timerSecondsTracker)).BeginInit();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Russo One", 20F);
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(12, 423);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(446, 60);
            this.close.TabIndex = 1;
            this.close.Text = "Kilépés";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // timerSecondsTracker
            // 
            this.timerSecondsTracker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.timerSecondsTracker.LargeChange = 1;
            this.timerSecondsTracker.Location = new System.Drawing.Point(12, 186);
            this.timerSecondsTracker.Minimum = 1;
            this.timerSecondsTracker.Name = "timerSecondsTracker";
            this.timerSecondsTracker.Size = new System.Drawing.Size(446, 45);
            this.timerSecondsTracker.TabIndex = 2;
            this.timerSecondsTracker.Value = 1;
            this.timerSecondsTracker.ValueChanged += new System.EventHandler(this.timerSecondsTracker_ValueChanged);
            // 
            // ranklistButton
            // 
            this.ranklistButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(0)))));
            this.ranklistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ranklistButton.Font = new System.Drawing.Font("Russo One", 20F);
            this.ranklistButton.ForeColor = System.Drawing.Color.White;
            this.ranklistButton.Location = new System.Drawing.Point(12, 346);
            this.ranklistButton.Name = "ranklistButton";
            this.ranklistButton.Size = new System.Drawing.Size(446, 60);
            this.ranklistButton.TabIndex = 3;
            this.ranklistButton.Text = "Ranglista";
            this.ranklistButton.UseVisualStyleBackColor = false;
            this.ranklistButton.Click += new System.EventHandler(this.ranklistButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Russo One", 20F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(446, 60);
            this.button1.TabIndex = 4;
            this.button1.Text = "Játék indítása";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.startGame_Click);
            // 
            // timerLabel
            // 
            this.timerLabel.AllowDrop = true;
            this.timerLabel.BackColor = System.Drawing.Color.Transparent;
            this.timerLabel.Font = new System.Drawing.Font("Russo One", 24F);
            this.timerLabel.ForeColor = System.Drawing.Color.White;
            this.timerLabel.Location = new System.Drawing.Point(12, 112);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(228, 52);
            this.timerLabel.TabIndex = 5;
            this.timerLabel.Text = "Időzítő:";
            this.timerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timerSecondsLabel
            // 
            this.timerSecondsLabel.AllowDrop = true;
            this.timerSecondsLabel.BackColor = System.Drawing.Color.Transparent;
            this.timerSecondsLabel.Font = new System.Drawing.Font("Russo One", 24F);
            this.timerSecondsLabel.ForeColor = System.Drawing.Color.White;
            this.timerSecondsLabel.Location = new System.Drawing.Point(230, 112);
            this.timerSecondsLabel.Name = "timerSecondsLabel";
            this.timerSecondsLabel.Size = new System.Drawing.Size(228, 52);
            this.timerSecondsLabel.TabIndex = 6;
            this.timerSecondsLabel.Text = "KI";
            this.timerSecondsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WhoWantsToBeAMillionare_HUN.Properties.Resources.millionare_menu_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(483, 495);
            this.Controls.Add(this.timerSecondsLabel);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ranklistButton);
            this.Controls.Add(this.timerSecondsTracker);
            this.Controls.Add(this.close);
            this.Font = new System.Drawing.Font("Copperplate Gothic Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainMenu";
            this.Text = "Legyen Ön is Milliomos - Főmenü";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.timerSecondsTracker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.TrackBar timerSecondsTracker;
        private System.Windows.Forms.Button ranklistButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Label timerSecondsLabel;
    }
}

