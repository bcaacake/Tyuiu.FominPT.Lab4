namespace Tyuiu.FominPT.Lab4
{
    partial class ConversionFormFPT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConversionFormFPT));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxChooseInWeightFPT = new System.Windows.Forms.ComboBox();
            this.comboBoxChooseOutWeightFPT = new System.Windows.Forms.ComboBox();
            this.buttonCalculateWeightFPT = new System.Windows.Forms.Button();
            this.textBoxInputWeightFPT = new System.Windows.Forms.TextBox();
            this.textBoxOutputWeightFPT = new System.Windows.Forms.TextBox();
            this.textBoxOutputLengthFPT = new System.Windows.Forms.TextBox();
            this.textBoxInputLengthFPT = new System.Windows.Forms.TextBox();
            this.buttonCalculateLengthFPT = new System.Windows.Forms.Button();
            this.comboBoxChooseOutLengthFPT = new System.Windows.Forms.ComboBox();
            this.comboBoxChooseInLengthFPT = new System.Windows.Forms.ComboBox();
            this.textBoxOutputVolumeFPT = new System.Windows.Forms.TextBox();
            this.textBoxInputVolumeFPT = new System.Windows.Forms.TextBox();
            this.buttonCalculateVolumeFPT = new System.Windows.Forms.Button();
            this.comboBoxChooseOutVolumeFPT = new System.Windows.Forms.ComboBox();
            this.comboBoxChooseInVolumeFPT = new System.Windows.Forms.ComboBox();
            this.ToolStripFPT = new System.Windows.Forms.ToolStrip();
            this.ToolStripButtonViewFPT = new System.Windows.Forms.ToolStripDropDownButton();
            this.OrdinaryTypeFPT = new System.Windows.Forms.ToolStripMenuItem();
            this.ArithmeticTypeFPT = new System.Windows.Forms.ToolStripMenuItem();
            this.UnitConversionTypeFPT = new System.Windows.Forms.ToolStripMenuItem();
            this.FitnessTypeFPT = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripAboutFPT = new System.Windows.Forms.ToolStripButton();
            this.ToolStripFPT.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(129, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Единицы массы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Перевод единиц измерения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(115, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Единицы расстояния";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(129, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Единицы объема";
            // 
            // comboBoxChooseInWeightFPT
            // 
            this.comboBoxChooseInWeightFPT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxChooseInWeightFPT.FormattingEnabled = true;
            this.comboBoxChooseInWeightFPT.Items.AddRange(new object[] {
            "Килограммы (kg)",
            "Граммы (grams)",
            "Тонны (tons)",
            "Фунты (lbs)",
            "Унции (oz)"});
            this.comboBoxChooseInWeightFPT.Location = new System.Drawing.Point(12, 99);
            this.comboBoxChooseInWeightFPT.Name = "comboBoxChooseInWeightFPT";
            this.comboBoxChooseInWeightFPT.Size = new System.Drawing.Size(121, 21);
            this.comboBoxChooseInWeightFPT.TabIndex = 4;
            this.comboBoxChooseInWeightFPT.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseInWeightFPT_SelectedIndexChanged);
            // 
            // comboBoxChooseOutWeightFPT
            // 
            this.comboBoxChooseOutWeightFPT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxChooseOutWeightFPT.FormattingEnabled = true;
            this.comboBoxChooseOutWeightFPT.Items.AddRange(new object[] {
            "Килограммы (kg)",
            "Граммы (grams)",
            "Тонны (tons)",
            "Фунты (lbs)",
            "Унции (oz)"});
            this.comboBoxChooseOutWeightFPT.Location = new System.Drawing.Point(251, 99);
            this.comboBoxChooseOutWeightFPT.Name = "comboBoxChooseOutWeightFPT";
            this.comboBoxChooseOutWeightFPT.Size = new System.Drawing.Size(121, 21);
            this.comboBoxChooseOutWeightFPT.TabIndex = 5;
            this.comboBoxChooseOutWeightFPT.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseOutWeightFPT_SelectedIndexChanged);
            // 
            // buttonCalculateWeightFPT
            // 
            this.buttonCalculateWeightFPT.BackColor = System.Drawing.Color.DarkGray;
            this.buttonCalculateWeightFPT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCalculateWeightFPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalculateWeightFPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalculateWeightFPT.Location = new System.Drawing.Point(155, 84);
            this.buttonCalculateWeightFPT.Name = "buttonCalculateWeightFPT";
            this.buttonCalculateWeightFPT.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculateWeightFPT.TabIndex = 10;
            this.buttonCalculateWeightFPT.Text = "=";
            this.buttonCalculateWeightFPT.UseVisualStyleBackColor = false;
            this.buttonCalculateWeightFPT.Click += new System.EventHandler(this.buttonCalculateWeightFPT_Click);
            // 
            // textBoxInputWeightFPT
            // 
            this.textBoxInputWeightFPT.Location = new System.Drawing.Point(12, 73);
            this.textBoxInputWeightFPT.Name = "textBoxInputWeightFPT";
            this.textBoxInputWeightFPT.Size = new System.Drawing.Size(121, 20);
            this.textBoxInputWeightFPT.TabIndex = 13;
            this.textBoxInputWeightFPT.TextChanged += new System.EventHandler(this.textBoxInputWeightFPT_TextChanged);
            // 
            // textBoxOutputWeightFPT
            // 
            this.textBoxOutputWeightFPT.Location = new System.Drawing.Point(250, 73);
            this.textBoxOutputWeightFPT.Name = "textBoxOutputWeightFPT";
            this.textBoxOutputWeightFPT.Size = new System.Drawing.Size(121, 20);
            this.textBoxOutputWeightFPT.TabIndex = 14;
            this.textBoxOutputWeightFPT.TextChanged += new System.EventHandler(this.textBoxOutputWeightFPT_TextChanged);
            // 
            // textBoxOutputLengthFPT
            // 
            this.textBoxOutputLengthFPT.Location = new System.Drawing.Point(250, 211);
            this.textBoxOutputLengthFPT.Name = "textBoxOutputLengthFPT";
            this.textBoxOutputLengthFPT.Size = new System.Drawing.Size(121, 20);
            this.textBoxOutputLengthFPT.TabIndex = 19;
            this.textBoxOutputLengthFPT.TextChanged += new System.EventHandler(this.textBoxOutputLengthFPT_TextChanged);
            // 
            // textBoxInputLengthFPT
            // 
            this.textBoxInputLengthFPT.Location = new System.Drawing.Point(12, 211);
            this.textBoxInputLengthFPT.Name = "textBoxInputLengthFPT";
            this.textBoxInputLengthFPT.Size = new System.Drawing.Size(121, 20);
            this.textBoxInputLengthFPT.TabIndex = 18;
            this.textBoxInputLengthFPT.TextChanged += new System.EventHandler(this.textBoxInputLengthFPT_TextChanged);
            // 
            // buttonCalculateLengthFPT
            // 
            this.buttonCalculateLengthFPT.BackColor = System.Drawing.Color.DarkGray;
            this.buttonCalculateLengthFPT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCalculateLengthFPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalculateLengthFPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalculateLengthFPT.Location = new System.Drawing.Point(155, 222);
            this.buttonCalculateLengthFPT.Name = "buttonCalculateLengthFPT";
            this.buttonCalculateLengthFPT.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculateLengthFPT.TabIndex = 17;
            this.buttonCalculateLengthFPT.Text = "=";
            this.buttonCalculateLengthFPT.UseVisualStyleBackColor = false;
            this.buttonCalculateLengthFPT.Click += new System.EventHandler(this.buttonCalculateLengthFPT_Click);
            // 
            // comboBoxChooseOutLengthFPT
            // 
            this.comboBoxChooseOutLengthFPT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxChooseOutLengthFPT.FormattingEnabled = true;
            this.comboBoxChooseOutLengthFPT.Items.AddRange(new object[] {
            "Метры (m)",
            "Сантиметры (cm)",
            "Миллиметры (mm)",
            "Километры (km)",
            "Футы (ft)",
            "Дюймы (in)"});
            this.comboBoxChooseOutLengthFPT.Location = new System.Drawing.Point(251, 237);
            this.comboBoxChooseOutLengthFPT.Name = "comboBoxChooseOutLengthFPT";
            this.comboBoxChooseOutLengthFPT.Size = new System.Drawing.Size(121, 21);
            this.comboBoxChooseOutLengthFPT.TabIndex = 16;
            this.comboBoxChooseOutLengthFPT.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseOutLengthFPT_SelectedIndexChanged);
            // 
            // comboBoxChooseInLengthFPT
            // 
            this.comboBoxChooseInLengthFPT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxChooseInLengthFPT.FormattingEnabled = true;
            this.comboBoxChooseInLengthFPT.Items.AddRange(new object[] {
            "Метры (m)",
            "Сантиметры (cm)",
            "Миллиметры (mm)",
            "Километры (km)",
            "Футы (ft)",
            "Дюймы (in)"});
            this.comboBoxChooseInLengthFPT.Location = new System.Drawing.Point(12, 237);
            this.comboBoxChooseInLengthFPT.Name = "comboBoxChooseInLengthFPT";
            this.comboBoxChooseInLengthFPT.Size = new System.Drawing.Size(121, 21);
            this.comboBoxChooseInLengthFPT.TabIndex = 15;
            this.comboBoxChooseInLengthFPT.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseInLengthFPT_SelectedIndexChanged);
            // 
            // textBoxOutputVolumeFPT
            // 
            this.textBoxOutputVolumeFPT.Location = new System.Drawing.Point(250, 352);
            this.textBoxOutputVolumeFPT.Name = "textBoxOutputVolumeFPT";
            this.textBoxOutputVolumeFPT.Size = new System.Drawing.Size(121, 20);
            this.textBoxOutputVolumeFPT.TabIndex = 24;
            this.textBoxOutputVolumeFPT.TextChanged += new System.EventHandler(this.textBoxOutputVolumeFPT_TextChanged);
            // 
            // textBoxInputVolumeFPT
            // 
            this.textBoxInputVolumeFPT.Location = new System.Drawing.Point(12, 352);
            this.textBoxInputVolumeFPT.Name = "textBoxInputVolumeFPT";
            this.textBoxInputVolumeFPT.Size = new System.Drawing.Size(121, 20);
            this.textBoxInputVolumeFPT.TabIndex = 23;
            this.textBoxInputVolumeFPT.TextChanged += new System.EventHandler(this.textBoxInputVolumeFPT_TextChanged);
            // 
            // buttonCalculateVolumeFPT
            // 
            this.buttonCalculateVolumeFPT.BackColor = System.Drawing.Color.DarkGray;
            this.buttonCalculateVolumeFPT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCalculateVolumeFPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalculateVolumeFPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalculateVolumeFPT.Location = new System.Drawing.Point(155, 363);
            this.buttonCalculateVolumeFPT.Name = "buttonCalculateVolumeFPT";
            this.buttonCalculateVolumeFPT.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculateVolumeFPT.TabIndex = 22;
            this.buttonCalculateVolumeFPT.Text = "=";
            this.buttonCalculateVolumeFPT.UseVisualStyleBackColor = false;
            this.buttonCalculateVolumeFPT.Click += new System.EventHandler(this.buttonCalculateVolumeFPT_Click);
            // 
            // comboBoxChooseOutVolumeFPT
            // 
            this.comboBoxChooseOutVolumeFPT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxChooseOutVolumeFPT.FormattingEnabled = true;
            this.comboBoxChooseOutVolumeFPT.Items.AddRange(new object[] {
            "Литры (l)",
            "Миллилитры (ml)",
            "Галлоны (gal)",
            "Кубические метры (m3)"});
            this.comboBoxChooseOutVolumeFPT.Location = new System.Drawing.Point(251, 378);
            this.comboBoxChooseOutVolumeFPT.Name = "comboBoxChooseOutVolumeFPT";
            this.comboBoxChooseOutVolumeFPT.Size = new System.Drawing.Size(121, 21);
            this.comboBoxChooseOutVolumeFPT.TabIndex = 21;
            this.comboBoxChooseOutVolumeFPT.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseOutVolumeFPT_SelectedIndexChanged);
            // 
            // comboBoxChooseInVolumeFPT
            // 
            this.comboBoxChooseInVolumeFPT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxChooseInVolumeFPT.FormattingEnabled = true;
            this.comboBoxChooseInVolumeFPT.Items.AddRange(new object[] {
            "Литры (l)",
            "Миллилитры (ml)",
            "Галлоны (gal)",
            "Кубические метры (m3)"});
            this.comboBoxChooseInVolumeFPT.Location = new System.Drawing.Point(12, 378);
            this.comboBoxChooseInVolumeFPT.Name = "comboBoxChooseInVolumeFPT";
            this.comboBoxChooseInVolumeFPT.Size = new System.Drawing.Size(121, 21);
            this.comboBoxChooseInVolumeFPT.TabIndex = 20;
            this.comboBoxChooseInVolumeFPT.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseInVolumeFPT_SelectedIndexChanged);
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
            this.ToolStripFPT.Size = new System.Drawing.Size(384, 25);
            this.ToolStripFPT.TabIndex = 25;
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
            // ConversionFormFPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(384, 447);
            this.Controls.Add(this.ToolStripFPT);
            this.Controls.Add(this.textBoxOutputVolumeFPT);
            this.Controls.Add(this.textBoxInputVolumeFPT);
            this.Controls.Add(this.buttonCalculateVolumeFPT);
            this.Controls.Add(this.comboBoxChooseOutVolumeFPT);
            this.Controls.Add(this.comboBoxChooseInVolumeFPT);
            this.Controls.Add(this.textBoxOutputLengthFPT);
            this.Controls.Add(this.textBoxInputLengthFPT);
            this.Controls.Add(this.buttonCalculateLengthFPT);
            this.Controls.Add(this.comboBoxChooseOutLengthFPT);
            this.Controls.Add(this.comboBoxChooseInLengthFPT);
            this.Controls.Add(this.textBoxOutputWeightFPT);
            this.Controls.Add(this.textBoxInputWeightFPT);
            this.Controls.Add(this.buttonCalculateWeightFPT);
            this.Controls.Add(this.comboBoxChooseOutWeightFPT);
            this.Controls.Add(this.comboBoxChooseInWeightFPT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConversionFormFPT";
            this.Text = "Фомин П.Т. МКМб-22-1";
            this.ToolStripFPT.ResumeLayout(false);
            this.ToolStripFPT.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxChooseInWeightFPT;
        private System.Windows.Forms.ComboBox comboBoxChooseOutWeightFPT;
        private System.Windows.Forms.Button buttonCalculateWeightFPT;
        private System.Windows.Forms.TextBox textBoxInputWeightFPT;
        private System.Windows.Forms.TextBox textBoxOutputWeightFPT;
        private System.Windows.Forms.TextBox textBoxOutputLengthFPT;
        private System.Windows.Forms.TextBox textBoxInputLengthFPT;
        private System.Windows.Forms.Button buttonCalculateLengthFPT;
        private System.Windows.Forms.ComboBox comboBoxChooseOutLengthFPT;
        private System.Windows.Forms.ComboBox comboBoxChooseInLengthFPT;
        private System.Windows.Forms.TextBox textBoxOutputVolumeFPT;
        private System.Windows.Forms.TextBox textBoxInputVolumeFPT;
        private System.Windows.Forms.Button buttonCalculateVolumeFPT;
        private System.Windows.Forms.ComboBox comboBoxChooseOutVolumeFPT;
        private System.Windows.Forms.ComboBox comboBoxChooseInVolumeFPT;
        private System.Windows.Forms.ToolStrip ToolStripFPT;
        private System.Windows.Forms.ToolStripDropDownButton ToolStripButtonViewFPT;
        private System.Windows.Forms.ToolStripMenuItem OrdinaryTypeFPT;
        private System.Windows.Forms.ToolStripMenuItem ArithmeticTypeFPT;
        private System.Windows.Forms.ToolStripMenuItem UnitConversionTypeFPT;
        private System.Windows.Forms.ToolStripMenuItem FitnessTypeFPT;
        private System.Windows.Forms.ToolStripButton ToolStripAboutFPT;
    }
}