namespace WhoWantsToBeAMillionare_HUN
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
            this.nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pont = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.leaderboardGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // leaderboardGridView
            // 
            this.leaderboardGridView.AllowUserToAddRows = false;
            this.leaderboardGridView.AllowUserToDeleteRows = false;
            this.leaderboardGridView.AllowUserToResizeColumns = false;
            this.leaderboardGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.leaderboardGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nev,
            this.pont});
            this.leaderboardGridView.Location = new System.Drawing.Point(149, 129);
            this.leaderboardGridView.Name = "leaderboardGridView";
            this.leaderboardGridView.ReadOnly = true;
            this.leaderboardGridView.Size = new System.Drawing.Size(313, 231);
            this.leaderboardGridView.TabIndex = 0;
            // 
            // nev
            // 
            this.nev.HeaderText = "Név";
            this.nev.Name = "nev";
            this.nev.ReadOnly = true;
            // 
            // pont
            // 
            this.pont.HeaderText = "Pont";
            this.pont.Name = "pont";
            this.pont.ReadOnly = true;
            // 
            // Leaderboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.leaderboardGridView);
            this.Name = "Leaderboard";
            this.Text = "Leaderboard";
            ((System.ComponentModel.ISupportInitialize)(this.leaderboardGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView leaderboardGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nev;
        private System.Windows.Forms.DataGridViewTextBoxColumn pont;
    }
}