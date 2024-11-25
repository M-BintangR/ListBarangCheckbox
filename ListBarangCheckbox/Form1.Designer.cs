namespace ListBarangCheckbox
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox8 = new CheckBox();
            label1 = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            listBox1 = new ListBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = SystemColors.Highlight;
            checkBox1.Location = new Point(302, 77);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(54, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Beras";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.ForeColor = SystemColors.Highlight;
            checkBox2.Location = new Point(302, 113);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(58, 19);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Terigu";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.BackColor = SystemColors.GradientInactiveCaption;
            checkBox3.ForeColor = SystemColors.Highlight;
            checkBox3.Location = new Point(302, 152);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(51, 19);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Telur";
            checkBox3.UseVisualStyleBackColor = false;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.BackColor = SystemColors.GradientInactiveCaption;
            checkBox4.ForeColor = SystemColors.Highlight;
            checkBox4.Location = new Point(302, 193);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(47, 19);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "Roti";
            checkBox4.UseVisualStyleBackColor = false;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.ForeColor = SystemColors.Highlight;
            checkBox5.Location = new Point(425, 77);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(85, 19);
            checkBox5.TabIndex = 4;
            checkBox5.Text = "Mie Instant";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.ForeColor = SystemColors.Highlight;
            checkBox6.Location = new Point(425, 113);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(50, 19);
            checkBox6.TabIndex = 5;
            checkBox6.Text = "Kopi";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.ForeColor = SystemColors.Highlight;
            checkBox7.Location = new Point(425, 152);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(50, 19);
            checkBox7.TabIndex = 6;
            checkBox7.Text = "Gula";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.ForeColor = SystemColors.Highlight;
            checkBox8.Location = new Point(425, 193);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(52, 19);
            checkBox8.TabIndex = 7;
            checkBox8.Text = "Kanji";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(350, 18);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 8;
            label1.Text = "List Barang";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button1.ForeColor = SystemColors.Highlight;
            button1.Location = new Point(339, 239);
            button1.Name = "button1";
            button1.Size = new Size(122, 36);
            button1.TabIndex = 9;
            button1.Text = "Add Item";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(232, 302);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 10;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(440, 302);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 11;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(268, 421);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 12;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(477, 421);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 13;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.GradientInactiveCaption;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(22, 23);
            label4.Name = "label4";
            label4.Size = new Size(153, 20);
            label4.TabIndex = 14;
            label4.Text = "Muhammad Bintang";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.GradientInactiveCaption;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(22, 54);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 15;
            label5.Text = "20232205029";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 472);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(checkBox8);
            Controls.Add(checkBox7);
            Controls.Add(checkBox6);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private CheckBox checkBox7;
        private CheckBox checkBox8;
        private Label label1;
        private Button button1;
        private ComboBox comboBox1;
        private ListBox listBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
