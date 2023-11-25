using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Diagnostics;

namespace WhoWantsToBeAMillionare_HUN
{
    public partial class MainMenu : Form
    {
        private int timerSeconds = 0;
        Random r = new Random();
        public MainMenu()
        {
            InitializeComponent();
            Connect.initDB();
        }

        private SoundPlayer player;

        private void Menu_Load(object sender, EventArgs e)
        {
            
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            player = new SoundPlayer(Properties.Resources.millionare_win);
            player.Play();

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

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void startGame_Click(object sender, EventArgs e)
        {
            player.Stop();

            if (timerSeconds == -1) { 
                List<int> allTime = new List<int> {
                5, 10, 20, 30, 45, 60, 90, 120, 300
                };

                timerSeconds = allTime[r.Next(0, 10)];
            }

            Game game = new Game(timerSeconds);

            game.Show();

            // startGame.Enabled = false;
            
            this.Show();
        }

        private void ranklistButton_Click(object sender, EventArgs e)
        {
            Leaderboard leaderboard = new Leaderboard();

            leaderboard.Show();
        }

        private void timerSecondsTracker_ValueChanged(object sender, EventArgs e)
        {

            switch ((int)timerSecondsTracker.Value)
            {
                case 1:
                    timerSecondsLabel.Text = "KI";
                    timerSecondsLabel.ForeColor = Color.White;
                    timerSeconds = 0;
                    break;

                case 2:
                    timerSecondsLabel.Text = "5 mp";
                    timerSecondsLabel.ForeColor = Color.FromArgb(235, 12, 12);
                    timerSeconds = 5;
                    break;

                case 3:
                    timerSecondsLabel.Text = "10 mp";
                    timerSecondsLabel.ForeColor = Color.FromArgb(235, 71, 12);
                    timerSeconds = 10;
                    break;

                case 4:
                    timerSecondsLabel.Text = "20 mp";
                    timerSecondsLabel.ForeColor = Color.FromArgb(235, 94, 12);
                    timerSeconds = 20;
                    break;

                case 5:
                    timerSecondsLabel.Text = "30 mp";
                    timerSecondsLabel.ForeColor = Color.FromArgb(235, 116, 12);
                    timerSeconds = 30;
                    break;

                case 6:
                    timerSecondsLabel.Text = "45 mp";
                    timerSecondsLabel.ForeColor = Color.FromArgb(235, 142, 12);
                    timerSeconds = 45;
                    break;

                case 7:
                    timerSecondsLabel.Text = "60 mp";
                    timerSecondsLabel.ForeColor = Color.FromArgb(235, 179, 12);
                    timerSeconds = 60;
                    break;

                case 8:
                    timerSecondsLabel.Text = "90 mp";
                    timerSecondsLabel.ForeColor = Color.FromArgb(235, 209, 12);
                    timerSeconds = 90;
                    break;

                case 9:
                    timerSecondsLabel.Text = "2 perc";
                    timerSecondsLabel.ForeColor = Color.FromArgb(224, 235, 12);
                    timerSeconds = 120;
                    break;

                case 10:
                    timerSecondsLabel.Text = "5 perc";
                    timerSecondsLabel.ForeColor = Color.FromArgb(109, 235, 12);
                    timerSeconds = 300;
                    break;

                case 11:
                    timerSecondsLabel.Text = "Véletlen";
                    timerSecondsLabel.ForeColor = Color.FromArgb(11, 222, 166);
                    timerSeconds = -1;
                    break;

            }
        }

        private void description_Click(object sender, EventArgs e)
        {
            Process.Start("https://czh.hu/f/wwbm.pdf");
        }

        private void github_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/ZenteCegledi/WhoWantsToBeAMillionare_HUN/");
        }
    }
}
