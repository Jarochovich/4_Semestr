using System.Text.Json;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Laba02v2_OOP
{
    public partial class Form1 : Form
    {
        public string Manufacturer;
        public string Series;
        public string Model;
        public int Core = 1;
        public double Frequency;
        public double MaxFrequency;
        public string Opacityy;
        public string Cash;

        public Form1()
        {
            InitializeComponent();

            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;

            comboBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox2.AutoCompleteSource = AutoCompleteSource.ListItems;

            comboBox3.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox3.AutoCompleteSource = AutoCompleteSource.ListItems;

            List<string> manufacturer = new List<string> { "Intel", "AMD" };
            comboBox1.DataSource = manufacturer;

            comboBox1.SelectedIndex = -1;
            comboBox1.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);
            comboBox2.SelectedIndexChanged += new EventHandler(comboBox2_SelectedIndexChanged);
            comboBox3.SelectedIndexChanged += new EventHandler(comboBox3_SelectedIndexChanged);

            UpdateStatus("Работает");

            this.FormClosing += KillProcess.FormClosing;
        }

        private void UpdateStatus(string action)
        {
            toolStripStatusLabel1.Text = $"Объектов: {CountData()}";
            toolStripStatusLabel2.Text = $"Действие: {action}";
            toolStripStatusLabel3.Text = $"Дата/Время: {DateTime.Now:dd.MM.yyyy HH:mm:ss}";
        }

        private int CountData()
        {
            if (File.Exists("Processor.json"))
            {
                string jsonData = File.ReadAllText("Processor.json");
                var list = JsonConvert.DeserializeObject<List<Computer>>(jsonData);
                return list?.Count ?? 0;
            }
            return 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
                return;

            if (comboBox1.SelectedItem != null)
            {
                Manufacturer = comboBox1.SelectedItem.ToString();
            }

            string selectedManufacturer = comboBox1.SelectedItem.ToString();
            List<string> series = new List<string>();
            List<string> models = new List<string>();

            switch (selectedManufacturer)
            {
                case "Intel":
                    {
                        series.AddRange(new string[] { "Core i9", "Core i7", "Core i5" });
                        models.AddRange(new string[] { "12900K", "12700K", "12600K" });
                        break;
                    }
                case "AMD":
                    {
                        series.AddRange(new string[] { "Ryzen 9", "Ryzen 7", "Ryzen 5" });
                        models.AddRange(new string[] { "5900X", "5800X", "5600X" });
                        break;
                    }
            }

            comboBox2.DataSource = series;
            comboBox3.DataSource = models;

            comboBox2.Refresh();
            comboBox3.Refresh();
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
            {
                Series = comboBox2.SelectedItem.ToString();
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem != null)
            {
                Model = comboBox3.SelectedItem.ToString();
            }
        }
        private bool Test()
        {
            try
            {
                if (Cash == null || Opacityy == null || Manufacturer == null)
                    throw new Exception("Заполните все поля!");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Некорректные данные: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private void SaveToJson()
        {
            var processor = new Processor
            {
                Manufacturer = this.Manufacturer,
                Series = this.Series,
                Model = this.Model,
                Core = this.Core,
                Frequency = this.Frequency,
                MaxFrequency = this.MaxFrequency,
                Opacityy = this.Opacityy,
                Cash = this.Cash
            };

            var validationResults = new List<ValidationResult>();
            var context = new ValidationContext(processor);
            bool isValid = Validator.TryValidateObject(processor, context, validationResults, true);

            if (!isValid)
            {
                string errorMessages = string.Join("\n", validationResults.Select(v => v.ErrorMessage));
                MessageBox.Show("Некорректные данные:\n" + errorMessages, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<Processor> data = new List<Processor>();

            if (File.Exists("Processor.json"))
            {
                string existingJson = File.ReadAllText("Processor.json");
                if (!string.IsNullOrEmpty(existingJson))
                {
                    data = System.Text.Json.JsonSerializer.Deserialize<List<Processor>>(existingJson);
                }
            }

            bool exists = data.Any(entry =>
                entry.Manufacturer == processor.Manufacturer &&
                entry.Series == processor.Series &&
                entry.Model == processor.Model &&
                entry.Core == processor.Core &&
                entry.Frequency == processor.Frequency &&
                entry.MaxFrequency == processor.MaxFrequency &&
                entry.Opacityy == processor.Opacityy &&
                entry.Cash == processor.Cash
            );

            if (!exists)
            {
                data.Add(processor);
                string jsonString = System.Text.Json.JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText("Processor.json", jsonString);
                MessageBox.Show("Процессор сохранен успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Такой процессор уже существует!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        { //Сохранить
            SaveToJson();
            ClearInputs.ClearAllInputs(this);
        }

        private void button2_Click(object sender, EventArgs e)
        { // Отмена
            ClearInputs.ClearAllInputs(this);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Core = (int)numericUpDown1.Value;
            label4.Text = "Количество ядер: " + Core;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            Frequency = (double)numericUpDown2.Value;
            label5.Text = "Частота ГГц: " + Frequency;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            MaxFrequency = (double)numericUpDown3.Value;
            label6.Text = "Максимальная частота ГГц: " + MaxFrequency;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Opacityy = "x86";
            groupBox1.Text = "Разрядность архитектуры: " + Opacity;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Opacityy = "x64";
            groupBox1.Text = "Разрядность архитектуры: " + Opacity;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Cash = "L1";
            groupBox2.Text = "Размер кэша: " + Cash.ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Cash = "L2";
            groupBox2.Text = "Размер кэша: " + Cash.ToString();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            Cash = "L3";
            groupBox2.Text = "Размер кэша: " + Cash.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 secondForm = new Form2();
            secondForm.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 thirdForm = new Form3();
            thirdForm.Show();
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form2 secondForm = new Form2();
            secondForm.Show();
            this.Hide();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form3 thirdForm = new Form3();
            thirdForm.Show();
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel4_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
