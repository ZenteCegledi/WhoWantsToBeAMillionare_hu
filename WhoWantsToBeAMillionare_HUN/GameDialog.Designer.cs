namespace WhoWantsToBeAMillionare_HUN
{
    partial class GameDialog
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
            this.title = new System.Windows.Forms.Label();
            this.noButton = new System.Windows.Forms.Button();
            this.yesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(15, 9);
            this.title.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(411, 67);
            this.title.TabIndex = 0;
            this.title.Text = "Kérdés";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // noButton
            // 
            this.noButton.BackColor = System.Drawing.Color.Black;
            this.noButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.noButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.noButton.Location = new System.Drawing.Point(18, 89);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(190, 58);
            this.noButton.TabIndex = 1;
            this.noButton.Text = "Nem";
            this.noButton.UseVisualStyleBackColor = false;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // yesButton
            // 
            this.yesButton.BackColor = System.Drawing.Color.Black;
            this.yesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yesButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.yesButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.yesButton.Location = new System.Drawing.Point(233, 89);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(190, 58);
            this.yesButton.TabIndex = 2;
            this.yesButton.Text = "Igen";
            this.yesButton.UseVisualStyleBackColor = false;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // GameDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WhoWantsToBeAMillionare_HUN.Properties.Resources.dialog_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(441, 165);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.title);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "GameDialog";
            this.Text = "Kérdés";
            this.Load += new System.EventHandler(this.CloseDialog_Load);
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button noButton;
        private System.Windows.Forms.Button yesButton;
    }
}