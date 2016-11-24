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
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void score_Click(object sender, EventArgs e)
        {

        }
        private void checkButton_Click(object sender, EventArgs e)
        {
            if(questions.i < 4)
            {
                if (radioOption1.Checked && questions.ans[questions.i]==1)
                {
                    questions.score++;
                }
                else if (radioOption2.Checked && questions.ans[questions.i] == 2)
                {
                    questions.score++;
                }

                score.Text = "" + questions.score;

                questions.i++;
                question.Text = questions.question[questions.i];
                radioOption1.Text = questions.options[questions.i,0];
                radioOption2.Text = questions.options[questions.i, 1];

                radioOption1.Checked = false;
                radioOption2.Checked = false;
            }
            else
            {
                scoreLabel.Hide();
                score.Hide();
                question.Hide();
                radioOption1.Hide();
                radioOption2.Hide();
                checkButton.Hide();
                timeLimit.Hide();
                finalScore.Text += questions.score;
                finalScore.Show();
            }
        }

        private void quizForm_Load(object sender, EventArgs e)
        {

        }
    }
}
