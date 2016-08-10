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
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            correct = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            correct = false;
            this.Close();
        }
    }
}
