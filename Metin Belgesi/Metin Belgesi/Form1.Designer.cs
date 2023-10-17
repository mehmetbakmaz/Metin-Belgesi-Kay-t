namespace Metin_Belgesi
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
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            folderBrowserDialog1 = new FolderBrowserDialog();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            button3 = new Button();
            listBox1 = new ListBox();
            label3 = new Label();
            richTextBox1 = new RichTextBox();
            button4 = new Button();
            label4 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            richTextBox2 = new RichTextBox();
            label6 = new Label();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(642, 10);
            button1.Name = "button1";
            button1.Size = new Size(182, 32);
            button1.TabIndex = 0;
            button1.Text = "Yol Seç";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(642, 50);
            button2.Name = "button2";
            button2.Size = new Size(182, 32);
            button2.TabIndex = 1;
            button2.Text = "Kaydet";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(132, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(410, 30);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(22, 14);
            label1.Name = "label1";
            label1.Size = new Size(104, 28);
            label1.TabIndex = 3;
            label1.Text = "Belge Adı: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(22, 50);
            label2.Name = "label2";
            label2.Size = new Size(111, 28);
            label2.TabIndex = 5;
            label2.Text = "Belge Yolu: ";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(132, 48);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(410, 30);
            textBox2.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(642, 88);
            button3.Name = "button3";
            button3.Size = new Size(182, 32);
            button3.TabIndex = 1;
            button3.Text = "Liste Kutusuna Aktar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(10, 273);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(248, 204);
            listBox1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(55, 242);
            label3.Name = "label3";
            label3.Size = new Size(155, 28);
            label3.TabIndex = 7;
            label3.Text = "Aktarılan Bilgiler";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(295, 273);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(248, 204);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = "";
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(642, 126);
            button4.Name = "button4";
            button4.Size = new Size(182, 32);
            button4.TabIndex = 1;
            button4.Text = "RichTextbox'a Aktar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(336, 242);
            label4.Name = "label4";
            label4.Size = new Size(155, 28);
            label4.TabIndex = 7;
            label4.Text = "Aktarılan Bilgiler";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(22, 92);
            label5.Name = "label5";
            label5.Size = new Size(114, 28);
            label5.TabIndex = 10;
            label5.Text = "Rich Metin: ";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(132, 90);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(410, 30);
            textBox3.TabIndex = 9;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(570, 273);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(256, 204);
            richTextBox2.TabIndex = 12;
            richTextBox2.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(584, 242);
            label6.Name = "label6";
            label6.Size = new Size(241, 28);
            label6.TabIndex = 11;
            label6.Text = "Kaydedilecek Verileri Yazın";
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(642, 168);
            button5.Name = "button5";
            button5.Size = new Size(182, 32);
            button5.TabIndex = 13;
            button5.Text = "Verileri Kaydet";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(837, 495);
            Controls.Add(button5);
            Controls.Add(richTextBox2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(richTextBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private FolderBrowserDialog folderBrowserDialog1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Button button3;
        private ListBox listBox1;
        private Label label3;
        private RichTextBox richTextBox1;
        private Button button4;
        private Label label4;
        private Label label5;
        private TextBox textBox3;
        private RichTextBox richTextBox2;
        private Label label6;
        private Button button5;
    }
}