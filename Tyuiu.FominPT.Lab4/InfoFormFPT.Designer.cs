namespace Tyuiu.FominPT.Lab4
{
    partial class InfoFormFPT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoFormFPT));
            this.ToolStripFPT = new System.Windows.Forms.ToolStrip();
            this.ToolStripButtonViewFPT = new System.Windows.Forms.ToolStripDropDownButton();
            this.OrdinaryTypeFPT = new System.Windows.Forms.ToolStripMenuItem();
            this.ArithmeticTypeFPT = new System.Windows.Forms.ToolStripMenuItem();
            this.UnitConversionTypeFPT = new System.Windows.Forms.ToolStripMenuItem();
            this.FitnessTypeFPT = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripAboutFPT = new System.Windows.Forms.ToolStripButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ToolStripFPT.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolStripFPT
            // 
            this.ToolStripFPT.BackColor = System.Drawing.SystemColors.WindowText;
            this.ToolStripFPT.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStripFPT.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButtonViewFPT,
            this.ToolStripAboutFPT});
            this.ToolStripFPT.Location = new System.Drawing.Point(0, 0);
            this.ToolStripFPT.Name = "ToolStripFPT";
            this.ToolStripFPT.Size = new System.Drawing.Size(528, 25);
            this.ToolStripFPT.TabIndex = 3;
            this.ToolStripFPT.Text = "toolStrip1";
            // 
            // ToolStripButtonViewFPT
            // 
            this.ToolStripButtonViewFPT.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ToolStripButtonViewFPT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStripButtonViewFPT.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OrdinaryTypeFPT,
            this.ArithmeticTypeFPT,
            this.UnitConversionTypeFPT,
            this.FitnessTypeFPT});
            this.ToolStripButtonViewFPT.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButtonViewFPT.Image")));
            this.ToolStripButtonViewFPT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonViewFPT.Name = "ToolStripButtonViewFPT";
            this.ToolStripButtonViewFPT.Size = new System.Drawing.Size(40, 22);
            this.ToolStripButtonViewFPT.Text = "Вид";
            // 
            // OrdinaryTypeFPT
            // 
            this.OrdinaryTypeFPT.Name = "OrdinaryTypeFPT";
            this.OrdinaryTypeFPT.Size = new System.Drawing.Size(180, 22);
            this.OrdinaryTypeFPT.Text = "Обычный";
            this.OrdinaryTypeFPT.Click += new System.EventHandler(this.OrdinaryTypeFPT_Click);
            // 
            // ArithmeticTypeFPT
            // 
            this.ArithmeticTypeFPT.Name = "ArithmeticTypeFPT";
            this.ArithmeticTypeFPT.Size = new System.Drawing.Size(180, 22);
            this.ArithmeticTypeFPT.Text = "Инженерный";
            this.ArithmeticTypeFPT.Click += new System.EventHandler(this.ArithmeticTypeFPT_Click);
            // 
            // UnitConversionTypeFPT
            // 
            this.UnitConversionTypeFPT.Name = "UnitConversionTypeFPT";
            this.UnitConversionTypeFPT.Size = new System.Drawing.Size(180, 22);
            this.UnitConversionTypeFPT.Text = "Перевод единиц";
            this.UnitConversionTypeFPT.Click += new System.EventHandler(this.UnitConversionTypeFPT_Click);
            // 
            // FitnessTypeFPT
            // 
            this.FitnessTypeFPT.Name = "FitnessTypeFPT";
            this.FitnessTypeFPT.Size = new System.Drawing.Size(180, 22);
            this.FitnessTypeFPT.Text = "Фитнес ";
            this.FitnessTypeFPT.Click += new System.EventHandler(this.FitnessTypeFPT_Click);
            // 
            // ToolStripAboutFPT
            // 
            this.ToolStripAboutFPT.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ToolStripAboutFPT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStripAboutFPT.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripAboutFPT.Image")));
            this.ToolStripAboutFPT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripAboutFPT.Name = "ToolStripAboutFPT";
            this.ToolStripAboutFPT.Size = new System.Drawing.Size(57, 22);
            this.ToolStripAboutFPT.Text = "Справка";
            this.ToolStripAboutFPT.Click += new System.EventHandler(this.ToolStripAboutFPT_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(40, 52);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(443, 263);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // InfoFormFPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(528, 364);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ToolStripFPT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InfoFormFPT";
            this.Text = "Фомин П.Т. МКМб-22-1";
            this.ToolStripFPT.ResumeLayout(false);
            this.ToolStripFPT.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip ToolStripFPT;
        private System.Windows.Forms.ToolStripDropDownButton ToolStripButtonViewFPT;
        private System.Windows.Forms.ToolStripMenuItem OrdinaryTypeFPT;
        private System.Windows.Forms.ToolStripMenuItem ArithmeticTypeFPT;
        private System.Windows.Forms.ToolStripMenuItem UnitConversionTypeFPT;
        private System.Windows.Forms.ToolStripMenuItem FitnessTypeFPT;
        private System.Windows.Forms.ToolStripButton ToolStripAboutFPT;
        private System.Windows.Forms.TextBox textBox1;
    }
}