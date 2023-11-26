using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
        private int usedHelps;
        private int timerSeconds;
        public LeaderboardDialog(string prize, int point, string time, int usedHelps, int timerSeconds)
        {
            this.prize = prize;
            this.point = point;
            this.time = time;
            this.usedHelps = usedHelps;
            this.timerSeconds = timerSeconds;
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
            usedHelpsLabel.Text = usedHelps.ToString();
            if (timerSeconds == 0) {
                timerLabel.Text = "KI";
            }
            else { 
                timerLabel.Text = timerSeconds.ToString();
            }
            int place = leaderboardPlace();
            if (place == -1)
            {
                standingsLabel.Text = "N/A";
            } else
            {
                standingsLabel.Text = place.ToString();
            }
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
                int insertTime = formatTime(time);
                string sql = $"CALL pr_UjPontszam('{nameField.Text}', {point}, {insertTime}, {timerSeconds}, {usedHelps});";
                Connect.conn.Open();

                MySqlCommand cmd = new MySqlCommand(sql, Connect.conn);

                cmd.ExecuteNonQuery();


                Connect.conn.Close();

                this.Close();
            }
        }

        private int leaderboardPlace()
        {
            List<int> points = new List<int>();
            List<int> helps = new List<int>();
            List<int> times = new List<int>();
            string sql = "SELECT * FROM ranglista ORDER BY pont DESC, segitsegek ASC, ido ASC;";
            Connect.conn.Open();

            MySqlCommand cmd = new MySqlCommand(sql, Connect.conn);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                points.Add((int)reader["pont"]);
                helps.Add((int)reader["segitsegek"]);
                times.Add((int)reader["ido"]);
            }

            int fTime = formatTime(time);

            if (point >= points[0] && usedHelps <= helps[0] && fTime <= times[0])
            {
                Connect.conn.Close();
                return 1;
            }

            for (int i = 1; i < points.Count; i++)
            {
                if (point >= points[i] && usedHelps <= helps[i])
                {
                    if (i == points.Count - 1 || (fTime <= times[i] && (point > points[i + 1] || usedHelps < helps[i + 1] || fTime < times[i + 1])))
                    {
                        Connect.conn.Close();
                        return i + 1;
                    }
                }
            }

            Connect.conn.Close();
            return points.Count + 1;

        }

        public int formatTime(string time)
        {
            return (time[0] - '0') * 600 + (time[1] - '0') * 60 + (time[3] - '0') * 10 + (time[4] - '0');
        }

    }
}
