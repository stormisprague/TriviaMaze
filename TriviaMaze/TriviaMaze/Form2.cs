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
    public partial class Form2 : Form
    {
        public bool correct;
        public char correctAnswer;
        public Form2(string q, string a1, string a2, string a3, string a4, char a)
        {
            InitializeComponent();
            question.Text = q;
            answer1.Text = a1;
            answer2.Text = a2;
            answer3.Text = a3;
            answer4.Text = a4;
            correctAnswer = a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            correct = string.Equals("a", correctAnswer.ToString(), StringComparison.CurrentCultureIgnoreCase);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            correct = string.Equals("b", correctAnswer.ToString(), StringComparison.CurrentCultureIgnoreCase);
            this.Close();
        }

        private void answer1_Click(object sender, EventArgs e)
        {
            correct = string.Equals("a", correctAnswer.ToString(), StringComparison.CurrentCultureIgnoreCase);
            this.Close();
        }

        private void answer3_Click(object sender, EventArgs e)
        {
            correct = string.Equals("c", correctAnswer.ToString(), StringComparison.CurrentCultureIgnoreCase);
            this.Close();
        }
    }
}
