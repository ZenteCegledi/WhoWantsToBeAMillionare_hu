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
            label1.Text = prize + " " + point + " " + time;
        }
    }
}
