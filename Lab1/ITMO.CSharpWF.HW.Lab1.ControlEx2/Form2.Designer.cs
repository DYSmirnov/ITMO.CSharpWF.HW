﻿
namespace ITMO.CSharpWF.HW.Lab1.ControlEx2
{
    partial class Form2
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
            this.ToFirstFormButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ToFirstFormButton
            // 
            this.ToFirstFormButton.Location = new System.Drawing.Point(429, 87);
            this.ToFirstFormButton.Name = "ToFirstFormButton";
            this.ToFirstFormButton.Size = new System.Drawing.Size(236, 119);
            this.ToFirstFormButton.TabIndex = 0;
            this.ToFirstFormButton.Text = "First Form";
            this.ToFirstFormButton.UseVisualStyleBackColor = true;
            this.ToFirstFormButton.Click += new System.EventHandler(this.ToFirstFormButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(429, 316);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(236, 148);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 608);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ToFirstFormButton);
            this.Name = "Form2";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ToFirstFormButton;
        private System.Windows.Forms.Button ExitButton;
    }
}