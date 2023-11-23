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

namespace WhoWantsToBeAMillionare_HUN
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private SoundPlayer player;

        private void Menu_Load(object sender, EventArgs e)
        {
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            player = new SoundPlayer(Properties.Resources.millionare_main_theme);

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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void startGame_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void ranklistButton_Click(object sender, EventArgs e)
        {
            Leaderboard leaderboard = new Leaderboard();

            leaderboard.Show();
        }
    }
}
