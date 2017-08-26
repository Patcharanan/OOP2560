namespace CSharpBasic
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textMaximum = new System.Windows.Forms.TextBox();
            this.textMinimum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textSize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTpye = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textType = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btnfloat = new System.Windows.Forms.Button();
            this.BtnLong = new System.Windows.Forms.Button();
            this.BtnSbyte = new System.Windows.Forms.Button();
            this.BtnUInt16 = new System.Windows.Forms.Button();
            this.BtnChar = new System.Windows.Forms.Button();
            this.BtnBool = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BtnByte = new System.Windows.Forms.Button();
            this.BtnShort = new System.Windows.Forms.Button();
            this.BtnUshort = new System.Windows.Forms.Button();
            this.BtnInt = new System.Windows.Forms.Button();
            this.BtnUint32 = new System.Windows.Forms.Button();
            this.BtnUlong = new System.Windows.Forms.Button();
            this.BtnDouble = new System.Windows.Forms.Button();
            this.BtnDecimal = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1380, 765);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1372, 732);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Value Type";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textMaximum);
            this.groupBox2.Controls.Add(this.textMinimum);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textSize);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtTpye);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textType);
            this.groupBox2.Location = new System.Drawing.Point(303, 9);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(468, 203);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Max";
            // 
            // textMaximum
            // 
            this.textMaximum.Location = new System.Drawing.Point(68, 149);
            this.textMaximum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textMaximum.Name = "textMaximum";
            this.textMaximum.Size = new System.Drawing.Size(274, 26);
            this.textMaximum.TabIndex = 10;
            // 
            // textMinimum
            // 
            this.textMinimum.Location = new System.Drawing.Point(68, 109);
            this.textMinimum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textMinimum.Name = "textMinimum";
            this.textMinimum.Size = new System.Drawing.Size(274, 26);
            this.textMinimum.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 114);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Min";
            // 
            // textSize
            // 
            this.textSize.Location = new System.Drawing.Point(68, 69);
            this.textSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textSize.Name = "textSize";
            this.textSize.Size = new System.Drawing.Size(148, 26);
            this.textSize.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Byte(s)";
            // 
            // txtTpye
            // 
            this.txtTpye.AutoSize = true;
            this.txtTpye.Location = new System.Drawing.Point(20, 34);
            this.txtTpye.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTpye.Name = "txtTpye";
            this.txtTpye.Size = new System.Drawing.Size(43, 20);
            this.txtTpye.TabIndex = 4;
            this.txtTpye.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Size";
            // 
            // textType
            // 
            this.textType.Location = new System.Drawing.Point(69, 29);
            this.textType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textType.Name = "textType";
            this.textType.Size = new System.Drawing.Size(148, 26);
            this.textType.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnDecimal);
            this.groupBox1.Controls.Add(this.BtnDouble);
            this.groupBox1.Controls.Add(this.BtnUlong);
            this.groupBox1.Controls.Add(this.BtnUint32);
            this.groupBox1.Controls.Add(this.BtnInt);
            this.groupBox1.Controls.Add(this.BtnUshort);
            this.groupBox1.Controls.Add(this.BtnShort);
            this.groupBox1.Controls.Add(this.BtnByte);
            this.groupBox1.Controls.Add(this.Btnfloat);
            this.groupBox1.Controls.Add(this.BtnLong);
            this.groupBox1.Controls.Add(this.BtnSbyte);
            this.groupBox1.Controls.Add(this.BtnUInt16);
            this.groupBox1.Controls.Add(this.BtnChar);
            this.groupBox1.Controls.Add(this.BtnBool);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(268, 667);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Button";
            // 
            // Btnfloat
            // 
            this.Btnfloat.Location = new System.Drawing.Point(53, 505);
            this.Btnfloat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btnfloat.Name = "Btnfloat";
            this.Btnfloat.Size = new System.Drawing.Size(159, 35);
            this.Btnfloat.TabIndex = 4;
            this.Btnfloat.Text = "float";
            this.Btnfloat.UseVisualStyleBackColor = true;
            this.Btnfloat.Click += new System.EventHandler(this.Btnfloat_Click);
            // 
            // BtnLong
            // 
            this.BtnLong.Location = new System.Drawing.Point(53, 374);
            this.BtnLong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnLong.Name = "BtnLong";
            this.BtnLong.Size = new System.Drawing.Size(159, 35);
            this.BtnLong.TabIndex = 4;
            this.BtnLong.Text = "Long";
            this.BtnLong.UseVisualStyleBackColor = true;
            this.BtnLong.Click += new System.EventHandler(this.BtnLong_Click);
            // 
            // BtnSbyte
            // 
            this.BtnSbyte.Location = new System.Drawing.Point(53, 79);
            this.BtnSbyte.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSbyte.Name = "BtnSbyte";
            this.BtnSbyte.Size = new System.Drawing.Size(159, 35);
            this.BtnSbyte.TabIndex = 3;
            this.BtnSbyte.Text = "Sbyte";
            this.BtnSbyte.UseVisualStyleBackColor = true;
            this.BtnSbyte.Click += new System.EventHandler(this.BtnSbyte_Click);
            // 
            // BtnUInt16
            // 
            this.BtnUInt16.Location = new System.Drawing.Point(53, 288);
            this.BtnUInt16.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnUInt16.Name = "BtnUInt16";
            this.BtnUInt16.Size = new System.Drawing.Size(159, 35);
            this.BtnUInt16.TabIndex = 2;
            this.BtnUInt16.Text = "UInt16";
            this.BtnUInt16.UseVisualStyleBackColor = true;
            this.BtnUInt16.Click += new System.EventHandler(this.BtnUInt16_Click);
            // 
            // BtnChar
            // 
            this.BtnChar.Location = new System.Drawing.Point(53, 460);
            this.BtnChar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnChar.Name = "BtnChar";
            this.BtnChar.Size = new System.Drawing.Size(159, 35);
            this.BtnChar.TabIndex = 1;
            this.BtnChar.Text = "char";
            this.BtnChar.UseVisualStyleBackColor = true;
            this.BtnChar.Click += new System.EventHandler(this.BtnChar_Click);
            // 
            // BtnBool
            // 
            this.BtnBool.Location = new System.Drawing.Point(53, 34);
            this.BtnBool.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnBool.Name = "BtnBool";
            this.BtnBool.Size = new System.Drawing.Size(159, 35);
            this.BtnBool.TabIndex = 0;
            this.BtnBool.Text = "Bool";
            this.BtnBool.UseVisualStyleBackColor = true;
            this.BtnBool.Click += new System.EventHandler(this.BtnBool_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1372, 732);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "If";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BtnByte
            // 
            this.BtnByte.Location = new System.Drawing.Point(53, 122);
            this.BtnByte.Name = "BtnByte";
            this.BtnByte.Size = new System.Drawing.Size(159, 35);
            this.BtnByte.TabIndex = 5;
            this.BtnByte.Text = "Byte";
            this.BtnByte.UseVisualStyleBackColor = true;
            this.BtnByte.Click += new System.EventHandler(this.BtnByte_Click);
            // 
            // BtnShort
            // 
            this.BtnShort.Location = new System.Drawing.Point(53, 163);
            this.BtnShort.Name = "BtnShort";
            this.BtnShort.Size = new System.Drawing.Size(159, 35);
            this.BtnShort.TabIndex = 6;
            this.BtnShort.Text = "Short";
            this.BtnShort.UseVisualStyleBackColor = true;
            this.BtnShort.Click += new System.EventHandler(this.BtnShort_Click);
            // 
            // BtnUshort
            // 
            this.BtnUshort.Location = new System.Drawing.Point(53, 204);
            this.BtnUshort.Name = "BtnUshort";
            this.BtnUshort.Size = new System.Drawing.Size(159, 35);
            this.BtnUshort.TabIndex = 7;
            this.BtnUshort.Text = "ushort";
            this.BtnUshort.UseVisualStyleBackColor = true;
            this.BtnUshort.Click += new System.EventHandler(this.BtnUshort_Click);
            // 
            // BtnInt
            // 
            this.BtnInt.Location = new System.Drawing.Point(53, 245);
            this.BtnInt.Name = "BtnInt";
            this.BtnInt.Size = new System.Drawing.Size(159, 35);
            this.BtnInt.TabIndex = 8;
            this.BtnInt.Text = "Int";
            this.BtnInt.UseVisualStyleBackColor = true;
            this.BtnInt.Click += new System.EventHandler(this.BtnInt_Click);
            // 
            // BtnUint32
            // 
            this.BtnUint32.Location = new System.Drawing.Point(53, 331);
            this.BtnUint32.Name = "BtnUint32";
            this.BtnUint32.Size = new System.Drawing.Size(159, 35);
            this.BtnUint32.TabIndex = 9;
            this.BtnUint32.Text = "Uint32";
            this.BtnUint32.UseVisualStyleBackColor = true;
            this.BtnUint32.Click += new System.EventHandler(this.BtnUint32_Click);
            // 
            // BtnUlong
            // 
            this.BtnUlong.Location = new System.Drawing.Point(53, 417);
            this.BtnUlong.Name = "BtnUlong";
            this.BtnUlong.Size = new System.Drawing.Size(159, 35);
            this.BtnUlong.TabIndex = 10;
            this.BtnUlong.Text = "Ulong";
            this.BtnUlong.UseVisualStyleBackColor = true;
            this.BtnUlong.Click += new System.EventHandler(this.BtnUlong_Click);
            // 
            // BtnDouble
            // 
            this.BtnDouble.Location = new System.Drawing.Point(53, 548);
            this.BtnDouble.Name = "BtnDouble";
            this.BtnDouble.Size = new System.Drawing.Size(159, 35);
            this.BtnDouble.TabIndex = 11;
            this.BtnDouble.Text = "Double";
            this.BtnDouble.UseVisualStyleBackColor = true;
            this.BtnDouble.Click += new System.EventHandler(this.BtnDouble_Click);
            // 
            // BtnDecimal
            // 
            this.BtnDecimal.Location = new System.Drawing.Point(53, 589);
            this.BtnDecimal.Name = "BtnDecimal";
            this.BtnDecimal.Size = new System.Drawing.Size(159, 35);
            this.BtnDecimal.TabIndex = 12;
            this.BtnDecimal.Text = "Decimal";
            this.BtnDecimal.UseVisualStyleBackColor = true;
            this.BtnDecimal.Click += new System.EventHandler(this.BtnDecimal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 765);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button BtnBool;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textSize;
        private System.Windows.Forms.Label txtTpye;
        private System.Windows.Forms.Button BtnChar;
        private System.Windows.Forms.Button BtnUInt16;
        private System.Windows.Forms.Button BtnSbyte;
        private System.Windows.Forms.Button BtnLong;
        private System.Windows.Forms.TextBox textMinimum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btnfloat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textMaximum;
        private System.Windows.Forms.Button BtnByte;
        private System.Windows.Forms.Button BtnShort;
        private System.Windows.Forms.Button BtnUshort;
        private System.Windows.Forms.Button BtnInt;
        private System.Windows.Forms.Button BtnUint32;
        private System.Windows.Forms.Button BtnUlong;
        private System.Windows.Forms.Button BtnDouble;
        private System.Windows.Forms.Button BtnDecimal;
    }
}

