namespace Dateien
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbNachname = new TextBox();
            tbVorname = new TextBox();
            tbEmail = new TextBox();
            button1 = new Button();
            label4 = new Label();
            lbNamen = new ListBox();
            button2 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 111);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 0;
            label1.Text = "Nachname:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 189);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 1;
            label2.Text = "Vorname:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 269);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            // 
            // tbNachname
            // 
            tbNachname.Location = new Point(191, 100);
            tbNachname.Margin = new Padding(3, 4, 3, 4);
            tbNachname.Name = "tbNachname";
            tbNachname.Size = new Size(149, 27);
            tbNachname.TabIndex = 3;
            // 
            // tbVorname
            // 
            tbVorname.Location = new Point(191, 179);
            tbVorname.Margin = new Padding(3, 4, 3, 4);
            tbVorname.Name = "tbVorname";
            tbVorname.Size = new Size(149, 27);
            tbVorname.TabIndex = 4;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(191, 259);
            tbEmail.Margin = new Padding(3, 4, 3, 4);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(149, 27);
            tbEmail.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(191, 553);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(146, 44);
            button1.TabIndex = 6;
            button1.Text = "Speichern";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(86, 504);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 7;
            label4.Text = "label4";
            // 
            // lbNamen
            // 
            lbNamen.FormattingEnabled = true;
            lbNamen.Location = new Point(454, 101);
            lbNamen.Margin = new Padding(3, 4, 3, 4);
            lbNamen.Name = "lbNamen";
            lbNamen.Size = new Size(135, 184);
            lbNamen.TabIndex = 8;
            lbNamen.SelectedIndexChanged += lbNamen_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(453, 332);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(137, 37);
            button2.TabIndex = 9;
            button2.Text = "Lesen";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(72, 332);
            radioButton1.Margin = new Padding(3, 4, 3, 4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(67, 24);
            radioButton1.TabIndex = 10;
            radioButton1.TabStop = true;
            radioButton1.Text = "Mann";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(191, 332);
            radioButton2.Margin = new Padding(3, 4, 3, 4);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(58, 24);
            radioButton2.TabIndex = 11;
            radioButton2.Text = "Frau";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(293, 332);
            radioButton3.Margin = new Padding(3, 4, 3, 4);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(52, 24);
            radioButton3.TabIndex = 12;
            radioButton3.Text = "Div";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(197, 392);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(141, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 600);
            Controls.Add(pictureBox1);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(button2);
            Controls.Add(lbNamen);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(tbEmail);
            Controls.Add(tbVorname);
            Controls.Add(tbNachname);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbNachname;
        private TextBox tbVorname;
        private TextBox tbEmail;
        private Button button1;
        private Label label4;
        private ListBox lbNamen;
        private Button button2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private PictureBox pictureBox1;
    }
}
