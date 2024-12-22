using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OrdinaryCalc.Lib;

namespace Tyuiu.FominPT.Lab4
{
    public partial class MainFormFPT : Form
    {
        private double FirstValue;
        private string currentOperation;
        private OrdinaryCalcLib calculator;
        private Stack<double> valuesStack;
        private Stack<string> operationsStack;
        public MainFormFPT()
        {
            InitializeComponent();
            calculator = new OrdinaryCalcLib();
            valuesStack = new Stack<double>();
            operationsStack = new Stack<string>();
        }

        private void AppendDigit(string digit)
        {
            if (TextBoxDisplayFPT.Text == "0" && digit != ",")
            {
                TextBoxDisplayFPT.Text = digit;
            }
            else
            {
                TextBoxDisplayFPT.Text += digit;
            }
        }

        private void ClearAll()
        {
            TextBoxDisplayFPT.Clear();
            FirstValue = 0;
            currentOperation = string.Empty;
            valuesStack.Clear();
            operationsStack.Clear();
        }

        private void PushOperation(string operation)
        {
            double currentValue = Convert.ToDouble(TextBoxDisplayFPT.Text);
            valuesStack.Push(currentValue);
            operationsStack.Push(operation);
            TextBoxDisplayFPT.Text = "0";
        }

        private double PerformOperation(string operation, double value1, double value2)
        {
            switch (operation)
            {
                case "+":
                    return calculator.CalcSumma(value1, value2);
                case "-":
                    return calculator.CalcDifference(value1, value2);
                case "*":
                    return calculator.CalcMultiplication(value1, value2);
                case "/":
                    return calculator.CalcQuotient(value1, value2);
                case "+-":
                    return -value1;
                case "%":
                    return calculator.CalcPercentage(value1);
                case "sqrt":
                    return calculator.CalcSquareRoot(value1);
                case "square":
                    return calculator.CalcSquare(value1);
                case "rec":
                    return calculator.CalcReciprocal(value1);
                default:
                    throw new InvalidOperationException("Неизвестная операция");
            }
        }

        private void CalculateResult()
        {
            double currentValue = Convert.ToDouble(TextBoxDisplayFPT.Text);
            valuesStack.Push(currentValue);

            while (operationsStack.Count > 0)
            {
                string operation = operationsStack.Pop();
                double value2 = valuesStack.Pop();
                double value1 = valuesStack.Pop();
                double result = PerformOperation(operation, value1, value2);
                valuesStack.Push(result);
            }

            double finalResult = valuesStack.Pop();
            TextBoxDisplayFPT.Text = finalResult.ToString();
        }

        private void ButtonPercentFPT_Click(object sender, EventArgs e)
        {
            PushOperation("%");
        }

        private void ButtonClearFPT_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ButtonBackspaceFPT_Click(object sender, EventArgs e)
        {
            if (TextBoxDisplayFPT.Text.Length > 0)
            {
                TextBoxDisplayFPT.Text = TextBoxDisplayFPT.Text.Substring(0, TextBoxDisplayFPT.Text.Length - 1);
            }
        }

        private void ButtonReciprocalFPT_Click(object sender, EventArgs e)
        {
            PushOperation("rec");
        }

        private void ButtonSquareFPT_Click(object sender, EventArgs e)
        {
            PushOperation("square");
        }

        private void ButtonSquareRootFPT_Click(object sender, EventArgs e)
        {
            PushOperation("sqrt");
        }

        private void ButtonDivideFPT_Click(object sender, EventArgs e)
        {
            PushOperation("/");
        }

        private void ButtonNumberSevenFPT_Click(object sender, EventArgs e)
        {
            AppendDigit("7");
        }

        private void ButtonNumberEightFPT_Click(object sender, EventArgs e)
        {
            AppendDigit("8");
        }

        private void ButtonNumberNineFPT_Click(object sender, EventArgs e)
        {
            AppendDigit("9");
        }

        private void ButtonMultiplyFPT_Click(object sender, EventArgs e)
        {
            PushOperation("*");
        }

        private void ButtonNumberFourFPT_Click(object sender, EventArgs e)
        {
            AppendDigit("4");
        }

        private void ButtonNumberFiveFPT_Click(object sender, EventArgs e)
        {
            AppendDigit("5");
        }

        private void ButtonNumberSixFPT_Click(object sender, EventArgs e)
        {
            AppendDigit("6");
        }

        private void ButtonNumberOneFPT_Click(object sender, EventArgs e)
        {
            AppendDigit("1");
        }

        private void ButtonNumberTwoFPT_Click(object sender, EventArgs e)
        {
            AppendDigit("2");
        }

        private void ButtonNumberThreeFPT_Click(object sender, EventArgs e)
        {
            AppendDigit("3");
        }

        private void ButtonAddFPT_Click(object sender, EventArgs e)
        {
            PushOperation("+");
        }

        private void ButtonNegateFPT_Click(object sender, EventArgs e)
        {
            PushOperation("+-");
        }

        private void ButtonNumberZeroFPT_Click(object sender, EventArgs e)
        {
            AppendDigit("0");
        }

        private void ButtonDecimalFPT_Click(object sender, EventArgs e)
        {
            if (!TextBoxDisplayFPT.Text.Contains(","))
            {
                TextBoxDisplayFPT.Text += ",";
            }
        }

        private void ButtonEqualsFPT_Click(object sender, EventArgs e)
        {
            CalculateResult();
        }

        private void ButtonSubtractFPT_Click(object sender, EventArgs e)
        {
            PushOperation("-");
        }

        private void ToolStripFPT_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ToolStripButtonViewFPT_Click(object sender, EventArgs e)
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

        private void CalculatorLayoutPanelFPT_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextBoxDisplayFPT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
