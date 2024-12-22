using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.FominPT.Lab4
{
    public partial class InfoFormFPT : Form
    {
        public InfoFormFPT()
        {
            InitializeComponent();
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
