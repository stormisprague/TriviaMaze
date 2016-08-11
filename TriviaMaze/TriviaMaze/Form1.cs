using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriviaMaze
{
    public partial class Form1 : Form
    {
        public TriviaManager manager;
        public Form1()
        {
            InitializeComponent();
            manager = new TriviaManager();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool correct = displayQuestion();

            if (correct)
            {
                MessageBox.Show("Correct!");
            }

            else
            {

                button1.Enabled = false;
                button1.Text = "Locked!";
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool correct = displayQuestion();

            
            if (correct)
            {
                MessageBox.Show("Correct!");
            }

            else
            {
                button2.Enabled = false;
                button2.Text = "Locked!";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool correct = displayQuestion();

            if (correct)
            {
                MessageBox.Show("Correct!");
            }

            else
            {
                button3.Enabled = false;
                button3.Text = "Locked!";
            }
        }

        private bool displayQuestion()
        {
            TriviaManager.TriviaQuestion q = new TriviaManager.TriviaQuestion();
            q = manager.GetRandomTriviaQuestion();
            bool answer;
            using (Form2 f2 = new Form2(q.Question, q.AnswerA, q.AnswerB, q.AnswerC, q.AnswerD, q.Answer))
            {
                f2.ShowDialog();
                answer = f2.correct;
            }
            return answer;
        }

    }
}
