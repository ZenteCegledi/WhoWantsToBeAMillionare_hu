﻿namespace WhoWantsToBeAMillionare_HUN
{
    partial class Leaderboard
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
            this.leaderboardGridView = new System.Windows.Forms.DataGridView();
            this.helyezes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pont = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.segitsegek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idozito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.leaderboardGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // leaderboardGridView
            // 
            this.leaderboardGridView.AllowUserToAddRows = false;
            this.leaderboardGridView.AllowUserToDeleteRows = false;
            this.leaderboardGridView.AllowUserToResizeColumns = false;
            this.leaderboardGridView.AllowUserToResizeRows = false;
            this.leaderboardGridView.BackgroundColor = System.Drawing.Color.Black;
            this.leaderboardGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.leaderboardGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.helyezes,
            this.nev,
            this.pont,
            this.ido,
            this.segitsegek,
            this.idozito});
            this.leaderboardGridView.Location = new System.Drawing.Point(8, 15);
            this.leaderboardGridView.Margin = new System.Windows.Forms.Padding(6);
            this.leaderboardGridView.MultiSelect = false;
            this.leaderboardGridView.Name = "leaderboardGridView";
            this.leaderboardGridView.ReadOnly = true;
            this.leaderboardGridView.Size = new System.Drawing.Size(769, 457);
            this.leaderboardGridView.TabIndex = 0;
            this.leaderboardGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.leaderboardGridView_CellContentClick);
            this.leaderboardGridView.SelectionChanged += new System.EventHandler(this.leaderboardGridView_SelectionChanged);
            // 
            // helyezes
            // 
            this.helyezes.HeaderText = "Hely";
            this.helyezes.Name = "helyezes";
            this.helyezes.ReadOnly = true;
            // 
            // nev
            // 
            this.nev.HeaderText = "Név";
            this.nev.Name = "nev";
            this.nev.ReadOnly = true;
            // 
            // pont
            // 
            this.pont.HeaderText = "Pontszám";
            this.pont.Name = "pont";
            this.pont.ReadOnly = true;
            // 
            // ido
            // 
            this.ido.HeaderText = "Idő";
            this.ido.Name = "ido";
            this.ido.ReadOnly = true;
            // 
            // segitsegek
            // 
            this.segitsegek.HeaderText = "Felhasznált segítségek";
            this.segitsegek.Name = "segitsegek";
            this.segitsegek.ReadOnly = true;
            // 
            // idozito
            // 
            this.idozito.HeaderText = "Időzítő";
            this.idozito.Name = "idozito";
            this.idozito.ReadOnly = true;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Russo One", 20F);
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(7, 481);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(770, 57);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Bezárás";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Leaderboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(788, 547);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.leaderboardGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Leaderboard";
            this.Text = "Ranglista";
            this.Load += new System.EventHandler(this.Ranglista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.leaderboardGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView leaderboardGridView;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn helyezes;
        private System.Windows.Forms.DataGridViewTextBoxColumn nev;
        private System.Windows.Forms.DataGridViewTextBoxColumn pont;
        private System.Windows.Forms.DataGridViewTextBoxColumn ido;
        private System.Windows.Forms.DataGridViewTextBoxColumn segitsegek;
        private System.Windows.Forms.DataGridViewTextBoxColumn idozito;
    }
}