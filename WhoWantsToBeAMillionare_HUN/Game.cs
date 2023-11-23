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

namespace WhoWantsToBeAMillionare_HUN
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        private SoundPlayer player;

        private void Game_Load(object sender, EventArgs e)
        {
            player = new SoundPlayer(Properties.Resources.millionare_lets_play);
            player.Play();

            this.Width = 1200;
            this.Height = 700;

            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.BackgroundImage = Properties.Resources.millionare_background4;

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
            CloseDialog closeDialog = new CloseDialog("Biztosan kilépsz a játékból?");
            DialogResult result = closeDialog.ShowDialog();
            
            if (result == DialogResult.Yes) { 
                player.Stop();
                this.Close();
            }

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
