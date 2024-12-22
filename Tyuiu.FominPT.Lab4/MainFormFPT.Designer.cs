namespace Tyuiu.FominPT.Lab4
{
    partial class MainFormFPT
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormFPT));
            this.ToolStripFPT = new System.Windows.Forms.ToolStrip();
            this.ToolStripButtonViewFPT = new System.Windows.Forms.ToolStripDropDownButton();
            this.OrdinaryTypeFPT = new System.Windows.Forms.ToolStripMenuItem();
            this.ArithmeticTypeFPT = new System.Windows.Forms.ToolStripMenuItem();
            this.UnitConversionTypeFPT = new System.Windows.Forms.ToolStripMenuItem();
            this.FitnessTypeFPT = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripAboutFPT = new System.Windows.Forms.ToolStripButton();
            this.TextBoxDisplayFPT = new System.Windows.Forms.TextBox();
            this.CalculatorLayoutPanelFPT = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonEqualsFPT = new System.Windows.Forms.Button();
            this.ButtonDecimalFPT = new System.Windows.Forms.Button();
            this.ButtonNumberZeroFPT = new System.Windows.Forms.Button();
            this.ButtonNegateFPT = new System.Windows.Forms.Button();
            this.ButtonAddFPT = new System.Windows.Forms.Button();
            this.ButtonNumberThreeFPT = new System.Windows.Forms.Button();
            this.ButtonNumberTwoFPT = new System.Windows.Forms.Button();
            this.ButtonNumberOneFPT = new System.Windows.Forms.Button();
            this.ButtonSubtractFPT = new System.Windows.Forms.Button();
            this.ButtonPercentFPT = new System.Windows.Forms.Button();
            this.ButtonClearFPT = new System.Windows.Forms.Button();
            this.ButtonBackspaceFPT = new System.Windows.Forms.Button();
            this.ButtonReciprocalFPT = new System.Windows.Forms.Button();
            this.ButtonSquareFPT = new System.Windows.Forms.Button();
            this.ButtonSquareRootFPT = new System.Windows.Forms.Button();
            this.ButtonDivideFPT = new System.Windows.Forms.Button();
            this.ButtonNumberSevenFPT = new System.Windows.Forms.Button();
            this.ButtonNumberEightFPT = new System.Windows.Forms.Button();
            this.ButtonNumberNineFPT = new System.Windows.Forms.Button();
            this.ButtonMultiplyFPT = new System.Windows.Forms.Button();
            this.ButtonNumberFourFPT = new System.Windows.Forms.Button();
            this.ButtonNumberFiveFPT = new System.Windows.Forms.Button();
            this.ButtonNumberSixFPT = new System.Windows.Forms.Button();
            this.ToolStripFPT.SuspendLayout();
            this.CalculatorLayoutPanelFPT.SuspendLayout();
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
            this.ToolStripFPT.Size = new System.Drawing.Size(384, 25);
            this.ToolStripFPT.TabIndex = 0;
            this.ToolStripFPT.Text = "toolStrip1";
            this.ToolStripFPT.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ToolStripFPT_ItemClicked);
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
            this.ToolStripButtonViewFPT.Click += new System.EventHandler(this.ToolStripButtonViewFPT_Click);
            // 
            // OrdinaryTypeFPT
            // 
            this.OrdinaryTypeFPT.Name = "OrdinaryTypeFPT";
            this.OrdinaryTypeFPT.Size = new System.Drawing.Size(164, 22);
            this.OrdinaryTypeFPT.Text = "Обычный";
            this.OrdinaryTypeFPT.Click += new System.EventHandler(this.OrdinaryTypeFPT_Click);
            // 
            // ArithmeticTypeFPT
            // 
            this.ArithmeticTypeFPT.Name = "ArithmeticTypeFPT";
            this.ArithmeticTypeFPT.Size = new System.Drawing.Size(164, 22);
            this.ArithmeticTypeFPT.Text = "Инженерный";
            this.ArithmeticTypeFPT.Click += new System.EventHandler(this.ArithmeticTypeFPT_Click);
            // 
            // UnitConversionTypeFPT
            // 
            this.UnitConversionTypeFPT.Name = "UnitConversionTypeFPT";
            this.UnitConversionTypeFPT.Size = new System.Drawing.Size(164, 22);
            this.UnitConversionTypeFPT.Text = "Перевод единиц";
            this.UnitConversionTypeFPT.Click += new System.EventHandler(this.UnitConversionTypeFPT_Click);
            // 
            // FitnessTypeFPT
            // 
            this.FitnessTypeFPT.Name = "FitnessTypeFPT";
            this.FitnessTypeFPT.Size = new System.Drawing.Size(164, 22);
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
            // TextBoxDisplayFPT
            // 
            this.TextBoxDisplayFPT.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TextBoxDisplayFPT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxDisplayFPT.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextBoxDisplayFPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxDisplayFPT.ForeColor = System.Drawing.Color.White;
            this.TextBoxDisplayFPT.Location = new System.Drawing.Point(0, 25);
            this.TextBoxDisplayFPT.Multiline = true;
            this.TextBoxDisplayFPT.Name = "TextBoxDisplayFPT";
            this.TextBoxDisplayFPT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TextBoxDisplayFPT.Size = new System.Drawing.Size(384, 94);
            this.TextBoxDisplayFPT.TabIndex = 1;
            this.TextBoxDisplayFPT.Text = "0";
            this.TextBoxDisplayFPT.TextChanged += new System.EventHandler(this.TextBoxDisplayFPT_TextChanged);
            // 
            // CalculatorLayoutPanelFPT
            // 
            this.CalculatorLayoutPanelFPT.ColumnCount = 4;
            this.CalculatorLayoutPanelFPT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorLayoutPanelFPT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorLayoutPanelFPT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorLayoutPanelFPT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorLayoutPanelFPT.Controls.Add(this.ButtonEqualsFPT, 3, 5);
            this.CalculatorLayoutPanelFPT.Controls.Add(this.ButtonDecimalFPT, 2, 5);
            this.CalculatorLayoutPanelFPT.Controls.Add(this.ButtonNumberZeroFPT, 1, 5);
            this.CalculatorLayoutPanelFPT.Controls.Add(this.ButtonNegateFPT, 0, 5);
            this.CalculatorLayoutPanelFPT.Controls.Add(this.ButtonAddFPT, 3, 4);
            this.CalculatorLayoutPanelFPT.Controls.Add(this.ButtonNumberThreeFPT, 2, 4);
            this.CalculatorLayoutPanelFPT.Controls.Add(this.ButtonNumberTwoFPT, 1, 4);
            this.CalculatorLayoutPanelFPT.Controls.Add(this.ButtonNumberOneFPT, 0, 4);
            this.CalculatorLayoutPanelFPT.Controls.Add(this.ButtonSubtractFPT, 3, 3);
            this.CalculatorLayoutPanelFPT.Controls.Add(this.ButtonPercentFPT, 0, 0);
            this.CalculatorLayoutPanelFPT.Controls.Add(this.ButtonClearFPT, 1, 0);
            this.CalculatorLayoutPanelFPT.Controls.Add(this.ButtonBackspaceFPT, 2, 0);
            this.CalculatorLayoutPanelFPT.Controls.Add(this.ButtonReciprocalFPT, 0, 1);
            this.CalculatorLayoutPanelFPT.Controls.Add(this.ButtonSquareFPT, 1, 1);
            this.CalculatorLayoutPanelFPT.Controls.Add(this.ButtonSquareRootFPT, 2, 1);
            this.CalculatorLayoutPanelFPT.Controls.Add(this.ButtonDivideFPT, 3, 1);
            this.CalculatorLayoutPanelFPT.Controls.Add(this.ButtonNumberSevenFPT, 0, 2);
            this.CalculatorLayoutPanelFPT.Controls.Add(this.ButtonNumberEightFPT, 1, 2);
            this.CalculatorLayoutPanelFPT.Controls.Add(this.ButtonNumberNineFPT, 2, 2);
            this.CalculatorLayoutPanelFPT.Controls.Add(this.ButtonMultiplyFPT, 3, 2);
            this.CalculatorLayoutPanelFPT.Controls.Add(this.ButtonNumberFourFPT, 0, 3);
            this.CalculatorLayoutPanelFPT.Controls.Add(this.ButtonNumberFiveFPT, 1, 3);
            this.CalculatorLayoutPanelFPT.Controls.Add(this.ButtonNumberSixFPT, 2, 3);
            this.CalculatorLayoutPanelFPT.Cursor = System.Windows.Forms.Cursors.Default;
            this.CalculatorLayoutPanelFPT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CalculatorLayoutPanelFPT.Location = new System.Drawing.Point(0, 119);
            this.CalculatorLayoutPanelFPT.Name = "CalculatorLayoutPanelFPT";
            this.CalculatorLayoutPanelFPT.RowCount = 6;
            this.CalculatorLayoutPanelFPT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.CalculatorLayoutPanelFPT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.CalculatorLayoutPanelFPT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.CalculatorLayoutPanelFPT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.CalculatorLayoutPanelFPT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.CalculatorLayoutPanelFPT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.CalculatorLayoutPanelFPT.Size = new System.Drawing.Size(384, 392);
            this.CalculatorLayoutPanelFPT.TabIndex = 2;
            this.CalculatorLayoutPanelFPT.Paint += new System.Windows.Forms.PaintEventHandler(this.CalculatorLayoutPanelFPT_Paint);
            // 
            // ButtonEqualsFPT
            // 
            this.ButtonEqualsFPT.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ButtonEqualsFPT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonEqualsFPT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonEqualsFPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEqualsFPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonEqualsFPT.Location = new System.Drawing.Point(291, 328);
            this.ButtonEqualsFPT.Name = "ButtonEqualsFPT";
            this.ButtonEqualsFPT.Size = new System.Drawing.Size(90, 61);
            this.ButtonEqualsFPT.TabIndex = 23;
            this.ButtonEqualsFPT.Text = "=";
            this.ButtonEqualsFPT.UseVisualStyleBackColor = false;
            this.ButtonEqualsFPT.Click += new System.EventHandler(this.ButtonEqualsFPT_Click);
            // 
            // ButtonDecimalFPT
            // 
            this.ButtonDecimalFPT.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ButtonDecimalFPT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDecimalFPT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonDecimalFPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDecimalFPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonDecimalFPT.Location = new System.Drawing.Point(195, 328);
            this.ButtonDecimalFPT.Name = "ButtonDecimalFPT";
            this.ButtonDecimalFPT.Size = new System.Drawing.Size(90, 61);
            this.ButtonDecimalFPT.TabIndex = 22;
            this.ButtonDecimalFPT.Text = ",";
            this.ButtonDecimalFPT.UseVisualStyleBackColor = false;
            this.ButtonDecimalFPT.Click += new System.EventHandler(this.ButtonDecimalFPT_Click);
            // 
            // ButtonNumberZeroFPT
            // 
            this.ButtonNumberZeroFPT.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ButtonNumberZeroFPT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonNumberZeroFPT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonNumberZeroFPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNumberZeroFPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonNumberZeroFPT.Location = new System.Drawing.Point(99, 328);
            this.ButtonNumberZeroFPT.Name = "ButtonNumberZeroFPT";
            this.ButtonNumberZeroFPT.Size = new System.Drawing.Size(90, 61);
            this.ButtonNumberZeroFPT.TabIndex = 21;
            this.ButtonNumberZeroFPT.Text = "0";
            this.ButtonNumberZeroFPT.UseVisualStyleBackColor = false;
            this.ButtonNumberZeroFPT.Click += new System.EventHandler(this.ButtonNumberZeroFPT_Click);
            // 
            // ButtonNegateFPT
            // 
            this.ButtonNegateFPT.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ButtonNegateFPT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonNegateFPT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonNegateFPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNegateFPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonNegateFPT.Location = new System.Drawing.Point(3, 328);
            this.ButtonNegateFPT.Name = "ButtonNegateFPT";
            this.ButtonNegateFPT.Size = new System.Drawing.Size(90, 61);
            this.ButtonNegateFPT.TabIndex = 20;
            this.ButtonNegateFPT.Text = "+/-";
            this.ButtonNegateFPT.UseVisualStyleBackColor = false;
            this.ButtonNegateFPT.Click += new System.EventHandler(this.ButtonNegateFPT_Click);
            // 
            // ButtonAddFPT
            // 
            this.ButtonAddFPT.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ButtonAddFPT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAddFPT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonAddFPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddFPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAddFPT.Location = new System.Drawing.Point(291, 263);
            this.ButtonAddFPT.Name = "ButtonAddFPT";
            this.ButtonAddFPT.Size = new System.Drawing.Size(90, 59);
            this.ButtonAddFPT.TabIndex = 19;
            this.ButtonAddFPT.Text = "+";
            this.ButtonAddFPT.UseVisualStyleBackColor = false;
            this.ButtonAddFPT.Click += new System.EventHandler(this.ButtonAddFPT_Click);
            // 
            // ButtonNumberThreeFPT
            // 
            this.ButtonNumberThreeFPT.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ButtonNumberThreeFPT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonNumberThreeFPT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonNumberThreeFPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNumberThreeFPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonNumberThreeFPT.Location = new System.Drawing.Point(195, 263);
            this.ButtonNumberThreeFPT.Name = "ButtonNumberThreeFPT";
            this.ButtonNumberThreeFPT.Size = new System.Drawing.Size(90, 59);
            this.ButtonNumberThreeFPT.TabIndex = 18;
            this.ButtonNumberThreeFPT.Text = "3";
            this.ButtonNumberThreeFPT.UseVisualStyleBackColor = false;
            this.ButtonNumberThreeFPT.Click += new System.EventHandler(this.ButtonNumberThreeFPT_Click);
            // 
            // ButtonNumberTwoFPT
            // 
            this.ButtonNumberTwoFPT.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ButtonNumberTwoFPT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonNumberTwoFPT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonNumberTwoFPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNumberTwoFPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonNumberTwoFPT.Location = new System.Drawing.Point(99, 263);
            this.ButtonNumberTwoFPT.Name = "ButtonNumberTwoFPT";
            this.ButtonNumberTwoFPT.Size = new System.Drawing.Size(90, 59);
            this.ButtonNumberTwoFPT.TabIndex = 17;
            this.ButtonNumberTwoFPT.Text = "2";
            this.ButtonNumberTwoFPT.UseVisualStyleBackColor = false;
            this.ButtonNumberTwoFPT.Click += new System.EventHandler(this.ButtonNumberTwoFPT_Click);
            // 
            // ButtonNumberOneFPT
            // 
            this.ButtonNumberOneFPT.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ButtonNumberOneFPT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonNumberOneFPT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonNumberOneFPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNumberOneFPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonNumberOneFPT.Location = new System.Drawing.Point(3, 263);
            this.ButtonNumberOneFPT.Name = "ButtonNumberOneFPT";
            this.ButtonNumberOneFPT.Size = new System.Drawing.Size(90, 59);
            this.ButtonNumberOneFPT.TabIndex = 16;
            this.ButtonNumberOneFPT.Text = "1";
            this.ButtonNumberOneFPT.UseVisualStyleBackColor = false;
            this.ButtonNumberOneFPT.Click += new System.EventHandler(this.ButtonNumberOneFPT_Click);
            // 
            // ButtonSubtractFPT
            // 
            this.ButtonSubtractFPT.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ButtonSubtractFPT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSubtractFPT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonSubtractFPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSubtractFPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSubtractFPT.Location = new System.Drawing.Point(291, 198);
            this.ButtonSubtractFPT.Name = "ButtonSubtractFPT";
            this.ButtonSubtractFPT.Size = new System.Drawing.Size(90, 59);
            this.ButtonSubtractFPT.TabIndex = 15;
            this.ButtonSubtractFPT.Text = "—";
            this.ButtonSubtractFPT.UseVisualStyleBackColor = false;
            this.ButtonSubtractFPT.Click += new System.EventHandler(this.ButtonSubtractFPT_Click);
            // 
            // ButtonPercentFPT
            // 
            this.ButtonPercentFPT.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ButtonPercentFPT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonPercentFPT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonPercentFPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPercentFPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonPercentFPT.Location = new System.Drawing.Point(3, 3);
            this.ButtonPercentFPT.Name = "ButtonPercentFPT";
            this.ButtonPercentFPT.Size = new System.Drawing.Size(90, 59);
            this.ButtonPercentFPT.TabIndex = 0;
            this.ButtonPercentFPT.Text = "%";
            this.ButtonPercentFPT.UseVisualStyleBackColor = false;
            this.ButtonPercentFPT.Click += new System.EventHandler(this.ButtonPercentFPT_Click);
            // 
            // ButtonClearFPT
            // 
            this.ButtonClearFPT.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ButtonClearFPT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonClearFPT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonClearFPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClearFPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonClearFPT.Location = new System.Drawing.Point(99, 3);
            this.ButtonClearFPT.Name = "ButtonClearFPT";
            this.ButtonClearFPT.Size = new System.Drawing.Size(90, 59);
            this.ButtonClearFPT.TabIndex = 1;
            this.ButtonClearFPT.Text = "С";
            this.ButtonClearFPT.UseVisualStyleBackColor = false;
            this.ButtonClearFPT.Click += new System.EventHandler(this.ButtonClearFPT_Click);
            // 
            // ButtonBackspaceFPT
            // 
            this.ButtonBackspaceFPT.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CalculatorLayoutPanelFPT.SetColumnSpan(this.ButtonBackspaceFPT, 2);
            this.ButtonBackspaceFPT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonBackspaceFPT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonBackspaceFPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBackspaceFPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonBackspaceFPT.Location = new System.Drawing.Point(195, 3);
            this.ButtonBackspaceFPT.Name = "ButtonBackspaceFPT";
            this.ButtonBackspaceFPT.Size = new System.Drawing.Size(186, 59);
            this.ButtonBackspaceFPT.TabIndex = 2;
            this.ButtonBackspaceFPT.Text = "←";
            this.ButtonBackspaceFPT.UseVisualStyleBackColor = false;
            this.ButtonBackspaceFPT.Click += new System.EventHandler(this.ButtonBackspaceFPT_Click);
            // 
            // ButtonReciprocalFPT
            // 
            this.ButtonReciprocalFPT.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ButtonReciprocalFPT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonReciprocalFPT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonReciprocalFPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonReciprocalFPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonReciprocalFPT.Location = new System.Drawing.Point(3, 68);
            this.ButtonReciprocalFPT.Name = "ButtonReciprocalFPT";
            this.ButtonReciprocalFPT.Size = new System.Drawing.Size(90, 59);
            this.ButtonReciprocalFPT.TabIndex = 4;
            this.ButtonReciprocalFPT.Text = "1/x";
            this.ButtonReciprocalFPT.UseVisualStyleBackColor = false;
            this.ButtonReciprocalFPT.Click += new System.EventHandler(this.ButtonReciprocalFPT_Click);
            // 
            // ButtonSquareFPT
            // 
            this.ButtonSquareFPT.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ButtonSquareFPT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSquareFPT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonSquareFPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSquareFPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSquareFPT.Location = new System.Drawing.Point(99, 68);
            this.ButtonSquareFPT.Name = "ButtonSquareFPT";
            this.ButtonSquareFPT.Size = new System.Drawing.Size(90, 59);
            this.ButtonSquareFPT.TabIndex = 5;
            this.ButtonSquareFPT.Text = "x²";
            this.ButtonSquareFPT.UseVisualStyleBackColor = false;
            this.ButtonSquareFPT.Click += new System.EventHandler(this.ButtonSquareFPT_Click);
            // 
            // ButtonSquareRootFPT
            // 
            this.ButtonSquareRootFPT.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ButtonSquareRootFPT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSquareRootFPT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonSquareRootFPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSquareRootFPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSquareRootFPT.Location = new System.Drawing.Point(195, 68);
            this.ButtonSquareRootFPT.Name = "ButtonSquareRootFPT";
            this.ButtonSquareRootFPT.Size = new System.Drawing.Size(90, 59);
            this.ButtonSquareRootFPT.TabIndex = 6;
            this.ButtonSquareRootFPT.Text = "²√x";
            this.ButtonSquareRootFPT.UseVisualStyleBackColor = false;
            this.ButtonSquareRootFPT.Click += new System.EventHandler(this.ButtonSquareRootFPT_Click);
            // 
            // ButtonDivideFPT
            // 
            this.ButtonDivideFPT.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ButtonDivideFPT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDivideFPT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonDivideFPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDivideFPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonDivideFPT.Location = new System.Drawing.Point(291, 68);
            this.ButtonDivideFPT.Name = "ButtonDivideFPT";
            this.ButtonDivideFPT.Size = new System.Drawing.Size(90, 59);
            this.ButtonDivideFPT.TabIndex = 7;
            this.ButtonDivideFPT.Text = "÷";
            this.ButtonDivideFPT.UseVisualStyleBackColor = false;
            this.ButtonDivideFPT.Click += new System.EventHandler(this.ButtonDivideFPT_Click);
            // 
            // ButtonNumberSevenFPT
            // 
            this.ButtonNumberSevenFPT.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ButtonNumberSevenFPT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonNumberSevenFPT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonNumberSevenFPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNumberSevenFPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonNumberSevenFPT.Location = new System.Drawing.Point(3, 133);
            this.ButtonNumberSevenFPT.Name = "ButtonNumberSevenFPT";
            this.ButtonNumberSevenFPT.Size = new System.Drawing.Size(90, 59);
            this.ButtonNumberSevenFPT.TabIndex = 8;
            this.ButtonNumberSevenFPT.Text = "7";
            this.ButtonNumberSevenFPT.UseVisualStyleBackColor = false;
            this.ButtonNumberSevenFPT.Click += new System.EventHandler(this.ButtonNumberSevenFPT_Click);
            // 
            // ButtonNumberEightFPT
            // 
            this.ButtonNumberEightFPT.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ButtonNumberEightFPT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonNumberEightFPT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonNumberEightFPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNumberEightFPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonNumberEightFPT.Location = new System.Drawing.Point(99, 133);
            this.ButtonNumberEightFPT.Name = "ButtonNumberEightFPT";
            this.ButtonNumberEightFPT.Size = new System.Drawing.Size(90, 59);
            this.ButtonNumberEightFPT.TabIndex = 9;
            this.ButtonNumberEightFPT.Text = "8";
            this.ButtonNumberEightFPT.UseVisualStyleBackColor = false;
            this.ButtonNumberEightFPT.Click += new System.EventHandler(this.ButtonNumberEightFPT_Click);
            // 
            // ButtonNumberNineFPT
            // 
            this.ButtonNumberNineFPT.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ButtonNumberNineFPT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonNumberNineFPT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonNumberNineFPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNumberNineFPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonNumberNineFPT.Location = new System.Drawing.Point(195, 133);
            this.ButtonNumberNineFPT.Name = "ButtonNumberNineFPT";
            this.ButtonNumberNineFPT.Size = new System.Drawing.Size(90, 59);
            this.ButtonNumberNineFPT.TabIndex = 10;
            this.ButtonNumberNineFPT.Text = "9";
            this.ButtonNumberNineFPT.UseVisualStyleBackColor = false;
            this.ButtonNumberNineFPT.Click += new System.EventHandler(this.ButtonNumberNineFPT_Click);
            // 
            // ButtonMultiplyFPT
            // 
            this.ButtonMultiplyFPT.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ButtonMultiplyFPT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonMultiplyFPT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonMultiplyFPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMultiplyFPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonMultiplyFPT.Location = new System.Drawing.Point(291, 133);
            this.ButtonMultiplyFPT.Name = "ButtonMultiplyFPT";
            this.ButtonMultiplyFPT.Size = new System.Drawing.Size(90, 59);
            this.ButtonMultiplyFPT.TabIndex = 11;
            this.ButtonMultiplyFPT.Text = "×";
            this.ButtonMultiplyFPT.UseVisualStyleBackColor = false;
            this.ButtonMultiplyFPT.Click += new System.EventHandler(this.ButtonMultiplyFPT_Click);
            // 
            // ButtonNumberFourFPT
            // 
            this.ButtonNumberFourFPT.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ButtonNumberFourFPT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonNumberFourFPT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonNumberFourFPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNumberFourFPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonNumberFourFPT.Location = new System.Drawing.Point(3, 198);
            this.ButtonNumberFourFPT.Name = "ButtonNumberFourFPT";
            this.ButtonNumberFourFPT.Size = new System.Drawing.Size(90, 59);
            this.ButtonNumberFourFPT.TabIndex = 12;
            this.ButtonNumberFourFPT.Text = "4";
            this.ButtonNumberFourFPT.UseVisualStyleBackColor = false;
            this.ButtonNumberFourFPT.Click += new System.EventHandler(this.ButtonNumberFourFPT_Click);
            // 
            // ButtonNumberFiveFPT
            // 
            this.ButtonNumberFiveFPT.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ButtonNumberFiveFPT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonNumberFiveFPT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonNumberFiveFPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNumberFiveFPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonNumberFiveFPT.Location = new System.Drawing.Point(99, 198);
            this.ButtonNumberFiveFPT.Name = "ButtonNumberFiveFPT";
            this.ButtonNumberFiveFPT.Size = new System.Drawing.Size(90, 59);
            this.ButtonNumberFiveFPT.TabIndex = 13;
            this.ButtonNumberFiveFPT.Text = "5";
            this.ButtonNumberFiveFPT.UseVisualStyleBackColor = false;
            this.ButtonNumberFiveFPT.Click += new System.EventHandler(this.ButtonNumberFiveFPT_Click);
            // 
            // ButtonNumberSixFPT
            // 
            this.ButtonNumberSixFPT.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ButtonNumberSixFPT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonNumberSixFPT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonNumberSixFPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNumberSixFPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonNumberSixFPT.Location = new System.Drawing.Point(195, 198);
            this.ButtonNumberSixFPT.Name = "ButtonNumberSixFPT";
            this.ButtonNumberSixFPT.Size = new System.Drawing.Size(90, 59);
            this.ButtonNumberSixFPT.TabIndex = 14;
            this.ButtonNumberSixFPT.Text = "6";
            this.ButtonNumberSixFPT.UseVisualStyleBackColor = false;
            this.ButtonNumberSixFPT.Click += new System.EventHandler(this.ButtonNumberSixFPT_Click);
            // 
            // MainFormFPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(384, 511);
            this.Controls.Add(this.CalculatorLayoutPanelFPT);
            this.Controls.Add(this.TextBoxDisplayFPT);
            this.Controls.Add(this.ToolStripFPT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFormFPT";
            this.Text = "Фомин П.Т. МКМб-22-1";
            this.ToolStripFPT.ResumeLayout(false);
            this.ToolStripFPT.PerformLayout();
            this.CalculatorLayoutPanelFPT.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox TextBoxDisplayFPT;
        private System.Windows.Forms.TableLayoutPanel CalculatorLayoutPanelFPT;
        private System.Windows.Forms.Button ButtonEqualsFPT;
        private System.Windows.Forms.Button ButtonDecimalFPT;
        private System.Windows.Forms.Button ButtonNumberZeroFPT;
        private System.Windows.Forms.Button ButtonNegateFPT;
        private System.Windows.Forms.Button ButtonAddFPT;
        private System.Windows.Forms.Button ButtonNumberThreeFPT;
        private System.Windows.Forms.Button ButtonNumberTwoFPT;
        private System.Windows.Forms.Button ButtonNumberOneFPT;
        private System.Windows.Forms.Button ButtonSubtractFPT;
        private System.Windows.Forms.Button ButtonPercentFPT;
        private System.Windows.Forms.Button ButtonClearFPT;
        private System.Windows.Forms.Button ButtonBackspaceFPT;
        private System.Windows.Forms.Button ButtonReciprocalFPT;
        private System.Windows.Forms.Button ButtonSquareFPT;
        private System.Windows.Forms.Button ButtonSquareRootFPT;
        private System.Windows.Forms.Button ButtonDivideFPT;
        private System.Windows.Forms.Button ButtonNumberSevenFPT;
        private System.Windows.Forms.Button ButtonNumberEightFPT;
        private System.Windows.Forms.Button ButtonNumberNineFPT;
        private System.Windows.Forms.Button ButtonMultiplyFPT;
        private System.Windows.Forms.Button ButtonNumberFourFPT;
        private System.Windows.Forms.Button ButtonNumberFiveFPT;
        private System.Windows.Forms.Button ButtonNumberSixFPT;
    }
}

