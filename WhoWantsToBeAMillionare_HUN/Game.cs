using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace WhoWantsToBeAMillionare_HUN
{
    public partial class Game : Form
    {
        private int currentQuestion = 0;
        private SoundPlayer player;
        // Szabadon változtatható saját nyereményhez!
        private List<string> prizes = new List<string>() {
            "5.000 Ft",
            "10.000 Ft",
            "25.000 Ft",
            "50.000 Ft",
            "100.000 Ft",
            "200.000 Ft",
            "300.000 Ft",
            "500.000 Ft",
            "800.000 Ft",
            "1.500.000 Ft",
            "3.000.000 Ft",
            "5.000.000 Ft",
            "10.000.000 Ft",
            "20.000.000 Ft",
            "40.000.000 Ft"
        };
        public Game()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            player = new SoundPlayer(Properties.Resources.millionare_lets_play);
            player.Play();

            this.Width = 1200;
            this.Height = 700;

            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.BackgroundImage = Properties.Resources.millionare_background6;

            newQuestion();
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

        private void stopGame_Click(object sender, EventArgs e)
        {
            GameDialog closeDialog = new GameDialog("Biztosan kilépsz a játékból?");
            DialogResult result = closeDialog.ShowDialog();
            
            if (result == DialogResult.Yes) { 
                player.Stop();
                this.Close();
            }

        }



        private void newQuestion()
        {
            newQuestionTimer.Start();
        }

        private void newQuestionTimer_Tick(object sender, EventArgs e)
        {
            newQuestionTimer.Stop();
            newQuestionTimer.Interval += 100;
            currentQuestion++;
            currentQuestionLabel.Text = currentQuestion + ". kérdés";
            prizeLabel.Text = prizes[currentQuestion - 1];
            Thread.Sleep(500);
        }

        private void leaveWithPrize_Click(object sender, EventArgs e)
        {
            GameDialog leaveDialog = new GameDialog("Biztosan kiszállsz? \nA nyereményed: 40 000 000 Ft");
            leaveDialog.ShowDialog();
        }


        // Control örököltetés
        /*
        private void Game_Paint(object sender, PaintEventArgs e)
        {
            Graphics l = e.Graphics;
            Pen p = new Pen(Color.BlueViolet, 10);
            Point[] a = { 
                new Point(771, 632),
                new Point(791, 615),
                new Point(983, 615),
                new Point(1002, 632),
                new Point(983, 649),
                new Point(791, 649)
            };
            l.DrawPolygon(p, a);
            l.Dispose();
        }
        */
    }
}
