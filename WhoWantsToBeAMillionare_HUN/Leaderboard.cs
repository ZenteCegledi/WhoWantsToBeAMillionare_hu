using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WhoWantsToBeAMillionare_HUN
{
    public partial class Leaderboard : Form
    {
        public Leaderboard()
        {
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

        private void closeButton_Click(object sender, EventArgs e)
        {  
            this.Close();
        }

        private void Ranglista_Load(object sender, EventArgs e)
        {
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            InsertDataToLeaderboard();

            DesignLeaderboard();
        }

        private void InsertDataToLeaderboard()
        {
            string sql = "SELECT * FROM ranglista ORDER BY pont DESC, segitsegek ASC, ido ASC;";
            Connect.conn.Open();

            MySqlCommand cmd = new MySqlCommand(sql, Connect.conn);

            MySqlDataReader reader = cmd.ExecuteReader();
            leaderboardGridView.Rows.Clear();
            int place = 0;
            while (reader.Read())
            {
                place++;
                int time = (int)reader["ido"];
                string formattedTime = $"{time / 60:D2}:{time % 60:D2}";
                string formattedTimer = reader["idozito"].ToString();
                if (formattedTimer == "0")
                {
                    formattedTimer = "KI";
                } else
                {
                    formattedTimer += " mp";
                }

                leaderboardGridView.Rows.Add(new object[]
                {
                    place.ToString() + ".",
                    reader["nev"].ToString(),
                    reader["pont"].ToString(),
                    formattedTime,
                    reader["segitsegek"].ToString(),
                    formattedTimer,
                });
            }

            Connect.conn.Close();
        }

        private void DesignLeaderboard()
        {

            leaderboardGridView.RowHeadersVisible = false;

            if (leaderboardGridView.Rows.Count >= 3)
            {
                leaderboardGridView.Rows[0].DefaultCellStyle.BackColor = Color.Gold;

                leaderboardGridView.Rows[1].DefaultCellStyle.BackColor = Color.Silver;

                leaderboardGridView.Rows[2].DefaultCellStyle.BackColor = Color.FromArgb(205, 127, 50);
            }
            leaderboardGridView.Columns[0].Width = 60;
            leaderboardGridView.Columns[1].Width = 200;
            leaderboardGridView.Columns[2].Width = 114;
            leaderboardGridView.Columns[3].Width = 125;
            leaderboardGridView.Columns[4].Width = 125;
            leaderboardGridView.Columns[5].Width = 120;


            leaderboardGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            leaderboardGridView.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            leaderboardGridView.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            leaderboardGridView.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            leaderboardGridView.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            leaderboardGridView.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;



            for (int i = 0; i < leaderboardGridView.Rows.Count; i++)
            {
                leaderboardGridView.Rows[i].Height = 50;
            }
        }

        private void leaderboardGridView_SelectionChanged(object sender, EventArgs e)
        {
            leaderboardGridView.ClearSelection();
        }

        private void leaderboardGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
