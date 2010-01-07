using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace snakesnladders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRollDice_Click(object sender, EventArgs e)
        {
            Random a = new Random();
            textBoxDice.Text = Convert.ToString(a.Next(1,5));
            int b = Convert.ToInt32(textBoxDice.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
        }

        private void MenuNewGame_Click(object sender, EventArgs e)
        {

        }
    }
}
