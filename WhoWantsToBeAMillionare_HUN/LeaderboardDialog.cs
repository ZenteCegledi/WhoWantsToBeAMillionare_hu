using MySql.Data.MySqlClient;
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
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

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

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                const int CS_NOCLOSE = 0x200;
                cp.ClassStyle |= CS_NOCLOSE;
                return cp;
            }
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
            } else
            {
                int insertTime = (time[0] - '0')*600 + (time[1] - '0')*60 + (time[3] - '0') *10 + (time[4] - '0');
                string sql = $"CALL pr_UjPontszam('{nameField.Text}', {point}, {insertTime});";
                Connect.conn.Open();

                MySqlCommand cmd = new MySqlCommand(sql, Connect.conn);

                cmd.ExecuteNonQuery();


                Connect.conn.Close();

                this.Close();
            }
        }
    }
}
