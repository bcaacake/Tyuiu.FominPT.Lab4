namespace Tyuiu.FominPT.Lab4
{
    partial class FitnessFormFPT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FitnessFormFPT));
            this.ToolStripAboutFPT = new System.Windows.Forms.ToolStripButton();
            this.UnitConversionTypeFPT = new System.Windows.Forms.ToolStripMenuItem();
            this.ArithmeticTypeFPT = new System.Windows.Forms.ToolStripMenuItem();
            this.OrdinaryTypeFPT = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripButtonViewFPT = new System.Windows.Forms.ToolStripDropDownButton();
            this.FitnessTypeFPT = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripFPT = new System.Windows.Forms.ToolStrip();
            this.textBoxEnterAgeFPT = new System.Windows.Forms.TextBox();
            this.buttonCalculateVolumeFPT = new System.Windows.Forms.Button();
            this.comboBoxChooseActivityLevelFPT = new System.Windows.Forms.ComboBox();
            this.textBoxEnterHeightFPT = new System.Windows.Forms.TextBox();
            this.textBoxEnterWeightFPT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButtonChooseGenderMaleFPT = new System.Windows.Forms.RadioButton();
            this.radioButtonChooseGenderFemaleFPT = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxShowResultFPT = new System.Windows.Forms.TextBox();
            this.ToolStripFPT.SuspendLayout();
            this.SuspendLayout();
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
            // UnitConversionTypeFPT
            // 
            this.UnitConversionTypeFPT.Name = "UnitConversionTypeFPT";
            this.UnitConversionTypeFPT.Size = new System.Drawing.Size(180, 22);
            this.UnitConversionTypeFPT.Text = "Перевод единиц";
            this.UnitConversionTypeFPT.Click += new System.EventHandler(this.UnitConversionTypeFPT_Click);
            // 
            // ArithmeticTypeFPT
            // 
            this.ArithmeticTypeFPT.Name = "ArithmeticTypeFPT";
            this.ArithmeticTypeFPT.Size = new System.Drawing.Size(180, 22);
            this.ArithmeticTypeFPT.Text = "Инженерный";
            this.ArithmeticTypeFPT.Click += new System.EventHandler(this.ArithmeticTypeFPT_Click);
            // 
            // OrdinaryTypeFPT
            // 
            this.OrdinaryTypeFPT.Name = "OrdinaryTypeFPT";
            this.OrdinaryTypeFPT.Size = new System.Drawing.Size(180, 22);
            this.OrdinaryTypeFPT.Text = "Обычный";
            this.OrdinaryTypeFPT.Click += new System.EventHandler(this.OrdinaryTypeFPT_Click);
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
            // FitnessTypeFPT
            // 
            this.FitnessTypeFPT.Name = "FitnessTypeFPT";
            this.FitnessTypeFPT.Size = new System.Drawing.Size(180, 22);
            this.FitnessTypeFPT.Text = "Фитнес ";
            this.FitnessTypeFPT.Click += new System.EventHandler(this.FitnessTypeFPT_Click);
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
            this.ToolStripFPT.Size = new System.Drawing.Size(454, 25);
            this.ToolStripFPT.TabIndex = 45;
            this.ToolStripFPT.Text = "toolStrip1";
            // 
            // textBoxEnterAgeFPT
            // 
            this.textBoxEnterAgeFPT.Location = new System.Drawing.Point(160, 221);
            this.textBoxEnterAgeFPT.Name = "textBoxEnterAgeFPT";
            this.textBoxEnterAgeFPT.Size = new System.Drawing.Size(121, 20);
            this.textBoxEnterAgeFPT.TabIndex = 43;
            // 
            // buttonCalculateVolumeFPT
            // 
            this.buttonCalculateVolumeFPT.BackColor = System.Drawing.Color.DarkGray;
            this.buttonCalculateVolumeFPT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCalculateVolumeFPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalculateVolumeFPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalculateVolumeFPT.Location = new System.Drawing.Point(169, 444);
            this.buttonCalculateVolumeFPT.Name = "buttonCalculateVolumeFPT";
            this.buttonCalculateVolumeFPT.Size = new System.Drawing.Size(95, 36);
            this.buttonCalculateVolumeFPT.TabIndex = 42;
            this.buttonCalculateVolumeFPT.Text = "Расчитать";
            this.buttonCalculateVolumeFPT.UseVisualStyleBackColor = false;
            this.buttonCalculateVolumeFPT.Click += new System.EventHandler(this.buttonCalculateVolumeFPT_Click);
            // 
            // comboBoxChooseActivityLevelFPT
            // 
            this.comboBoxChooseActivityLevelFPT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxChooseActivityLevelFPT.FormattingEnabled = true;
            this.comboBoxChooseActivityLevelFPT.Items.AddRange(new object[] {
            "Сидячий образ жизни",
            "Редкая физическая активность",
            "Активный образ жизни",
            "Профессионально занимаюсь спортом"});
            this.comboBoxChooseActivityLevelFPT.Location = new System.Drawing.Point(160, 402);
            this.comboBoxChooseActivityLevelFPT.Name = "comboBoxChooseActivityLevelFPT";
            this.comboBoxChooseActivityLevelFPT.Size = new System.Drawing.Size(121, 21);
            this.comboBoxChooseActivityLevelFPT.TabIndex = 41;
            // 
            // textBoxEnterHeightFPT
            // 
            this.textBoxEnterHeightFPT.Location = new System.Drawing.Point(160, 149);
            this.textBoxEnterHeightFPT.Name = "textBoxEnterHeightFPT";
            this.textBoxEnterHeightFPT.Size = new System.Drawing.Size(121, 20);
            this.textBoxEnterHeightFPT.TabIndex = 38;
            // 
            // textBoxEnterWeightFPT
            // 
            this.textBoxEnterWeightFPT.Location = new System.Drawing.Point(160, 80);
            this.textBoxEnterWeightFPT.Name = "textBoxEnterWeightFPT";
            this.textBoxEnterWeightFPT.Size = new System.Drawing.Size(121, 20);
            this.textBoxEnterWeightFPT.TabIndex = 33;
            this.textBoxEnterWeightFPT.TextChanged += new System.EventHandler(this.textBoxEnterWeightFPT_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(182, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Возраст";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(200, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Рост";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Перевод единиц измерения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(200, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Вес";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(197, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 46;
            this.label5.Text = "Пол";
            // 
            // radioButtonChooseGenderMaleFPT
            // 
            this.radioButtonChooseGenderMaleFPT.AutoSize = true;
            this.radioButtonChooseGenderMaleFPT.ForeColor = System.Drawing.Color.White;
            this.radioButtonChooseGenderMaleFPT.Location = new System.Drawing.Point(201, 298);
            this.radioButtonChooseGenderMaleFPT.Name = "radioButtonChooseGenderMaleFPT";
            this.radioButtonChooseGenderMaleFPT.Size = new System.Drawing.Size(34, 17);
            this.radioButtonChooseGenderMaleFPT.TabIndex = 47;
            this.radioButtonChooseGenderMaleFPT.TabStop = true;
            this.radioButtonChooseGenderMaleFPT.Text = "М";
            this.radioButtonChooseGenderMaleFPT.UseVisualStyleBackColor = true;
            // 
            // radioButtonChooseGenderFemaleFPT
            // 
            this.radioButtonChooseGenderFemaleFPT.AutoSize = true;
            this.radioButtonChooseGenderFemaleFPT.ForeColor = System.Drawing.Color.White;
            this.radioButtonChooseGenderFemaleFPT.Location = new System.Drawing.Point(201, 321);
            this.radioButtonChooseGenderFemaleFPT.Name = "radioButtonChooseGenderFemaleFPT";
            this.radioButtonChooseGenderFemaleFPT.Size = new System.Drawing.Size(36, 17);
            this.radioButtonChooseGenderFemaleFPT.TabIndex = 48;
            this.radioButtonChooseGenderFemaleFPT.TabStop = true;
            this.radioButtonChooseGenderFemaleFPT.Text = "Ж";
            this.radioButtonChooseGenderFemaleFPT.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(137, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 20);
            this.label6.TabIndex = 49;
            this.label6.Text = "Уровень активности";
            // 
            // textBoxShowResultFPT
            // 
            this.textBoxShowResultFPT.BackColor = System.Drawing.Color.Black;
            this.textBoxShowResultFPT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxShowResultFPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxShowResultFPT.ForeColor = System.Drawing.Color.White;
            this.textBoxShowResultFPT.Location = new System.Drawing.Point(24, 503);
            this.textBoxShowResultFPT.Multiline = true;
            this.textBoxShowResultFPT.Name = "textBoxShowResultFPT";
            this.textBoxShowResultFPT.ReadOnly = true;
            this.textBoxShowResultFPT.Size = new System.Drawing.Size(406, 146);
            this.textBoxShowResultFPT.TabIndex = 50;
            this.textBoxShowResultFPT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FitnessFormFPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(454, 661);
            this.Controls.Add(this.textBoxShowResultFPT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radioButtonChooseGenderFemaleFPT);
            this.Controls.Add(this.radioButtonChooseGenderMaleFPT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ToolStripFPT);
            this.Controls.Add(this.textBoxEnterAgeFPT);
            this.Controls.Add(this.buttonCalculateVolumeFPT);
            this.Controls.Add(this.comboBoxChooseActivityLevelFPT);
            this.Controls.Add(this.textBoxEnterHeightFPT);
            this.Controls.Add(this.textBoxEnterWeightFPT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FitnessFormFPT";
            this.Text = "Фомин П.Т. МКМб-22-1";
            this.ToolStripFPT.ResumeLayout(false);
            this.ToolStripFPT.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton ToolStripAboutFPT;
        private System.Windows.Forms.ToolStripMenuItem UnitConversionTypeFPT;
        private System.Windows.Forms.ToolStripMenuItem ArithmeticTypeFPT;
        private System.Windows.Forms.ToolStripMenuItem OrdinaryTypeFPT;
        private System.Windows.Forms.ToolStripDropDownButton ToolStripButtonViewFPT;
        private System.Windows.Forms.ToolStripMenuItem FitnessTypeFPT;
        private System.Windows.Forms.ToolStrip ToolStripFPT;
        private System.Windows.Forms.TextBox textBoxEnterAgeFPT;
        private System.Windows.Forms.Button buttonCalculateVolumeFPT;
        private System.Windows.Forms.ComboBox comboBoxChooseActivityLevelFPT;
        private System.Windows.Forms.TextBox textBoxEnterHeightFPT;
        private System.Windows.Forms.TextBox textBoxEnterWeightFPT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButtonChooseGenderMaleFPT;
        private System.Windows.Forms.RadioButton radioButtonChooseGenderFemaleFPT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxShowResultFPT;
    }
}