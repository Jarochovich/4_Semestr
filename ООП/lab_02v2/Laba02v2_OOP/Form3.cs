using Microsoft.VisualBasic.Devices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Laba02v2_OOP
{
    public partial class Form3 : Form
    {
        private List<Computer> computers = new List<Computer>();
        public Form3()
        {
            InitializeComponent();
            LoadDataForm3();
            UpdateStatus("Работает");

            this.FormClosing += KillProcess.FormClosing;
        }

        public void LoadDataForm3()
        {
            string jsonFilePath = @"Computer.json";
            string json = File.ReadAllText(jsonFilePath);

            computers = JsonConvert.DeserializeObject<List<Computer>>(json);
            listBox1.DataSource = computers;
        }

        private void UpdateStatus(string action)
        {
            toolStripStatusLabel1.Text = $"Объектов: {CountData()}";
            toolStripStatusLabel2.Text = $"Действие: {action}";
            toolStripStatusLabel3.Text = $"Дата/Время: {DateTime.Now:dd.MM.yyyy HH:mm:ss}";
        }

        private int CountData()
        {
            if (File.Exists("Computer.json"))
            {
                string jsonData = File.ReadAllText("Computer.json");
                var list = JsonConvert.DeserializeObject<List<Computer>>(jsonData);
                return list?.Count ?? 0;
            }
            return 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            Regex regex = new Regex(input, RegexOptions.IgnoreCase);

            var result = computers.Where(p => regex.IsMatch(p.typeComputer + p.ProcessorComputer + p.TypeVideoCard + p.typeRAM + p.sizeRam + p.typeMemory + p.sizeMemory)).ToList();
            listBox1.DataSource = result;
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
            Form4 fourthForm = new Form4();
            fourthForm.Show();
            this.Hide();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form5 fiftForm = new Form5();
            fiftForm.Show();
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
            Form4 fourthForm = new Form4();
            fourthForm.Show();
            this.Hide();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Form5 fiftForm = new Form5();
            fiftForm.Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
