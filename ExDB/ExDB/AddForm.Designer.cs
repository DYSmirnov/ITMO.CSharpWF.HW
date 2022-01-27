
namespace ExDB
{
    partial class AddForm
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
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.labelFName = new System.Windows.Forms.Label();
            this.labelLname = new System.Windows.Forms.Label();
            this.button2Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxFName
            // 
            this.textBoxFName.Location = new System.Drawing.Point(162, 31);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(183, 22);
            this.textBoxFName.TabIndex = 0;
            // 
            // textBoxLName
            // 
            this.textBoxLName.Location = new System.Drawing.Point(162, 94);
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.Size = new System.Drawing.Size(183, 22);
            this.textBoxLName.TabIndex = 1;
            // 
            // labelFName
            // 
            this.labelFName.AutoSize = true;
            this.labelFName.Location = new System.Drawing.Point(35, 31);
            this.labelFName.Name = "labelFName";
            this.labelFName.Size = new System.Drawing.Size(60, 13);
            this.labelFName.TabIndex = 2;
            this.labelFName.Text = "First name";
            // 
            // labelLname
            // 
            this.labelLname.AutoSize = true;
            this.labelLname.Location = new System.Drawing.Point(35, 94);
            this.labelLname.Name = "labelLname";
            this.labelLname.Size = new System.Drawing.Size(58, 13);
            this.labelLname.TabIndex = 3;
            this.labelLname.Text = "Last name";
            // 
            // button2Add
            // 
            this.button2Add.Location = new System.Drawing.Point(95, 126);
            this.button2Add.Name = "button2Add";
            this.button2Add.Size = new System.Drawing.Size(211, 41);
            this.button2Add.TabIndex = 4;
            this.button2Add.Text = "Add";
            this.button2Add.UseVisualStyleBackColor = true;
            this.button2Add.Click += new System.EventHandler(this.button2Add_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 179);
            this.Controls.Add(this.button2Add);
            this.Controls.Add(this.labelLname);
            this.Controls.Add(this.labelFName);
            this.Controls.Add(this.textBoxLName);
            this.Controls.Add(this.textBoxFName);
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.TextBox textBoxLName;
        private System.Windows.Forms.Label labelFName;
        private System.Windows.Forms.Label labelLname;
        private System.Windows.Forms.Button button2Add;
    }
}