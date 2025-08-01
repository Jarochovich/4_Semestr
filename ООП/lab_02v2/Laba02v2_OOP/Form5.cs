using System;

namespace Laba02v2_OOP
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            this.FormClosing += KillProcess.FormClosing;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 firstForm = new Form1();
            firstForm.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 secondForm = new Form2();
            secondForm.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 thirdForm = new Form3();
            thirdForm.Show();
            this.Hide();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 fourthForm = new Form4();
            fourthForm.Show();
            this.Hide();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form1 firstForm = new Form1();
            firstForm.Show();
            this.Hide();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form2 secondForm = new Form2();
            secondForm.Show();
            this.Hide();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Form3 thirdForm = new Form3();
            thirdForm.Show();
            this.Hide();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Form4 fourthForm = new Form4();
            fourthForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
