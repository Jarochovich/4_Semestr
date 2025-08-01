using Newtonsoft.Json;

namespace Laba02v2_OOP
{
    public partial class Form4 : Form
    {
        private List<Computer> computers = new List<Computer>();
        private List<Computer> currentSortedData = new List<Computer>();

        public Form4()
        {
            InitializeComponent();
            this.FormClosing += KillProcess.FormClosing;
            LoadData();
            UpdateStatus("Работает");
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


        private void LoadData()
        {
            try
            {
                string jsonPath = "Computer.json";
                if (File.Exists(jsonPath))
                {
                    string jsonData = File.ReadAllText(jsonPath);
                    computers = JsonConvert.DeserializeObject<List<Computer>>(jsonData);
                }
                else
                {
                    MessageBox.Show("Файл не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayData(List<Computer> data)
        {
            returnListBox.Items.Clear();
            foreach (var comp in data)
            {
                returnListBox.Items.Add($"{comp.typeComputer} {comp.ProcessorComputer} {comp.TypeVideoCard} {comp.typeRAM} {comp.sizeRam}GB {comp.typeMemory} {comp.sizeMemory}GB");
            }
            currentSortedData = data;
        }

        private void buttonType_Click(object sender, EventArgs e)
        {
            var sortedByType = computers.OrderBy(c => c.typeComputer).ToList();
            DisplayData(sortedByType);
        }

        private void buttonDisk_Click(object sender, EventArgs e)
        {
            var sortedByDiskSize = computers.OrderBy(c => c.sizeMemory).ToList();
            DisplayData(sortedByDiskSize);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string jsonPath = "Sort.json";
                string jsonData = JsonConvert.SerializeObject(currentSortedData, Formatting.Indented);
                File.WriteAllText(jsonPath, jsonData);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            Form5 fiftForm = new Form5();
            fiftForm.Show();
            this.Hide();
        }

        private void returnListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Form4_Load(object sender, EventArgs e)
        {
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
            Form5 fiftForm = new Form5();
            fiftForm.Show();
            this.Hide();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            SaveButton_Click(sender, e);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            string filePath = "Sort.json";
            var emptyObject = new { };

            string emptyJson = JsonConvert.SerializeObject(emptyObject);
            File.WriteAllText(filePath, emptyJson);
        }
    }
}