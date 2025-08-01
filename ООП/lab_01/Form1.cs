using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_01
{
    public partial class Form1 : Form
    {
        private string valueBuf;
        private int numOperation = 0;

        private bool isError;
        private bool prevButtonEquals;
        private bool prevButtonNotation;

        private bool prevButtonBin = true;
        private bool prevButtonDec;
        private bool prevButtonOct;
        private bool prevButtonHex;

        public Form1()
        {
            InitializeComponent();
        }

        private void outputInput_TextChanged(object sender, EventArgs e)
        {
            
        }

        // Кнопки ввода цифр
        private void nullButton_Click(object sender, EventArgs e)
        {
            if (isError)
            {
                outputInput.Clear();
                isError = false;
            }
            if (prevButtonNotation)
            {
                outputInput.Clear();
                prevButtonNotation = false;
            }
            if (prevButtonEquals)
            {
                outputInput.Clear();
                prevButtonEquals = false;
            }
            outputInput.Text += "0";

            prevButtonBin = true;
            prevButtonDec = false;
            prevButtonOct = false;
            prevButtonHex = false;
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            if (isError)
            {
                outputInput.Clear();
                isError = false;
            }
            if (prevButtonNotation)
            {
                outputInput.Clear();
                prevButtonNotation = false;
            }
            if (prevButtonEquals)
            {
                outputInput.Clear();
                prevButtonEquals = false;
            }

            outputInput.Text += "1";

            prevButtonBin = true;
            prevButtonDec = false;
            prevButtonOct = false;
            prevButtonHex = false;
        }

        // Удаление введенных цифр
        private void backspcButton_Click(object sender, EventArgs e)
        {
            if (isError)
            {
                outputInput.Clear();
                isError = false;

                return;
            }

            string buf = outputInput.Text;
            int lengthText = buf.Length - 1;

            outputInput.Clear();

            for (int i = 0; i < lengthText; i++)
            {
                outputInput.Text += buf[i];
            }
        }

        private void ACButton_Click(object sender, EventArgs e)
        {
            outputInput.Clear();
        }

        // Бинарные операции
        private void andButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (numOperation == 0)
                {
                    numOperation = 1;
                    valueBuf = outputInput.Text;

                    outputInput.Clear();
                }
            }
            catch
            {
                outputInput.Text = "Error";
                isError = true;
            }
        }

        private void orButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (numOperation == 0)
                {
                    numOperation = 2;
                    valueBuf = outputInput.Text;

                    outputInput.Clear();
                }
            }
            catch
            {
                outputInput.Text = "Error";
                isError = true;
            }
        }

        private void xorButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (numOperation == 0)
                {
                    numOperation = 3;
                    valueBuf = outputInput.Text;

                    outputInput.Clear();
                }
            }
            catch
            {
                outputInput.Text = "Error";
                isError = true;
            }
        }

        private void notButton_Click(object sender, EventArgs e)
        {
            try 
            {
                if (outputInput.Text.Length != 0)
                {
                    int valueDec = Convert.ToInt32(outputInput.Text, 2);
                    int bitLength = outputInput.Text.Length;
                    // маска для инверсии
                    int mask = (1 << bitLength) - 1;
                    // применяем маску
                    int invertedvalueDec = ~valueDec & mask;
                    // PadLeft для выравнивания строк
                    string invertedBinary = Convert.ToString(invertedvalueDec, 2).PadLeft(bitLength, '0');

                    outputInput.Clear();

                    outputInput.Text = invertedBinary;
                }
            }
            catch {
                outputInput.Text = "Error";
                isError = true;
            }
        }

        // Кнопка рассчета
        private void equalsButton_Click(object sender, EventArgs e)
        {
            switch (numOperation)
            {
                case 1:
                    {
                        try
                        {
                            int valueDec1 = Convert.ToInt32(valueBuf, 2);

                            int resultValueDec = valueDec1 & Convert.ToInt32(outputInput.Text, 2);

                            string resultBinary = Convert.ToString(resultValueDec, 2).PadLeft(valueBuf.Length, '0');

                            outputInput.Clear();
                            outputInput.Text = resultBinary;
                            break;
                        }
                        catch
                        {
                            outputInput.Text = "Error";
                            isError = true;
                            break;
                        }
                    }
                case 2:
                    {
                        try
                        {
                            int valueDec1 = Convert.ToInt32(valueBuf, 2);

                            int resultValueDec = valueDec1 | Convert.ToInt32(outputInput.Text, 2);

                            string resultBinary = Convert.ToString(resultValueDec, 2).PadLeft(valueBuf.Length, '0');

                            outputInput.Clear();
                            outputInput.Text = resultBinary;
                            break;
                        }
                        catch
                        {
                            outputInput.Text = "Error";
                            isError = true;
                            break;
                        }
                    }
                case 3:
                    {
                        try
                        {
                            int valueDec1 = Convert.ToInt32(valueBuf, 2);

                            int resultValueDec = valueDec1 ^ Convert.ToInt32(outputInput.Text, 2);

                            string resultBinary = Convert.ToString(resultValueDec, 2).PadLeft(valueBuf.Length, '0');

                            outputInput.Clear();
                            outputInput.Text = resultBinary;
                            break;
                        }
                        catch
                        {
                            outputInput.Text = "Error";
                            isError = true;
                            break;
                        }
                    }
            }

            prevButtonEquals = true;
            numOperation = 0;
        }

        // Кнопки перевода систем счисления
        private void binButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!prevButtonBin)
                {
                    int value = ConvertToDecimal(outputInput.Text, GetPreviousBase());
                    outputInput.Text = Convert.ToString(value, 2);

                    SetButtonState(isBin: true);
                }
            }
            catch
            {
                HandleError();
            }
        }

        private void decButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!prevButtonDec)
                {
                    int value = ConvertToDecimal(outputInput.Text, GetPreviousBase());
                    outputInput.Text = value.ToString();

                    SetButtonState(isDec: true);
                }
            }
            catch
            {
                HandleError();
            }
        }

        private void octButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!prevButtonOct)
                {
                    int value = ConvertToDecimal(outputInput.Text, GetPreviousBase());
                    outputInput.Text = Convert.ToString(value, 8);

                    SetButtonState(isOct: true);
                }
            }
            catch
            {
                HandleError();
            }
        }

        private void hexButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!prevButtonHex)
                {
                    int value = ConvertToDecimal(outputInput.Text, GetPreviousBase());
                    outputInput.Text = Convert.ToString(value, 16).ToUpper();

                    SetButtonState(isHex: true);
                }
            }
            catch
            {
                HandleError();
            }
        }

        // Вспомогательные функции
        private int ConvertToDecimal(string input, int fromBase)
        {
            return Convert.ToInt32(input, fromBase);
        }

        private int GetPreviousBase()
        {
            if (prevButtonBin) return 2;
            if (prevButtonDec) return 10;
            if (prevButtonOct) return 8;
            if (prevButtonHex) return 16;
            throw new InvalidOperationException("Не определена предыдущая система счисления.");
        }

        private void SetButtonState(bool isBin = false, bool isDec = false, bool isOct = false, bool isHex = false)
        {
            prevButtonBin = isBin;
            prevButtonDec = isDec;
            prevButtonOct = isOct;
            prevButtonHex = isHex;
            prevButtonNotation = true;
        }

        private void HandleError()
        {
            outputInput.Text = "Error";
            isError = true;
        }
    }
}
