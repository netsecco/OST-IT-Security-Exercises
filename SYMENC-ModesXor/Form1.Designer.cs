﻿namespace SYMENC_ModesXor
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
            textBoxCTB1 = new TextBox();
            textBoxCTH1 = new TextBox();
            textBoxSTB1 = new TextBox();
            textBoxSTH1 = new TextBox();
            textBoxKexH = new TextBox();
            textBoxKeyB = new TextBox();
            buttonEnc1 = new Button();
            buttonDec1 = new Button();
            textBoxDecH1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxDecH2 = new TextBox();
            buttonDec2 = new Button();
            buttonEnc2 = new Button();
            textBoxSTH2 = new TextBox();
            textBoxSTB2 = new TextBox();
            textBoxCTH2 = new TextBox();
            textBoxCTB2 = new TextBox();
            SuspendLayout();
            // 
            // textBoxCTB1
            // 
            textBoxCTB1.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCTB1.Location = new Point(145, 139);
            textBoxCTB1.MaxLength = 8;
            textBoxCTB1.Name = "textBoxCTB1";
            textBoxCTB1.ReadOnly = true;
            textBoxCTB1.Size = new Size(100, 30);
            textBoxCTB1.TabIndex = 0;
            textBoxCTB1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxCTH1
            // 
            textBoxCTH1.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCTH1.Location = new Point(171, 103);
            textBoxCTH1.MaxLength = 8;
            textBoxCTH1.Name = "textBoxCTH1";
            textBoxCTH1.Size = new Size(46, 30);
            textBoxCTH1.TabIndex = 1;
            textBoxCTH1.TextAlign = HorizontalAlignment.Center;
            textBoxCTH1.TextChanged += textBoxCTH1_TextChanged;
            // 
            // textBoxSTB1
            // 
            textBoxSTB1.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSTB1.Location = new Point(145, 230);
            textBoxSTB1.MaxLength = 8;
            textBoxSTB1.Name = "textBoxSTB1";
            textBoxSTB1.ReadOnly = true;
            textBoxSTB1.Size = new Size(100, 30);
            textBoxSTB1.TabIndex = 2;
            textBoxSTB1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxSTH1
            // 
            textBoxSTH1.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSTH1.Location = new Point(171, 266);
            textBoxSTH1.MaxLength = 8;
            textBoxSTH1.Name = "textBoxSTH1";
            textBoxSTH1.ReadOnly = true;
            textBoxSTH1.Size = new Size(46, 30);
            textBoxSTH1.TabIndex = 3;
            textBoxSTH1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxKexH
            // 
            textBoxKexH.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxKexH.Location = new Point(98, 22);
            textBoxKexH.MaxLength = 2;
            textBoxKexH.Name = "textBoxKexH";
            textBoxKexH.Size = new Size(46, 30);
            textBoxKexH.TabIndex = 5;
            textBoxKexH.Text = "FF";
            textBoxKexH.TextAlign = HorizontalAlignment.Center;
            textBoxKexH.TextChanged += textBoxKexH_TextChanged;
            // 
            // textBoxKeyB
            // 
            textBoxKeyB.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxKeyB.Location = new Point(171, 22);
            textBoxKeyB.MaxLength = 8;
            textBoxKeyB.Name = "textBoxKeyB";
            textBoxKeyB.ReadOnly = true;
            textBoxKeyB.Size = new Size(100, 30);
            textBoxKeyB.TabIndex = 4;
            textBoxKeyB.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonEnc1
            // 
            buttonEnc1.Location = new Point(156, 187);
            buttonEnc1.Name = "buttonEnc1";
            buttonEnc1.Size = new Size(75, 23);
            buttonEnc1.TabIndex = 6;
            buttonEnc1.Text = "Encrypt";
            buttonEnc1.UseVisualStyleBackColor = true;
            buttonEnc1.Click += buttonEnc1_Click;
            // 
            // buttonDec1
            // 
            buttonDec1.Location = new Point(156, 314);
            buttonDec1.Name = "buttonDec1";
            buttonDec1.Size = new Size(75, 23);
            buttonDec1.TabIndex = 7;
            buttonDec1.Text = "Decrypt";
            buttonDec1.UseVisualStyleBackColor = true;
            buttonDec1.Click += buttonDec1_Click;
            // 
            // textBoxDecH1
            // 
            textBoxDecH1.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDecH1.Location = new Point(171, 353);
            textBoxDecH1.MaxLength = 8;
            textBoxDecH1.Name = "textBoxDecH1";
            textBoxDecH1.ReadOnly = true;
            textBoxDecH1.Size = new Size(46, 30);
            textBoxDecH1.TabIndex = 8;
            textBoxDecH1.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(45, 25);
            label1.Name = "label1";
            label1.Size = new Size(35, 21);
            label1.TabIndex = 9;
            label1.Text = "Key";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(165, 68);
            label2.Name = "label2";
            label2.Size = new Size(60, 21);
            label2.TabIndex = 10;
            label2.Text = "Block 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(370, 68);
            label3.Name = "label3";
            label3.Size = new Size(60, 21);
            label3.TabIndex = 18;
            label3.Text = "Block 2";
            // 
            // textBoxDecH2
            // 
            textBoxDecH2.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDecH2.Location = new Point(376, 353);
            textBoxDecH2.MaxLength = 8;
            textBoxDecH2.Name = "textBoxDecH2";
            textBoxDecH2.ReadOnly = true;
            textBoxDecH2.Size = new Size(46, 30);
            textBoxDecH2.TabIndex = 17;
            textBoxDecH2.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonDec2
            // 
            buttonDec2.Location = new Point(361, 314);
            buttonDec2.Name = "buttonDec2";
            buttonDec2.Size = new Size(75, 23);
            buttonDec2.TabIndex = 16;
            buttonDec2.Text = "Decrypt";
            buttonDec2.UseVisualStyleBackColor = true;
            buttonDec2.Click += buttonDec2_Click;
            // 
            // buttonEnc2
            // 
            buttonEnc2.Location = new Point(361, 187);
            buttonEnc2.Name = "buttonEnc2";
            buttonEnc2.Size = new Size(75, 23);
            buttonEnc2.TabIndex = 15;
            buttonEnc2.Text = "Encrypt";
            buttonEnc2.UseVisualStyleBackColor = true;
            buttonEnc2.Click += buttonEnc2_Click;
            // 
            // textBoxSTH2
            // 
            textBoxSTH2.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSTH2.Location = new Point(376, 266);
            textBoxSTH2.MaxLength = 8;
            textBoxSTH2.Name = "textBoxSTH2";
            textBoxSTH2.ReadOnly = true;
            textBoxSTH2.Size = new Size(46, 30);
            textBoxSTH2.TabIndex = 14;
            textBoxSTH2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxSTB2
            // 
            textBoxSTB2.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSTB2.Location = new Point(350, 230);
            textBoxSTB2.MaxLength = 8;
            textBoxSTB2.Name = "textBoxSTB2";
            textBoxSTB2.ReadOnly = true;
            textBoxSTB2.Size = new Size(100, 30);
            textBoxSTB2.TabIndex = 13;
            textBoxSTB2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxCTH2
            // 
            textBoxCTH2.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCTH2.Location = new Point(376, 103);
            textBoxCTH2.MaxLength = 8;
            textBoxCTH2.Name = "textBoxCTH2";
            textBoxCTH2.Size = new Size(46, 30);
            textBoxCTH2.TabIndex = 12;
            textBoxCTH2.TextAlign = HorizontalAlignment.Center;
            textBoxCTH2.TextChanged += textBoxCTH2_TextChanged;
            // 
            // textBoxCTB2
            // 
            textBoxCTB2.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCTB2.Location = new Point(350, 139);
            textBoxCTB2.MaxLength = 8;
            textBoxCTB2.Name = "textBoxCTB2";
            textBoxCTB2.ReadOnly = true;
            textBoxCTB2.Size = new Size(100, 30);
            textBoxCTB2.TabIndex = 11;
            textBoxCTB2.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(textBoxDecH2);
            Controls.Add(buttonDec2);
            Controls.Add(buttonEnc2);
            Controls.Add(textBoxSTH2);
            Controls.Add(textBoxSTB2);
            Controls.Add(textBoxCTH2);
            Controls.Add(textBoxCTB2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxDecH1);
            Controls.Add(buttonDec1);
            Controls.Add(buttonEnc1);
            Controls.Add(textBoxKexH);
            Controls.Add(textBoxKeyB);
            Controls.Add(textBoxSTH1);
            Controls.Add(textBoxSTB1);
            Controls.Add(textBoxCTH1);
            Controls.Add(textBoxCTB1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxCTB1;
        private TextBox textBoxCTH1;
        private TextBox textBoxSTB1;
        private TextBox textBoxSTH1;
        private TextBox textBoxKexH;
        private TextBox textBoxKeyB;
        private Button buttonEnc1;
        private Button buttonDec1;
        private TextBox textBoxDecH1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxDecH2;
        private Button buttonDec2;
        private Button buttonEnc2;
        private TextBox textBoxSTH2;
        private TextBox textBoxSTB2;
        private TextBox textBoxCTH2;
        private TextBox textBoxCTB2;
    }
}