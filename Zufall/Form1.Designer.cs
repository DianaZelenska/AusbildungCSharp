namespace Zufall
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
            button1 = new Button();
            textBoxZahlRaten = new TextBox();
            label2 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 228);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(61, 138);
            button1.Name = "button1";
            button1.Size = new Size(164, 53);
            button1.TabIndex = 1;
            button1.Text = "Raten";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxZahlRaten
            // 
            textBoxZahlRaten.Location = new Point(61, 67);
            textBoxZahlRaten.Name = "textBoxZahlRaten";
            textBoxZahlRaten.Size = new Size(100, 23);
            textBoxZahlRaten.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 22);
            label2.Name = "label2";
            label2.Size = new Size(231, 15);
            label2.TabIndex = 3;
            label2.Text = "Geben Sie eine Zahl zwischen 0 und 20 ein!";
            // 
            // button2
            // 
            button2.Location = new Point(39, 372);
            button2.Name = "button2";
            button2.Size = new Size(154, 53);
            button2.TabIndex = 4;
            button2.Text = "Restart";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(textBoxZahlRaten);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox textBoxZahlRaten;
        private Label label2;
        private Button button2;
    }
}
