using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace Laba02v2_OOP
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }

    public class Computer
    {
        [Required(ErrorMessage = "��� ����������")]
        public string typeComputer { get; set; }

        [Required(ErrorMessage = "��������� ����������")]
        [ProcessorValidation]
        public string ProcessorComputer { get; set; }

        [Required(ErrorMessage = "��� ���������� ����������")]
        public string TypeVideoCard { get; set; }

        [Required(ErrorMessage = "��� �����������")]
        public string typeRAM { get; set; }

        [Range(1, 128, ErrorMessage = "��� ������ ���� �� 1 �� 128 ��")]
        public int sizeRam { get; set; }

        [Required(ErrorMessage = "��� ����� ����������")]
        public string typeMemory { get; set; }

        [Range(127, 8192, ErrorMessage = "����� ����� ������ ���� �� 128 �� 8192 ��")]
        public int sizeMemory { get; set; }

        public override string ToString()
        {
            return typeComputer + ProcessorComputer + TypeVideoCard + typeRAM + sizeRam + typeMemory + sizeMemory;
        }
    }

    public class Processor
    {
        [Required(ErrorMessage = "������������� ����������")]
        public string Manufacturer { get; set; }

        [Required(ErrorMessage = "����� �����������")]
        public string Series { get; set; }

        [Required(ErrorMessage = "������ �����������")]
        public string Model { get; set; }

        [Range(1, 64, ErrorMessage = "���������� ���� ������ ���� �� 1 �� 64")]
        public int Core { get; set; }

        [Range(0.1, 10.0, ErrorMessage = "������� ������ ���� � ��������� �� 0.1 �� 10 ���")]
        public double Frequency { get; set; }

        [Range(0.1, 10.0, ErrorMessage = "������������ ������� ������ ���� � ��������� �� 0.1 �� 10 ���")]
        public double MaxFrequency { get; set; }

        [Required(ErrorMessage = "����������� �����������")]
        public string Opacityy { get; set; }

        [Required(ErrorMessage = "���-������ �����������")]
        public string Cash { get; set; }
    }


    public static class KillProcess
    {
        public static void FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Process[] processes = Process.GetProcessesByName("Laba02v2_OOP");
                foreach (var process in processes)
                {
                    process.Kill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("������ ��� ���������� ���������: " + ex.Message);
            }
        }
    }

    public class ClearInputs
    {
        public static void ClearAllInputs(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Clear();
                }
                else if (ctrl is CheckBox)
                {
                    ((CheckBox)ctrl).Checked = false;
                }
                else if (ctrl is RadioButton)
                {
                    ((RadioButton)ctrl).Checked = false;
                }
                else if (ctrl is DateTimePicker)
                {
                    ((DateTimePicker)ctrl).Value = DateTime.Now;
                }

                if (ctrl.HasChildren)
                {
                    ClearAllInputs(ctrl);
                }
            }
        }
    }

    public class ProcessorValidationAttribute : ValidationAttribute
    {
        private static string[] ValidProcessors = { "Intel", "AMD" };

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is string processor)
            {
                if (ValidProcessors.Any(p => processor.StartsWith(p, StringComparison.OrdinalIgnoreCase)))
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult("��������� ������ ���������� � \"Intel\" ��� \"AMD\"");
                }
            }

            return new ValidationResult("������������ �������� ��� ����������");
        }
    }
}