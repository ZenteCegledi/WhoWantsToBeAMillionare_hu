﻿namespace WhoWantsToBeAMillionare_HUN
{
    partial class Menu
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
            this.startGame = new System.Windows.Forms.Button();
            this.ranklistButton = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startGame
            // 
            this.startGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.startGame.ForeColor = System.Drawing.Color.DarkOrchid;
            this.startGame.Location = new System.Drawing.Point(125, 122);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(232, 85);
            this.startGame.TabIndex = 0;
            this.startGame.Text = "Játék indítása";
            this.startGame.UseVisualStyleBackColor = false;
            this.startGame.Click += new System.EventHandler(this.startGame_Click);
            // 
            // ranklistButton
            // 
            this.ranklistButton.BackColor = System.Drawing.Color.Yellow;
            this.ranklistButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ranklistButton.Location = new System.Drawing.Point(150, 280);
            this.ranklistButton.Name = "ranklistButton";
            this.ranklistButton.Size = new System.Drawing.Size(179, 60);
            this.ranklistButton.TabIndex = 1;
            this.ranklistButton.Text = "Ranglista";
            this.ranklistButton.UseVisualStyleBackColor = false;
            this.ranklistButton.Click += new System.EventHandler(this.ranklistButton_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.close.ForeColor = System.Drawing.Color.Black;
            this.close.Location = new System.Drawing.Point(150, 346);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(179, 60);
            this.close.TabIndex = 1;
            this.close.Text = "Kilépés";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WhoWantsToBeAMillionare_HUN.Properties.Resources.millionare_logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(483, 495);
            this.Controls.Add(this.close);
            this.Controls.Add(this.ranklistButton);
            this.Controls.Add(this.startGame);
            this.Font = new System.Drawing.Font("Copperplate Gothic Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Menu";
            this.Text = "Legyen Ön is Milliomos - Főmenü";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startGame;
        private System.Windows.Forms.Button ranklistButton;
        private System.Windows.Forms.Button close;
    }
}

