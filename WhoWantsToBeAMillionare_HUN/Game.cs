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
using System.Linq.Expressions;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using System.Runtime.CompilerServices;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;
using Org.BouncyCastle.Crmf;
using Org.BouncyCastle.Asn1.Ocsp;

namespace WhoWantsToBeAMillionare_HUN
{
    public partial class Game : Form
    {
        int usedHelps = 0;
        bool endAssigned = false;
        int timerSeconds = 0;
        bool timerActive = false;
        bool leave = false;
        private int currentQuestionNumber = 0; // !!!
        Stopwatch winStopper = new Stopwatch();
        Stopwatch gameTimer = new Stopwatch();
        bool currentUseDiagram = false;
        private Random r = new Random();
        private Question currentQuestion = new Question(
            "Valószínűleg nem kapcsolódik a játék a MySQL szerverhez! Ellenőrizd a következőket:", "Be van-e kapcsolva a XAMPP?", "Létre vannak-e hozva az adatbázisok és a táblák?", "Megfelelő jogosultsága van-e a játéknak?", "Ezek közül egyik sem!", 'A');
        Label response;
        private SoundPlayer player;
        private int counter = 0;
        private Stopwatch gameTime = new Stopwatch();
        // Szabadon változtatható saját nyereményhez!
        private List<string> prizes = new List<string>() {
            "0 Ft",
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
        public Game(int timerSeconds)
        {
            this.timerSeconds = timerSeconds;
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

            timerConfigurate();

            gameTime.Start();
            newQuestion();
        }

        private void timerConfigurate()
        {
            if (timerSeconds > 0)
            {
                this.BackgroundImage = Properties.Resources.millionare_background10;
                timerLabel.Text = timerSeconds.ToString();
            } else
            {
                this.BackgroundImage = Properties.Resources.millionare_background9;
                timerLabel.Visible = false;
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
            setNewQuestion();
        }

        private void newQuestionTimer_Tick(object sender, EventArgs e)
        {
            newQuestionTimer.Stop();
            displayNextTimer.Start();
            newQuestionTimer.Interval += 100;
            currentQuestionNumber++;
            currentQuestionLabel.Text = currentQuestionNumber + ". kérdés";
            prizeLabel.Text = prizes[currentQuestionNumber];


        }


        private void displayNextTimer_Tick(object sender, EventArgs e)
        {
            switch (counter)
            {
                case 0:
                    questionLabel.Text = currentQuestion.title;
                    if (currentQuestionNumber <= 5) {
                        player = new SoundPlayer(Properties.Resources.millionare_bgmusic_1_5);
                    } else if (currentQuestionNumber <= 10)
                    {
                        player = new SoundPlayer(Properties.Resources.millionare_bgmusic_6_10);
                    }
                    else if (currentQuestionNumber <= 11)
                    {
                        player = new SoundPlayer(Properties.Resources.millionare_bgmusic_11);
                    }
                    else if (currentQuestionNumber <= 13)
                    {
                        player = new SoundPlayer(Properties.Resources.millionare_bgmusic_12_13);
                    }
                    else if (currentQuestionNumber <= 14)
                    {
                        player = new SoundPlayer(Properties.Resources.millionare_bgmusic_14);
                    }
                    else if (currentQuestionNumber <= 15)
                    {
                        player = new SoundPlayer(Properties.Resources.millionare_bgmusic_15);
                    }
                    player.PlayLooping();
                    break;
                case 1:
                    answerALabel.Text = currentQuestion.a;
                    answerALabel.ForeColor = Color.White;
                    break;
                case 2:
                    answerBLabel.Text = currentQuestion.b;
                    answerBLabel.ForeColor = Color.White;
                    break;
                case 3:
                    answerCLabel.Text = currentQuestion.c;
                    answerCLabel.ForeColor = Color.White;
                    break;
                case 4:
                    answerDLabel.Text = currentQuestion.d;
                    answerDLabel.ForeColor = Color.White;
                    timerLabel.Text = timerSeconds.ToString();
                    enableAnswers();
                    break;
                default:
                    counter = -1;
                    displayNextTimer.Stop();
                    break;
            }
            counter++;
        }

        private void leaveWithPrize_Click(object sender, EventArgs e)
        {
            GameDialog leaveDialog = new GameDialog("Biztosan kiszállsz? \nNyereményed: " + prizes[currentQuestionNumber - 1]);
            DialogResult response = leaveDialog.ShowDialog();
            if (response == DialogResult.Yes)
            {
                player = new SoundPlayer(Properties.Resources.millionare_win);
                player.Play();
                gameTime.Stop();
                endGameTimer.Interval += 2000;
                endGameTimer.Start();
                leave = true;

                questionLabel.Text = "Kiszálltál!\nNyereményed: " + prizes[currentQuestionNumber - 1];
                questionLabel.ForeColor = Color.Gold;
                colorCorrectAnswer();

                disableAnswers();
            }
        }

        private void setNewQuestion()
        {
            string sql = $"CALL pr_UjKerdes({currentQuestionNumber + 1});";
            Connect.conn.Open();

            MySqlCommand cmd = new MySqlCommand(sql, Connect.conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                currentQuestion.title = reader["kerdes"].ToString();
                currentQuestion.a = reader["A"].ToString();
                currentQuestion.b = reader["B"].ToString();
                currentQuestion.c = reader["C"].ToString();
                currentQuestion.d = reader["D"].ToString();
                currentQuestion.correct = reader["helyes"].ToString().ToCharArray()[0];
            }

            Connect.conn.Close();
            // questionLabel.Text = currentQuestion.correct.ToString(); // !!!
        }

        private void answerLabelClick(object sender, EventArgs e)
        {
            /* if (currentQuestionNumber > 12)
            {
                GameDialog areYouSureDialog = new GameDialog("Biztos vagy benne?");
                DialogResult sure = areYouSureDialog.ShowDialog();
                if (sure == DialogResult.No)
                {
                    return;
                }
            }
            */
            response = sender as Label;
            disableAnswers();
            player.Stop();
            player = new SoundPlayer(Properties.Resources.millionare_last_answer_sound);
            player.Play();

            answerALabel.ForeColor = Color.DarkGray;
            answerBLabel.ForeColor = Color.DarkGray;
            answerCLabel.ForeColor = Color.DarkGray;
            answerDLabel.ForeColor = Color.DarkGray;

            response.ForeColor = Color.Gold;
            displayCorrectAnswerTimer.Start();
        }

        private void displayCorrectAnswerTimer_Tick(object sender, EventArgs e)
        {
            displayCorrectAnswerTimer.Stop();
            displayCorrectAnswerTimer.Interval += 100;
            if (currentQuestion.correct == response.Name[6])
            {
                if (currentQuestionNumber == 15)
                {
                    winGame();
                } else {
                    response.ForeColor = Color.LimeGreen;
                    player = new SoundPlayer(Properties.Resources.millionare_correct_answer);
                    player.Play();
                    newQuestion();
                }
            } else
            {
                response.ForeColor = Color.Red;
                player = new SoundPlayer(Properties.Resources.millionare_wrong_answer);
                player.Play();
                elapsedTime.ForeColor = Color.Silver;
                gameTime.Stop();
                colorCorrectAnswer();
                endGameTimer.Start();
            }

        }

        private void winGame()
        {
            winStopper.Start();
            response.ForeColor = Color.LimeGreen;
            questionLabel.ForeColor = Color.LimeGreen;
            questionLabel.Text = prizes[15];
            answerALabel.Text = prizes[15];
            answerBLabel.Text = prizes[15];
            answerCLabel.Text = prizes[15];
            answerDLabel.Text = prizes[15];
            currentQuestionLabel.Text = "GRATULÁLUNK!";
            prizeLabel.Text = "NYERTÉL!";
            gameTime.Stop();
            winTimer.Start();
            player = new SoundPlayer(Properties.Resources.millionare_end_win);
            player.Play();
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            elapsedTime.Text = String.Format("{0:00}:{1:00}", gameTime.Elapsed.Minutes, gameTime.Elapsed.Seconds);
            if (timerActive)
            {
                int currentTimeLeft = Convert.ToInt32(timerLabel.Text);
                timerLabel.Text = (currentTimeLeft-1).ToString();
                
                if (currentTimeLeft-1 == timerSeconds/2)
                {
                    timerLabel.ForeColor = Color.Yellow;
                }

                if (currentTimeLeft - 1 == timerSeconds / 4)
                {
                    timerLabel.ForeColor = Color.Orange;
                }

                if (currentTimeLeft - 1 == timerSeconds / 8)
                {
                    timerLabel.ForeColor = Color.OrangeRed;
                    timerLabel.Font = new Font(timerLabel.Font.FontFamily, 20);
                }

                if (timerLabel.Text == "0")
                {
                    disableAnswers();
                    timerLabel.ForeColor = Color.Red;
                    questionLabel.Text = "Lejárt az idő!";
                    questionLabel.ForeColor = Color.Orange;
                    timerLabel.Font = new Font(timerLabel.Font.FontFamily, 24);
                    timerActive = false;
                    player = new SoundPlayer(Properties.Resources.millionare_wrong_answer);
                    player.Play();
                    elapsedTime.ForeColor = Color.Silver;
                    gameTime.Stop();
                    colorCorrectAnswer();
                    endGameTimer.Start();
                }
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

        private class Question
        {
            public string title;
            public string a;
            public string b;
            public string c;
            public string d;
            public char correct;

            public Question(string title, string a, string b, string c, string d, char correct)
            {
                this.title = title;
                this.a = a;
                this.b = b;
                this.c = c;
                this.d = d;
                this.correct = correct;
            }
        }
        private void enableAnswers()
        {
            this.answerALabel.Click += new EventHandler(answerLabelClick);
            this.answerBLabel.Click += new EventHandler(answerLabelClick);
            this.answerCLabel.Click += new EventHandler(answerLabelClick);
            this.answerDLabel.Click += new EventHandler(answerLabelClick);

            this.answerALabel.Cursor = Cursors.Hand;
            this.answerBLabel.Cursor = Cursors.Hand;
            this.answerCLabel.Cursor = Cursors.Hand;
            this.answerDLabel.Cursor = Cursors.Hand;

            percentA.Cursor = Cursors.Hand;
            percentB.Cursor = Cursors.Hand;
            percentC.Cursor = Cursors.Hand;
            percentD.Cursor = Cursors.Hand;

            diagramButtonLabel.Click += new EventHandler(useDiagramHelp);
            ideaButtonLabel.Click += new EventHandler(useIdeaHelp);
            fiftyPercentButtonLabel.Click += new EventHandler(useFiftyPercentHelp);

            this.diagramButtonLabel.Cursor = Cursors.Hand;
            this.ideaButtonLabel.Cursor = Cursors.Hand;
            this.fiftyPercentButtonLabel.Cursor = Cursors.Hand;

            leaveWithPrize.Click += leaveWithPrize_Click;
            leaveWithPrize.Cursor = Cursors.Hand;

            if (currentUseDiagram)
            {
                currentUseDiagram = !currentUseDiagram;
                percentA.Visible = false;
                percentB.Visible = false;
                percentC.Visible = false;
                percentD.Visible = false;
            }

            if (timerSeconds > 0)
            {
                timerActive = true;
                timerLabel.ForeColor = Color.White;
                timerLabel.Font = new Font(timerLabel.Font.FontFamily, 18);
            }
        }
        private void disableAnswers()
        {
            this.answerALabel.Click -= new EventHandler(answerLabelClick);
            this.answerBLabel.Click -= new EventHandler(answerLabelClick);
            this.answerCLabel.Click -= new EventHandler(answerLabelClick);
            this.answerDLabel.Click -= new EventHandler(answerLabelClick);

            this.answerALabel.Cursor = Cursors.No;
            this.answerBLabel.Cursor = Cursors.No;
            this.answerCLabel.Cursor = Cursors.No;
            this.answerDLabel.Cursor = Cursors.No;

            percentA.Cursor = Cursors.No;
            percentB.Cursor = Cursors.No;
            percentC.Cursor = Cursors.No;
            percentD.Cursor = Cursors.No;

            diagramButtonLabel.Click -= new EventHandler(useDiagramHelp);
            ideaButtonLabel.Click -= new EventHandler(useIdeaHelp);
            fiftyPercentButtonLabel.Click -= new EventHandler(useFiftyPercentHelp);

            this.diagramButtonLabel.Cursor = Cursors.No;
            this.ideaButtonLabel.Cursor = Cursors.No;
            this.fiftyPercentButtonLabel.Cursor = Cursors.No;

            leaveWithPrize.Click -= leaveWithPrize_Click;
            leaveWithPrize.Cursor = Cursors.No;

            if (timerSeconds > 0)
            {
                timerActive = false;
                timerLabel.ForeColor = Color.DarkGray;
            }
        }

        private void winTimer_Tick(object sender, EventArgs e)
        {
            if (winTimer.Interval > 20)
            {
                winTimer.Interval -= 2;
            } else
            {
                questionLabel.ForeColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
                if (!endAssigned) {
                    endAssigned = !endAssigned;
                    Font newQuestionLabelFont = new Font(questionLabel.Font.FontFamily, 42);
                    questionLabel.Font = newQuestionLabelFont;
                    currentQuestionLabel.Font = newQuestionLabelFont;
                    prizeLabel.Font = newQuestionLabelFont;
                    currentQuestionLabel.Location = new Point(-10, 85);
                    prizeLabel.Location = new Point(710, 85);
                    currentQuestionLabel.Size = new Size(500, 200);
                    prizeLabel.Size = new Size(500, 200);


                }

                /*
                
                 // WARNING: EPILEPSY
                questionLabel.BackColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
                answerALabel.BackColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
                answerBLabel.BackColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
                answerCLabel.BackColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
                answerDLabel.BackColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
                currentQuestionLabel.BackColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
                prizeLabel.BackColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
                */
            }
            answerALabel.ForeColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
            answerBLabel.ForeColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
            answerCLabel.ForeColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
            answerDLabel.ForeColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
            currentQuestionLabel.ForeColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
            timerLabel.ForeColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
            prizeLabel.ForeColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
            elapsedTime.ForeColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
            if (winStopper.Elapsed.Seconds > 30)
            {
                winStopper.Stop();
                winTimer.Stop();
                questionLabel.ForeColor = Color.Goldenrod;
                questionLabel.Text = "Vége a játéknak!";
                endGameTimer.Start();
            }

        }

        private void endGameTimer_Tick(object sender, EventArgs e)
        {
            endGameTimer.Stop();
            if (endAssigned)
            {
                currentQuestionNumber++;
            }
            if (!leave) {
                currentQuestionNumber--;
                int minus = currentQuestionNumber % 5;
                currentQuestionNumber++;
                currentQuestionNumber = currentQuestionNumber - minus;
            }


            LeaderboardDialog subscribeToLeaderboardDialog = new LeaderboardDialog(prizes[currentQuestionNumber - 1], currentQuestionNumber - 1, String.Format("{0:00}:{1:00}", gameTime.Elapsed.Minutes, gameTime.Elapsed.Seconds), usedHelps, timerSeconds);
            subscribeToLeaderboardDialog.Show();
            // Leaderboard leaderboardDialog = new Leaderboard();
            // leaderboardDialog.Show();  // új feliratkozás esetén
            this.Close();
        }

        private void colorCorrectAnswer()
        {

            switch (currentQuestion.correct)
            {
                case 'A':
                    answerALabel.ForeColor = Color.ForestGreen;
                    break;
                case 'B':
                    answerBLabel.ForeColor = Color.ForestGreen;
                    break;
                case 'C':
                    answerCLabel.ForeColor = Color.ForestGreen;
                    break;
                default:
                    answerDLabel.ForeColor = Color.ForestGreen;
                    break;
            }

        }

        private void useDiagramHelp(object sender, EventArgs e)
        {
            usedHelps++;
            diagramButtonLabel.Visible = false;
            crossDiagram.Visible = true;
            int newPercent = 0;
            int[] chances = new int[4];
            

            for (int i = 0; i < 100; i++)
            {
                newPercent = r.Next(0, 100);
                if (newPercent < r.Next(30, 50))
                {
                    chances[0]++;
                } else if (newPercent < r.Next(60, 80))
                {
                    chances[1]++;
                } else if (newPercent < r.Next(85, 95))
                {
                    chances[2]++;
                } else
                {
                    chances[3]++;
                }
            }

            Label correct = new Label();
            List<Label> notCorrects = new List<Label>();

            notCorrects.Add(percentA);
            notCorrects.Add(percentB);
            notCorrects.Add(percentC);
            notCorrects.Add(percentD);


            switch (currentQuestion.correct)
            {
                case 'A':
                    correct = percentA;
                    notCorrects.Remove(percentA);

                    break;
                case 'B':
                    correct = percentB;
                    notCorrects.Remove(percentB);

                    break;
                case 'C':
                    correct = percentC;
                    notCorrects.Remove(percentC);

                    break;
                default:
                    correct = percentD;
                    notCorrects.Remove(percentD);

                    break;
            }

            correct.Text = chances[0].ToString() + "%";

            int randomNext = r.Next(0, 3);
            notCorrects[randomNext].Text = chances[1].ToString() + "%";
            notCorrects.RemoveAt(randomNext);

            randomNext = r.Next(0, 2);
            notCorrects[randomNext].Text = chances[2].ToString() + "%";
            notCorrects.RemoveAt(randomNext);

            notCorrects[0].Text = chances[3].ToString() + "%";

            percentA.Visible = true;
            percentB.Visible = true;
            percentC.Visible = true;
            percentD.Visible = true;
            currentUseDiagram = true;
        }

        private void useIdeaHelp(object sender, EventArgs e)
        {
            usedHelps++;
            ideaButtonLabel.Visible = false;
            crossIdea.Visible = true;
            
            List<Label> notCorrects = new List<Label>();
            notCorrects.Add(answerALabel);
            notCorrects.Add(answerBLabel);
            notCorrects.Add(answerCLabel);
            notCorrects.Add(answerDLabel);

            Label correct = new Label();

            switch (currentQuestion.correct)
            {
                case 'A':
                    correct = answerALabel;
                    notCorrects.Remove(answerALabel);
                    break;
                case 'B':
                    correct = answerBLabel;
                    notCorrects.Remove(answerBLabel);

                    break;
                case 'C':
                    correct = answerCLabel;
                    notCorrects.Remove(answerCLabel);

                    break;
                default:
                    correct = answerDLabel;
                    notCorrects.Remove(answerDLabel);

                    break;
            }


            int randomNum = r.Next(0, 100);
            if (randomNum < 67)
            {
                correct.ForeColor = Color.Aqua;
            } else
            {
                notCorrects[randomNum%3].ForeColor = Color.Aqua;
            }

        }

        private void useFiftyPercentHelp(object sender, EventArgs e)
        {
            usedHelps++;
            fiftyPercentButtonLabel.Visible = false;
            crossFifty.Visible = true;
            List<Label> notCorrects = new List<Label>();
            notCorrects.Add(answerALabel);
            notCorrects.Add(answerBLabel);
            notCorrects.Add(answerCLabel);
            notCorrects.Add(answerDLabel);

            switch (currentQuestion.correct)
            {
                case 'A':
                    notCorrects.Remove(answerALabel);
                    break;
                case 'B':
                    notCorrects.Remove(answerBLabel);
                    break;
                case 'C':
                    notCorrects.Remove(answerCLabel);
                    break;
                default:
                    notCorrects.Remove(answerDLabel);
                    break;
            }
            int randomNum = r.Next(0, 2);
            notCorrects.RemoveAt(randomNum);

            for (int i = 0; i < 2; i++)
            {
                notCorrects[i].ForeColor = Color.DimGray;
                notCorrects[i].Cursor = Cursors.No;
                notCorrects[i].Click -= new EventHandler(answerLabelClick);
            }

        }
    }
}
