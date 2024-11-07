namespace Uygulama_2__Ucak_Bilet_rezervasyon_sistemi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            button2 = new Button();
            label4 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button1 = new Button();
            maskedTextBox3 = new MaskedTextBox();
            label7 = new Label();
            maskedTextBox2 = new MaskedTextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            listBox1 = new ListBox();
            label9 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ScrollBar;
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Microsoft Sans Serif", 14F);
            groupBox1.Location = new Point(294, 230);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(606, 370);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Flight Information";
            // 
            // button2
            // 
            button2.Location = new Point(521, 128);
            button2.Name = "button2";
            button2.Size = new Size(64, 41);
            button2.TabIndex = 4;
            button2.Text = "<>";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14F);
            label4.Location = new Point(58, 307);
            label4.Name = "label4";
            label4.Size = new Size(77, 32);
            label4.TabIndex = 8;
            label4.Text = "Time";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new Font("Microsoft Sans Serif", 14F);
            maskedTextBox1.Location = new Point(246, 310);
            maskedTextBox1.Mask = "00:00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(269, 39);
            maskedTextBox1.TabIndex = 7;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Microsoft Sans Serif", 14F);
            dateTimePicker1.Location = new Point(247, 239);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(268, 39);
            dateTimePicker1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14F);
            label3.Location = new Point(58, 236);
            label3.Name = "label3";
            label3.Size = new Size(74, 32);
            label3.TabIndex = 3;
            label3.Text = "Date";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Microsoft Sans Serif", 14F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Helsinki", "Paris", "London", "Berlin" });
            comboBox2.Location = new Point(247, 162);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(268, 40);
            comboBox2.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Microsoft Sans Serif", 14F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Helsinki", "Paris", "London", "Berlin" });
            comboBox1.Location = new Point(247, 96);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(268, 40);
            comboBox1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14F);
            label2.Location = new Point(58, 159);
            label2.Name = "label2";
            label2.Size = new Size(158, 32);
            label2.TabIndex = 3;
            label2.Text = "Destination";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F);
            label1.Location = new Point(58, 96);
            label1.Name = "label1";
            label1.Size = new Size(79, 32);
            label1.TabIndex = 2;
            label1.Text = "From";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ScrollBar;
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(maskedTextBox3);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(maskedTextBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new Font("Microsoft Sans Serif", 14F);
            groupBox2.Location = new Point(919, 239);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(541, 361);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Passanger Information";
            // 
            // button1
            // 
            button1.BackColor = Color.LightGreen;
            button1.Location = new Point(283, 246);
            button1.Name = "button1";
            button1.Size = new Size(217, 48);
            button1.TabIndex = 9;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Font = new Font("Microsoft Sans Serif", 14F);
            maskedTextBox3.Location = new Point(283, 169);
            maskedTextBox3.Mask = "(999) 000-0000";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(217, 39);
            maskedTextBox3.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 14F);
            label7.Location = new Point(20, 169);
            label7.Name = "label7";
            label7.Size = new Size(204, 32);
            label7.TabIndex = 7;
            label7.Text = "Phone Number";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Font = new Font("Microsoft Sans Serif", 14F);
            maskedTextBox2.Location = new Point(283, 107);
            maskedTextBox2.Mask = "000000000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(217, 39);
            maskedTextBox2.TabIndex = 6;
            maskedTextBox2.ValidatingType = typeof(int);
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 14F);
            textBox1.Location = new Point(283, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(217, 39);
            textBox1.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 14F);
            label6.Location = new Point(20, 107);
            label6.Name = "label6";
            label6.Size = new Size(233, 32);
            label6.TabIndex = 4;
            label6.Text = "Passport Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 14F);
            label5.Location = new Point(20, 50);
            label5.Name = "label5";
            label5.Size = new Size(143, 32);
            label5.TabIndex = 0;
            label5.Text = "Full Name";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Orange;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(21, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1675, 199);
            panel1.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe Script", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label8.Location = new Point(94, 17);
            label8.Name = "label8";
            label8.Size = new Size(903, 159);
            label8.TabIndex = 1;
            label8.Text = "Jupiter Airlines";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1262, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(360, 139);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.Orange;
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 32;
            listBox1.Location = new Point(33, 630);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1663, 164);
            listBox1.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(566, 595);
            label9.Name = "label9";
            label9.Size = new Size(98, 32);
            label9.TabIndex = 9;
            label9.Text = "label9";
            label9.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1729, 829);
            Controls.Add(label9);
            Controls.Add(listBox1);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private MaskedTextBox maskedTextBox1;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private MaskedTextBox maskedTextBox3;
        private Label label7;
        private MaskedTextBox maskedTextBox2;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private Button button1;
        private Panel panel1;
        private Label label8;
        private PictureBox pictureBox1;
        private ListBox listBox1;
        private Button button2;
        private Label label9;
    }
}
