namespace WinFormsApp1
{
    partial class Form4
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            radioButton1 = new RadioButton();
            button2 = new Button();
            label4 = new Label();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            radioButton2 = new RadioButton();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(157, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(157, 105);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(216, 211);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "GİRİS";
            button1.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(200, 153);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(82, 24);
            radioButton1.TabIndex = 10;
            radioButton1.TabStop = true;
            radioButton1.Text = "Yönetici";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(353, 211);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 11;
            button2.Text = "ÇIKIŞ";
            button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 315);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 12;
            label4.Text = "Giriş Hakkı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(200, 315);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 13;
            label5.Text = "label5";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 112);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 14;
            label2.Text = "Parola";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 34);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 15;
            label1.Text = "Kullanıcı adı";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 168);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 16;
            label3.Text = "Yetki";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(335, 153);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(86, 24);
            radioButton2.TabIndex = 17;
            radioButton2.TabStop = true;
            radioButton2.Text = "Kullanıcı";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(radioButton2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(radioButton1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private RadioButton radioButton1;
        private Button button2;
        private Label label4;
        private Label label5;
        private Label label2;
        private Label label1;
        private Label label3;
        private RadioButton radioButton2;
    }
}