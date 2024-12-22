using System;
using System.Collections.Generic;
using FitnessCalc.Lib;

using System.Windows.Forms;

namespace Tyuiu.FominPT.Lab4
{
    public partial class FitnessFormFPT : Form
    {
        private Dictionary<string, string> activityLevelMapping = new Dictionary<string, string>
        {
            { "Сидячий образ жизни", "light" },
            { "Редкая физическая активность", "moderate" },
            { "Активный образ жизни", "active" },
            { "Профессионально занимаюсь спортом", "very active" }
        };

        public FitnessFormFPT()
        {
            InitializeComponent();
        }

        private void buttonCalculateVolumeFPT_Click(object sender, EventArgs e)
        {
            try
            {
                double weightKg = double.Parse(textBoxEnterWeightFPT.Text);
                double heightCm = double.Parse(textBoxEnterHeightFPT.Text);
                int age = int.Parse(textBoxEnterAgeFPT.Text);

                string gender = radioButtonChooseGenderMaleFPT.Checked ? "male" : "female";

                string selectedActivityLabel = comboBoxChooseActivityLevelFPT.SelectedItem.ToString();
                string activityLevel = activityLevelMapping[selectedActivityLabel];

                FitnessCalcLib fitnessCalc = new FitnessCalcLib();

                double bmi = fitnessCalc.CalculateBMI(weightKg, heightCm / 100);

                var bmrResult = fitnessCalc.CalculateBMR(weightKg, heightCm, age, gender, activityLevel);

                textBoxShowResultFPT.Text = $"BMI: {bmi:F2}\r\n" +
                                            $"Калории: {bmrResult.Calories:F2}\r\n" +
                                            $"Белки: {bmrResult.Proteins:F2} г\r\n" +
                                            $"Жиры: {bmrResult.Fats:F2} г\r\n" +
                                            $"Углеводы: {bmrResult.Carbohydrates:F2} г";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxEnterWeightFPT_TextChanged(object sender, EventArgs e)
        {

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
