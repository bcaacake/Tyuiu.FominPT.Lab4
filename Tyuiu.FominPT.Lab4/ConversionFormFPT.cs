using System;
using System.Windows.Forms;
using ConversionCalc.Lib;

namespace Tyuiu.FominPT.Lab4
{
    public partial class ConversionFormFPT : Form
    {
        private ConversionCalcLib conversionCalc;

        public ConversionFormFPT()
        {
            InitializeComponent();
            conversionCalc = new ConversionCalcLib();
            comboBoxChooseInLengthFPT.SelectedIndex = 0;
            comboBoxChooseOutLengthFPT.SelectedIndex = 1;
            comboBoxChooseInWeightFPT.SelectedIndex = 0;
            comboBoxChooseOutWeightFPT.SelectedIndex = 1;
            comboBoxChooseInVolumeFPT.SelectedIndex = 0;
            comboBoxChooseOutVolumeFPT.SelectedIndex = 1;
        }

        private string GetUnitAbbreviation(string fullUnitName)
        {
            switch (fullUnitName)
            {
                case "Килограммы (kg)": return "kg";
                case "Граммы (grams)": return "g";
                case "Тонны (tons)": return "tons";
                case "Фунты (lbs)": return "lbs";
                case "Унции (oz)": return "oz";

                case "Метры (m)": return "m";
                case "Сантиметры (cm)": return "cm";
                case "Миллиметры (mm)": return "mm";
                case "Километры (km)": return "km";
                case "Футы (ft)": return "ft";
                case "Дюймы (in)": return "in";

                case "Литры (l)": return "l";
                case "Миллилитры (ml)": return "ml";
                case "Галлоны (gal)": return "gal";
                case "Кубические метры (m3)": return "m3";

                default: return string.Empty;
            }
        }

        private void CalculateConversion(ComboBox inUnitComboBox, ComboBox outUnitComboBox, TextBox inputTextBox, TextBox outputTextBox)
        {
            if (double.TryParse(inputTextBox.Text, out double inputValue))
            {
                string inUnit = inUnitComboBox.SelectedItem?.ToString() ?? string.Empty;
                string outUnit = outUnitComboBox.SelectedItem?.ToString() ?? string.Empty;

                if (string.IsNullOrEmpty(inUnit) || string.IsNullOrEmpty(outUnit))
                {
                    MessageBox.Show("Выберите входную и выходную единицы измерения.");
                    return;
                }

                inUnit = GetUnitAbbreviation(inUnit);
                outUnit = GetUnitAbbreviation(outUnit);

                try
                {
                    double result = conversionCalc.Convert(inputValue, inUnit, outUnit);
                    outputTextBox.Text = result.ToString();
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Введите корректное число.");
            }
        }

        private void textBoxInputWeightFPT_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxOutputWeightFPT_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxInputLengthFPT_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxOutputLengthFPT_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxInputVolumeFPT_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxOutputVolumeFPT_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxChooseInWeightFPT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxChooseOutWeightFPT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxChooseInLengthFPT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxChooseOutLengthFPT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxChooseInVolumeFPT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxChooseOutVolumeFPT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonCalculateWeightFPT_Click(object sender, EventArgs e)
        {
            CalculateConversion(comboBoxChooseInWeightFPT, comboBoxChooseOutWeightFPT, textBoxInputWeightFPT, textBoxOutputWeightFPT);
        }

        private void buttonCalculateLengthFPT_Click(object sender, EventArgs e)
        {
            CalculateConversion(comboBoxChooseInLengthFPT, comboBoxChooseOutLengthFPT, textBoxInputLengthFPT, textBoxOutputLengthFPT);
        }

        private void buttonCalculateVolumeFPT_Click(object sender, EventArgs e)
        {
            CalculateConversion(comboBoxChooseInVolumeFPT, comboBoxChooseOutVolumeFPT, textBoxInputVolumeFPT, textBoxOutputVolumeFPT);
        }

        private void OrdinaryTypeFPT_Click(object sender, EventArgs e)
        {
            MainFormFPT mainForm = new MainFormFPT();
            mainForm.Show();
            this.Hide();
        }

        private void ArithmeticTypeFPT_Click(object sender, EventArgs e)
        {
            ArithmeticFormFPT arithmeticForm = new ArithmeticFormFPT();
            arithmeticForm.Show();
            this.Hide();

        }

        private void UnitConversionTypeFPT_Click(object sender, EventArgs e)
        {
            ConversionFormFPT conversionForm = new ConversionFormFPT();
            conversionForm.Show();
            this.Hide();
        }

        private void FitnessTypeFPT_Click(object sender, EventArgs e)
        {
            FitnessFormFPT fitnessForm = new FitnessFormFPT();
            fitnessForm.Show();
            this.Hide();
        }

        private void ToolStripAboutFPT_Click(object sender, EventArgs e)
        {
            InfoFormFPT infoForm = new InfoFormFPT();
            infoForm.Show();
            this.Hide();
        }
    }
}
