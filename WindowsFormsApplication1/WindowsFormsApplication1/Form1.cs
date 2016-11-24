using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class quizForm : Form
    {
        Questions questions = new Questions();
        public quizForm()
        {
            InitializeComponent();
            question.Text = questions.question[questions.i];
            radioOption1.Text = questions.options[questions.i,0];
            radioOption2.Text = questions.options[questions.i, 1];
            score.Text = "" + questions.score;
            finalScore.Hide();
            timeLabel.Text = "15 seconds";
            timer.Start();
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void score_Click(object sender, EventArgs e)
        {

        }
        private void checkButton_Click(object sender, EventArgs e)
        {
            if (radioOption1.Checked && questions.ans[questions.i] == 1)
            {
                questions.score++;
            }
            else if (radioOption2.Checked && questions.ans[questions.i] == 2)
            {
                questions.score++;
            }

            if (questions.i == 4)
            {
                scoreLabel.Hide();
                score.Hide();
                question.Hide();
                radioOption1.Hide();
                radioOption2.Hide();
                checkButton.Hide();
                timer.Stop();
                timeLabel.Hide();
                timeLimit.Hide();
                finalScore.Text += questions.score;
                finalScore.Show();
            }
            else
            {
                score.Text = "" + questions.score;

                
                questions.i++;
                question.Text = questions.question[questions.i];
                radioOption1.Text = questions.options[questions.i,0];
                radioOption2.Text = questions.options[questions.i, 1];
                
                radioOption1.Checked = false;
                radioOption2.Checked = false;
            }
            questions.timeLeft = 16;
        }

        private void quizForm_Load(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (questions.timeLeft > 0)
            {
                questions.timeLeft--;
                timeLabel.Text = questions.timeLeft + " seconds";
            }
            else
            {
                if (questions.i == 4)
                {
                    scoreLabel.Hide();
                    score.Hide();
                    question.Hide();
                    radioOption1.Hide();
                    radioOption2.Hide();
                    checkButton.Hide();
                    timer.Stop();
                    timeLabel.Hide();
                    timeLimit.Hide();
                    finalScore.Text += questions.score;
                    finalScore.Show();
                }
                else
                {
                    score.Text = "" + questions.score;


                    questions.i++;
                    question.Text = questions.question[questions.i];
                    radioOption1.Text = questions.options[questions.i, 0];
                    radioOption2.Text = questions.options[questions.i, 1];

                    radioOption1.Checked = false;
                    radioOption2.Checked = false;
                }
                questions.timeLeft = 16;
            }
        }
    }
}
