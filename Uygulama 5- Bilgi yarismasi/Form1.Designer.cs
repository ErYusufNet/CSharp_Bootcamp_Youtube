namespace Uygulama_5__Bilgi_yarismasi
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
            richTextBox1 = new RichTextBox();
            BtnA = new Button();
            BtnB = new Button();
            BtnC = new Button();
            BtnD = new Button();
            groupBox1 = new GroupBox();
            Next = new Button();
            Fl = new Label();
            Tr = new Label();
            QNo = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(128, 43);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(663, 320);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // BtnA
            // 
            BtnA.Location = new Point(162, 383);
            BtnA.Name = "BtnA";
            BtnA.Size = new Size(112, 34);
            BtnA.TabIndex = 1;
            BtnA.Text = "A";
            BtnA.UseVisualStyleBackColor = true;
            BtnA.Click += BtnA_Click;
            // 
            // BtnB
            // 
            BtnB.Location = new Point(391, 383);
            BtnB.Name = "BtnB";
            BtnB.Size = new Size(112, 34);
            BtnB.TabIndex = 2;
            BtnB.Text = "B";
            BtnB.UseVisualStyleBackColor = true;
            BtnB.Click += BtnB_Click;
            // 
            // BtnC
            // 
            BtnC.Location = new Point(162, 476);
            BtnC.Name = "BtnC";
            BtnC.Size = new Size(112, 34);
            BtnC.TabIndex = 3;
            BtnC.Text = "C";
            BtnC.UseVisualStyleBackColor = true;
            BtnC.Click += BtnC_Click;
            // 
            // BtnD
            // 
            BtnD.Location = new Point(391, 476);
            BtnD.Name = "BtnD";
            BtnD.Size = new Size(112, 34);
            BtnD.TabIndex = 4;
            BtnD.Text = "D";
            BtnD.UseVisualStyleBackColor = true;
            BtnD.Click += BtnD_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Fuchsia;
            groupBox1.Controls.Add(Next);
            groupBox1.Controls.Add(Fl);
            groupBox1.Controls.Add(Tr);
            groupBox1.Controls.Add(QNo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(926, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(317, 308);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Statistics";
            // 
            // Next
            // 
            Next.Location = new Point(83, 210);
            Next.Name = "Next";
            Next.Size = new Size(181, 34);
            Next.TabIndex = 6;
            Next.Text = "Next question";
            Next.UseVisualStyleBackColor = true;
            Next.Click += Next_Click;
            // 
            // Fl
            // 
            Fl.AutoSize = true;
            Fl.Location = new Point(159, 158);
            Fl.Name = "Fl";
            Fl.Size = new Size(22, 25);
            Fl.TabIndex = 5;
            Fl.Text = "0";
            // 
            // Tr
            // 
            Tr.AutoSize = true;
            Tr.Location = new Point(159, 109);
            Tr.Name = "Tr";
            Tr.Size = new Size(22, 25);
            Tr.TabIndex = 4;
            Tr.Text = "0";
            // 
            // QNo
            // 
            QNo.AutoSize = true;
            QNo.Location = new Point(159, 58);
            QNo.Name = "QNo";
            QNo.Size = new Size(22, 25);
            QNo.TabIndex = 3;
            QNo.Text = "0";
            QNo.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 158);
            label3.Name = "label3";
            label3.Size = new Size(50, 25);
            label3.TabIndex = 2;
            label3.Text = "False";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 109);
            label2.Name = "label2";
            label2.Size = new Size(44, 25);
            label2.TabIndex = 1;
            label2.Text = "True";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 58);
            label1.Name = "label1";
            label1.Size = new Size(113, 25);
            label1.TabIndex = 0;
            label1.Text = "Question No";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(878, 403);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 107);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1085, 403);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(145, 107);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(588, 548);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 8;
            label4.Text = "label4";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(703, 548);
            label5.Name = "label5";
            label5.Size = new Size(59, 25);
            label5.TabIndex = 9;
            label5.Text = "label5";
            label5.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(1702, 589);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(BtnD);
            Controls.Add(BtnC);
            Controls.Add(BtnB);
            Controls.Add(BtnA);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button BtnA;
        private Button BtnB;
        private Button BtnC;
        private Button BtnD;
        private GroupBox groupBox1;
        private Button Next;
        private Label Fl;
        private Label Tr;
        private Label QNo;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label5;
    }
}
