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
    public partial class CloseDialog : Form
    {
        private string question;
        public CloseDialog(string question)
        {
            this.question = question;
            InitializeComponent();
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
            this.DialogResult |= DialogResult.No;
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            this.DialogResult |= DialogResult.Yes;
        }

        private void CloseDialog_Load(object sender, EventArgs e)
        {
            this.Text = question;
            title.Text = question;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }
    }
}
