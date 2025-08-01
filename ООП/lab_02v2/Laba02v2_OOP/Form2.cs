using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text.Json;
using Newtonsoft.Json;
namespace Laba02v2_OOP
{
    public partial class Form2 : Form
    {
        public string typeComputer;
        public string ProcessorComputer;
        public string TypeVideoCard;
        public string typeRAM;
        public int sizeRam;
        public string typeMemory;
        public int sizeMemory;

        public Form2()
        {
            InitializeComponent();
            LoadComboBoxDataProcessor();
            LoadComboBoxDataComputer();
            UpdateStatus("Работает");
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;

            this.FormClosing += KillProcess.FormClosing;
        }

        private void LoadComboBoxDataProcessor()
        {
            string jsonFilePath = @"Processor.json";
            string json = File.ReadAllText(jsonFilePath);
            List<Processor> processors = JsonConvert.DeserializeObject<List<Processor>>(json);

            comboBox1.Items.Clear();

            foreach (var processor in processors)
            {
                comboBox1.Items.Add($"{processor.Manufacturer} {processor.Series} {processor.Model} {processor.Opacityy} {processor.Cash}");
            }
        }

        private void LoadComboBoxDataComputer()
        {
            string jsonFilePath = @"Computer.json";
            string json = File.ReadAllText(jsonFilePath);

            List<Computer> computers = JsonConvert.DeserializeObject<List<Computer>>(json);
            comboBox2.DataSource = computers;
        }

        private void SaveToJson()
        {
            var computer = new Computer
            {
                typeComputer = this.typeComputer,
                ProcessorComputer = this.ProcessorComputer,
                TypeVideoCard = this.TypeVideoCard,
                typeRAM = this.typeRAM,
                sizeRam = this.sizeRam,
                typeMemory = this.typeMemory,
                sizeMemory = this.sizeMemory,
            };

            var validationResults = new List<ValidationResult>();
            var context = new ValidationContext(computer);
            bool isValid = Validator.TryValidateObject(computer, context, validationResults, true);

            if (!isValid)
            {
                string errorMessages = string.Join("\n", validationResults.Select(v => v.ErrorMessage));
                MessageBox.Show("Некорректные данные:\n" + errorMessages, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<Computer> data = new List<Computer>();

            if (File.Exists("Computer.json"))
            {
                string existingJson = File.ReadAllText("Computer.json");
                if (!string.IsNullOrEmpty(existingJson))
                {
                    data = System.Text.Json.JsonSerializer.Deserialize<List<Computer>>(existingJson);
                }
            }

            bool exists = data.Any(entry =>
                entry.typeComputer == computer.typeComputer &&
                entry.ProcessorComputer == computer.ProcessorComputer &&
                entry.TypeVideoCard == computer.TypeVideoCard &&
                entry.typeRAM == computer.typeRAM &&
                entry.sizeRam == computer.sizeRam &&
                entry.typeMemory == computer.typeMemory &&
                entry.sizeMemory == computer.sizeMemory
            );

            if (!exists)
            {
                data.Add(computer);
                string jsonString = System.Text.Json.JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText("Computer.json", jsonString);
                MessageBox.Show("Компьютер сохранен успешно!", "Ура", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Такой компьютер уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        { // Сохранить
            SaveToJson();
            ClearInputs.ClearAllInputs(this);
        }

        private void button2_Click(object sender, EventArgs e)
        { // Отмена
            ClearInputs.ClearAllInputs(this);
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBox1.SelectedItem.ToString();
            ProcessorComputer = selectedItem;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            typeComputer = "Workstation ";
            groupBox1.Text = "Выбран тип компьютера: " + typeComputer;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            typeComputer = "Laptop ";
            groupBox1.Text = "Выбран тип компьютера: " + typeComputer;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            typeComputer = "Server ";
            groupBox1.Text = "Выбран тип компьютера: " + typeComputer;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            TypeVideoCard = "Built-in ";
            groupBox2.Text = "Выбран тип видеокарты: " + TypeVideoCard;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            TypeVideoCard = "Discrete ";
            groupBox2.Text = "Выбран тип видеокарты: " + TypeVideoCard;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            typeRAM = "DDR3 ";
            groupBox3.Text = "Выбран тип ОЗУ: " + typeRAM;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            typeRAM = "DDR4 ";
            groupBox3.Text = "Выбран тип ОЗУ: " + typeRAM;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            typeRAM = "DDR5 ";
            groupBox3.Text = "Выбран тип ОЗУ: " + typeRAM;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label2.Text = "ОЗУ: " + trackBar1.Value.ToString() + "Гб";
            sizeRam = trackBar1.Value;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            typeMemory = " SSD ";
            groupBox4.Text = "Выбран тип жесткого диска: " + typeMemory;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            typeMemory = " HDD ";
            groupBox4.Text = "Выбран тип жесткого диска: " + typeMemory;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            sizeMemory = (int)numericUpDown1.Value;
            label3.Text = "Выбран размер жесткого диска: " + sizeMemory;
        }

        private void button3_Click(object sender, EventArgs e)
        {  // Расчёт стоимости лаборатории
            int res = CalculatePrice.Price();
            groupBox5.Text = "Стоимость компьютеров в лаборатории: " + res.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 thirdForm = new Form3();
            thirdForm.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 firstForm = new Form1();
            firstForm.Show();
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

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

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
        private void UpdateStatus(string action)
        {
            toolStripStatusLabel1.Text = $"Объектов: {CountData()}";
            toolStripStatusLabel2.Text = $"Действие: {action}";
            toolStripStatusLabel3.Text = $"Дата/Время: {DateTime.Now:dd.MM.yyyy HH:mm:ss}";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form1 firstForm = new Form1();
            firstForm.Show();
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged_1(object sender, EventArgs e)
        {
            TypeVideoCard = "Built-in ";
            groupBox2.Text = "Выбран тип видеокарты: " + TypeVideoCard;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            TypeVideoCard = "Discrete ";
            groupBox2.Text = "Выбран тип видеокарты: " + TypeVideoCard;
        }
    }
}
