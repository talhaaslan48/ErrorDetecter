﻿namespace Projemiz
{
    partial class FormAnaSyf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnaSyf));
            panel1 = new Panel();
            button7 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(10, 9);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(435, 1004);
            panel1.TabIndex = 0;
            // 
            // button7
            // 
            button7.Location = new Point(25, 733);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(375, 51);
            button7.TabIndex = 6;
            button7.Text = "Read-Solomon Algoritması";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click_1;
            // 
            // button4
            // 
            button4.Location = new Point(25, 460);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(375, 44);
            button4.TabIndex = 5;
            button4.Text = "CRC Algoritması";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // button5
            // 
            button5.Location = new Point(25, 551);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(375, 45);
            button5.TabIndex = 4;
            button5.Text = "FEC Algoritması";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click_1;
            // 
            // button6
            // 
            button6.Location = new Point(25, 640);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(375, 48);
            button6.TabIndex = 3;
            button6.Text = "BCH Algoritması";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click_1;
            // 
            // button3
            // 
            button3.Location = new Point(25, 368);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(375, 44);
            button3.TabIndex = 2;
            button3.Text = "LRC Algoritması";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(25, 277);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(375, 45);
            button2.TabIndex = 1;
            button2.Text = "Word to Hamming";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(25, 185);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(375, 45);
            button1.TabIndex = 0;
            button1.Text = "Hamming Algoritmassı";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 48F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(833, 28);
            label1.Name = "label1";
            label1.Size = new Size(535, 89);
            label1.TabIndex = 1;
            label1.Text = "ErrorAnalyzer";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(579, 377);
            label2.Name = "label2";
            label2.Size = new Size(1056, 391);
            label2.TabIndex = 2;
            label2.Text = resources.GetString("label2.Text");
            // 
            // FormAnaSyf
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1055);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAnaSyf";
            Text = "Ana Sayfa";
            WindowState = FormWindowState.Maximized;
            Load += FormAnaSyf_Load_1;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button7;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
        private Label label2;
    }
}