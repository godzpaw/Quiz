using Quiz.Db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Game : Form
    {
        private readonly decimal Players;
        private readonly List<decimal> Scores = new List<decimal>();
        private Label[] labels;

        private List<decimal> FailedPlayersIds = new List<decimal>();

        private List<Questions> Questions;

        private decimal CurrentPlayer = 0;
        private Questions CurrentQuestion = null;

        public Game(decimal Players)
        {
            this.Players = Players;
            InitializeComponent();
            this.InitializePalayers();
            this.InitializeQuestions();
        }

        private void InitializePalayers()
        {
            this.labels = new Label[4] { this.Player1, this.Player2, this.Player3, this.Player4 };
            for (int playerId = 0; playerId < this.Players; playerId++)
            {
                this.labels[playerId].Visible = true;
                this.Scores.Add(0);
            }
            this.UpdateScores();
        }

        private void InitializeQuestions()
        {
            this.Questions = new QuizEntities().Questions.OrderBy(a => Guid.NewGuid()).ToList();
        }

        private void UpdateScores()
        {
            for (int playerId = 0; playerId < this.Players; playerId++)
            {
                this.labels[playerId].Text = $"Gracz {playerId + 1} : {this.Scores[playerId]}";
            }
        }

        private void NextPlayer()
        {
            this.CurrentPlayer = (this.CurrentPlayer + 1) % this.Players;
            if(this.FailedPlayersIds.Contains(this.CurrentPlayer))
            {
                this.NextPlayer();
            }
        }

        private void UpdateWhichPLayer()
        {
            this.WhichPlayer.Text = $"Aktualnie gra gracz {this.CurrentPlayer + 1}";
        }

        private void NextQuestion()
        {
            this.CurrentQuestion = this.Questions.First();
            this.CurrentQuestion.Answers = this.CurrentQuestion.Answers.OrderBy(a => Guid.NewGuid()).ToList();
            this.Questions.RemoveAt(0);
            this.UpdateNewQuestionView();
        }

        private void UpdateNewQuestionView()
        {
            this.UpdateQuestion();
            this.UpdateAnswers();
        }

        private void UpdateQuestion()
        {
            this.Question.Text = this.CurrentQuestion.question;
        }

        private void UpdateAnswers()
        {
            this.AnswerA.Text = this.CurrentQuestion.Answers.ToList()[0].answer;
            this.AnswerB.Text = this.CurrentQuestion.Answers.ToList()[1].answer;
            this.AnswerC.Text = this.CurrentQuestion.Answers.ToList()[2].answer;
        }

        private void Game_Load(object sender, EventArgs e)
        {
            this.UpdateWhichPLayer();
            this.NextQuestion();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ChoosenAnswer(this.CurrentQuestion.Answers.ToList()[0]);
        }

        private void AnswerB_Click(object sender, EventArgs e)
        {
            this.ChoosenAnswer(this.CurrentQuestion.Answers.ToList()[1]);
        }

        private void AnswerC_Click(object sender, EventArgs e)
        {
            this.ChoosenAnswer(this.CurrentQuestion.Answers.ToList()[2]);
        }

        private void ChoosenAnswer(Answers selected)
        {
            if(!selected.isValid)
            {
                this.FailedPlayersIds.Add(this.CurrentPlayer);
            }
            else
            {
                this.Scores[int.Parse(this.CurrentPlayer.ToString())] += this.CurrentQuestion.points;
            }

            if (this.Players == this.FailedPlayersIds.Count || false) 
            {
                this.GameEnd();
                return;
            }

            this.UpdateScores();
            this.NextPlayer();
            this.UpdateWhichPLayer();
            this.NextQuestion();
        }

        private void GameEnd()
        {
            MessageBox.Show("Koniec Gry");
            this.Close();
        }
    }
}
