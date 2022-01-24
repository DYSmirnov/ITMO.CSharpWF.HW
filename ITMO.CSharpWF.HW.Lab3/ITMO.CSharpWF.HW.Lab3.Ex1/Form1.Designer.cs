
namespace ITMO.CSharpWF.HW.Lab3.Ex1
{
    partial class WinTimer1
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
            this.userControlTimer1 = new ITMO.CSharpWF.HW.Lab3.Ex1.UserControlTimer();
            this.buttonS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userControlTimer1
            // 
            this.userControlTimer1.Location = new System.Drawing.Point(52, 207);
            this.userControlTimer1.Name = "userControlTimer1";
            this.userControlTimer1.Size = new System.Drawing.Size(244, 102);
            this.userControlTimer1.TabIndex = 0;
            this.userControlTimer1.TimeEnabled = true;
            // 
            // buttonS
            // 
            this.buttonS.Location = new System.Drawing.Point(424, 207);
            this.buttonS.Name = "buttonS";
            this.buttonS.Size = new System.Drawing.Size(261, 72);
            this.buttonS.TabIndex = 1;
            this.buttonS.Text = "Start/Stop";
            this.buttonS.UseVisualStyleBackColor = true;
            this.buttonS.Click += new System.EventHandler(this.buttonS_Click);
            // 
            // WinTimer1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonS);
            this.Controls.Add(this.userControlTimer1);
            this.Name = "WinTimer1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControlTimer userControlTimer1;
        private System.Windows.Forms.Button buttonS;
    }
}

