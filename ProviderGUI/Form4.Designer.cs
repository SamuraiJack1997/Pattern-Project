﻿namespace ProviderGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            label1 = new Label();
            txtplanName = new TextBox();
            txtdownloadSpeed = new TextBox();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            txtuploadSpeed = new TextBox();
            label4 = new Label();
            txtnumberOfChannels = new TextBox();
            label5 = new Label();
            floatprice = new TextBox();
            label6 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Plan name:";
            // 
            // txtplanName
            // 
            txtplanName.Location = new Point(154, 35);
            txtplanName.Name = "txtplanName";
            txtplanName.Size = new Size(141, 23);
            txtplanName.TabIndex = 1;
            // 
            // txtdownloadSpeed
            // 
            txtdownloadSpeed.Location = new Point(154, 64);
            txtdownloadSpeed.Name = "txtdownloadSpeed";
            txtdownloadSpeed.Size = new Size(141, 23);
            txtdownloadSpeed.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(136, 15);
            label2.TabIndex = 2;
            label2.Text = "Download speed(mbps):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 4;
            label3.Text = "Select plan type:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Internet Plan", "TV Plan" });
            comboBox1.Location = new Point(154, 6);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(141, 23);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(12, 181);
            button1.Name = "button1";
            button1.Size = new Size(136, 48);
            button1.TabIndex = 7;
            button1.Text = "Add plan";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(154, 180);
            button2.Name = "button2";
            button2.Size = new Size(141, 49);
            button2.TabIndex = 8;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtuploadSpeed
            // 
            txtuploadSpeed.Location = new Point(154, 93);
            txtuploadSpeed.Name = "txtuploadSpeed";
            txtuploadSpeed.Size = new Size(141, 23);
            txtuploadSpeed.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 96);
            label4.Name = "label4";
            label4.Size = new Size(120, 15);
            label4.TabIndex = 9;
            label4.Text = "Upload speed(mpbs):";
            // 
            // txtnumberOfChannels
            // 
            txtnumberOfChannels.Location = new Point(154, 122);
            txtnumberOfChannels.Name = "txtnumberOfChannels";
            txtnumberOfChannels.Size = new Size(141, 23);
            txtnumberOfChannels.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 125);
            label5.Name = "label5";
            label5.Size = new Size(118, 15);
            label5.TabIndex = 11;
            label5.Text = "Number of channels:";
            // 
            // floatprice
            // 
            floatprice.BackColor = SystemColors.Info;
            floatprice.Location = new Point(154, 151);
            floatprice.Name = "floatprice";
            floatprice.Size = new Size(141, 23);
            floatprice.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(112, 155);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 13;
            label6.Text = "Price:";
            // 
            // button3
            // 
            button3.Location = new Point(12, 152);
            button3.Name = "button3";
            button3.Size = new Size(94, 23);
            button3.TabIndex = 15;
            button3.Text = "Calculate";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(311, 242);
            Controls.Add(button3);
            Controls.Add(floatprice);
            Controls.Add(label6);
            Controls.Add(txtnumberOfChannels);
            Controls.Add(label5);
            Controls.Add(txtuploadSpeed);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(txtdownloadSpeed);
            Controls.Add(label2);
            Controls.Add(txtplanName);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtplanName;
        private TextBox txtdownloadSpeed;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private TextBox txtuploadSpeed;
        private Label label4;
        private TextBox txtnumberOfChannels;
        private Label label5;
        private TextBox floatprice;
        private Label label6;
        private Button button3;
    }
}