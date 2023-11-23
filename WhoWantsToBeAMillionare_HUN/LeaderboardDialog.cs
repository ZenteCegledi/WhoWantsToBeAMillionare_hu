using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhoWantsToBeAMillionare_HUN
{
    public partial class LeaderboardDialog : Form
    {
        private string prize;
        private int point;
        private string time;
        public LeaderboardDialog(string prize, int point, string time)
        {
            this.prize = prize;
            this.point = point;
            this.time = time;
            InitializeComponent();
        }

        private void LeaderboardDialog_Load(object sender, EventArgs e)
        {
            if (point == 15)
            {
                nameField.ForeColor = Color.Goldenrod;
                title.ForeColor = Color.Goldenrod;
                title.Text = "🏆 Feliratkozás a ranglistára! 🏆";
            }

            pointsNumberLabel.Text = $"{point}/15";
            prizeLabel.Text = prize;
            timeLabel.Text = time;
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            if (nameField.Text == "")
            {
                nameDescription.ForeColor = Color.Red;
            }
        }
    }
}
