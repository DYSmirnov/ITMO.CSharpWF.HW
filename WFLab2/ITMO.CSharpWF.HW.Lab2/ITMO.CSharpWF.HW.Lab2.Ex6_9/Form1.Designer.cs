
namespace ITMO.CSharpWF.HW.Lab2.Ex6_9
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.checkBoxRefund = new System.Windows.Forms.CheckBox();
            this.checkBoxExistence = new System.Windows.Forms.CheckBox();
            this.numericPeriodUse = new System.Windows.Forms.NumericUpDown();
            this.numericInventar = new System.Windows.Forms.NumericUpDown();
            this.numericYear = new System.Windows.Forms.NumericUpDown();
            this.numericPages = new System.Windows.Forms.NumericUpDown();
            this.textBoxPublishHouse = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.labelUsePeriod = new System.Windows.Forms.Label();
            this.labelInvNumber = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelPage = new System.Windows.Forms.Label();
            this.labelPublishHouse = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.numericMagNumber = new System.Windows.Forms.NumericUpDown();
            this.textMagTitle = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelNumb = new System.Windows.Forms.Label();
            this.labelVol = new System.Windows.Forms.Label();
            this.labelMagName = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonWach = new System.Windows.Forms.Button();
            this.checkBoxSortInventar = new System.Windows.Forms.CheckBox();
            this.buttonAddMag = new System.Windows.Forms.Button();
            this.numericMagDate = new System.Windows.Forms.NumericUpDown();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericMagInvNumb = new System.Windows.Forms.NumericUpDown();
            this.checkBoxMagExistence = new System.Windows.Forms.CheckBox();
            this.checkBoxMagRefund = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPeriodUse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInventar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPages)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMagNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMagDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMagInvNumb)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(310, 414);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage1.Controls.Add(this.buttonAdd);
            this.tabPage1.Controls.Add(this.checkBoxRefund);
            this.tabPage1.Controls.Add(this.checkBoxExistence);
            this.tabPage1.Controls.Add(this.numericPeriodUse);
            this.tabPage1.Controls.Add(this.numericInventar);
            this.tabPage1.Controls.Add(this.numericYear);
            this.tabPage1.Controls.Add(this.numericPages);
            this.tabPage1.Controls.Add(this.textBoxPublishHouse);
            this.tabPage1.Controls.Add(this.textBoxTitle);
            this.tabPage1.Controls.Add(this.textBoxAuthor);
            this.tabPage1.Controls.Add(this.labelUsePeriod);
            this.tabPage1.Controls.Add(this.labelInvNumber);
            this.tabPage1.Controls.Add(this.labelYear);
            this.tabPage1.Controls.Add(this.labelPage);
            this.tabPage1.Controls.Add(this.labelPublishHouse);
            this.tabPage1.Controls.Add(this.labelTitle);
            this.tabPage1.Controls.Add(this.labelAuthor);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(302, 388);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Книги";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(24, 304);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(234, 57);
            this.buttonAdd.TabIndex = 16;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // checkBoxRefund
            // 
            this.checkBoxRefund.AutoSize = true;
            this.checkBoxRefund.Location = new System.Drawing.Point(131, 239);
            this.checkBoxRefund.Name = "checkBoxRefund";
            this.checkBoxRefund.Size = new System.Drawing.Size(127, 17);
            this.checkBoxRefund.TabIndex = 15;
            this.checkBoxRefund.Text = "Возвращает в срок";
            this.checkBoxRefund.UseVisualStyleBackColor = true;
            // 
            // checkBoxExistence
            // 
            this.checkBoxExistence.AutoSize = true;
            this.checkBoxExistence.Location = new System.Drawing.Point(11, 239);
            this.checkBoxExistence.Name = "checkBoxExistence";
            this.checkBoxExistence.Size = new System.Drawing.Size(72, 17);
            this.checkBoxExistence.TabIndex = 14;
            this.checkBoxExistence.Text = "Наличие";
            this.checkBoxExistence.UseVisualStyleBackColor = true;
            // 
            // numericPeriodUse
            // 
            this.numericPeriodUse.Location = new System.Drawing.Point(131, 200);
            this.numericPeriodUse.Name = "numericPeriodUse";
            this.numericPeriodUse.Size = new System.Drawing.Size(148, 22);
            this.numericPeriodUse.TabIndex = 13;
            // 
            // numericInventar
            // 
            this.numericInventar.Location = new System.Drawing.Point(131, 172);
            this.numericInventar.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericInventar.Name = "numericInventar";
            this.numericInventar.Size = new System.Drawing.Size(148, 22);
            this.numericInventar.TabIndex = 12;
            // 
            // numericYear
            // 
            this.numericYear.Location = new System.Drawing.Point(131, 144);
            this.numericYear.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericYear.Name = "numericYear";
            this.numericYear.Size = new System.Drawing.Size(148, 22);
            this.numericYear.TabIndex = 11;
            // 
            // numericPages
            // 
            this.numericPages.Location = new System.Drawing.Point(131, 115);
            this.numericPages.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericPages.Name = "numericPages";
            this.numericPages.Size = new System.Drawing.Size(148, 22);
            this.numericPages.TabIndex = 10;
            // 
            // textBoxPublishHouse
            // 
            this.textBoxPublishHouse.Location = new System.Drawing.Point(131, 86);
            this.textBoxPublishHouse.Name = "textBoxPublishHouse";
            this.textBoxPublishHouse.Size = new System.Drawing.Size(148, 22);
            this.textBoxPublishHouse.TabIndex = 9;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(131, 56);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(148, 22);
            this.textBoxTitle.TabIndex = 8;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(131, 23);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(148, 22);
            this.textBoxAuthor.TabIndex = 7;
            // 
            // labelUsePeriod
            // 
            this.labelUsePeriod.AutoSize = true;
            this.labelUsePeriod.Location = new System.Drawing.Point(8, 202);
            this.labelUsePeriod.Name = "labelUsePeriod";
            this.labelUsePeriod.Size = new System.Drawing.Size(107, 13);
            this.labelUsePeriod.TabIndex = 6;
            this.labelUsePeriod.Text = "Срок пользования";
            // 
            // labelInvNumber
            // 
            this.labelInvNumber.AutoSize = true;
            this.labelInvNumber.Location = new System.Drawing.Point(8, 177);
            this.labelInvNumber.Name = "labelInvNumber";
            this.labelInvNumber.Size = new System.Drawing.Size(81, 13);
            this.labelInvNumber.TabIndex = 5;
            this.labelInvNumber.Text = "Инвентарный";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(8, 153);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(71, 13);
            this.labelYear.TabIndex = 4;
            this.labelYear.Text = "Год издания";
            // 
            // labelPage
            // 
            this.labelPage.AutoSize = true;
            this.labelPage.Location = new System.Drawing.Point(8, 120);
            this.labelPage.Name = "labelPage";
            this.labelPage.Size = new System.Drawing.Size(53, 13);
            this.labelPage.TabIndex = 3;
            this.labelPage.Text = "Страниц";
            // 
            // labelPublishHouse
            // 
            this.labelPublishHouse.AutoSize = true;
            this.labelPublishHouse.Location = new System.Drawing.Point(8, 94);
            this.labelPublishHouse.Name = "labelPublishHouse";
            this.labelPublishHouse.Size = new System.Drawing.Size(78, 13);
            this.labelPublishHouse.TabIndex = 2;
            this.labelPublishHouse.Text = "Издательство";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(8, 63);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(58, 13);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Название";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(8, 30);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(39, 13);
            this.labelAuthor.TabIndex = 0;
            this.labelAuthor.Text = "Автор";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tabPage2.Controls.Add(this.checkBox2);
            this.tabPage2.Controls.Add(this.checkBoxMagRefund);
            this.tabPage2.Controls.Add(this.checkBoxMagExistence);
            this.tabPage2.Controls.Add(this.numericMagInvNumb);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.textBoxValue);
            this.tabPage2.Controls.Add(this.numericMagDate);
            this.tabPage2.Controls.Add(this.buttonAddMag);
            this.tabPage2.Controls.Add(this.numericMagNumber);
            this.tabPage2.Controls.Add(this.textMagTitle);
            this.tabPage2.Controls.Add(this.labelDate);
            this.tabPage2.Controls.Add(this.labelNumb);
            this.tabPage2.Controls.Add(this.labelVol);
            this.tabPage2.Controls.Add(this.labelMagName);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(302, 388);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Журналы";
            // 
            // numericMagNumber
            // 
            this.numericMagNumber.Location = new System.Drawing.Point(100, 85);
            this.numericMagNumber.Name = "numericMagNumber";
            this.numericMagNumber.Size = new System.Drawing.Size(120, 22);
            this.numericMagNumber.TabIndex = 6;
            // 
            // textMagTitle
            // 
            this.textMagTitle.Location = new System.Drawing.Point(100, 25);
            this.textMagTitle.Name = "textMagTitle";
            this.textMagTitle.Size = new System.Drawing.Size(120, 22);
            this.textMagTitle.TabIndex = 4;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(8, 120);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(79, 13);
            this.labelDate.TabIndex = 3;
            this.labelDate.Text = "Дата выпуска";
            // 
            // labelNumb
            // 
            this.labelNumb.AutoSize = true;
            this.labelNumb.Location = new System.Drawing.Point(8, 90);
            this.labelNumb.Name = "labelNumb";
            this.labelNumb.Size = new System.Drawing.Size(43, 13);
            this.labelNumb.TabIndex = 2;
            this.labelNumb.Text = "Номер";
            // 
            // labelVol
            // 
            this.labelVol.AutoSize = true;
            this.labelVol.Location = new System.Drawing.Point(8, 60);
            this.labelVol.Name = "labelVol";
            this.labelVol.Size = new System.Drawing.Size(27, 13);
            this.labelVol.TabIndex = 1;
            this.labelVol.Text = "Том";
            // 
            // labelMagName
            // 
            this.labelMagName.AutoSize = true;
            this.labelMagName.Location = new System.Drawing.Point(8, 30);
            this.labelMagName.Name = "labelMagName";
            this.labelMagName.Size = new System.Drawing.Size(58, 13);
            this.labelMagName.TabIndex = 0;
            this.labelMagName.Text = "Название";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(327, 20);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(304, 330);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // buttonWach
            // 
            this.buttonWach.Location = new System.Drawing.Point(327, 357);
            this.buttonWach.Name = "buttonWach";
            this.buttonWach.Size = new System.Drawing.Size(89, 42);
            this.buttonWach.TabIndex = 2;
            this.buttonWach.Text = "Посмотреть";
            this.buttonWach.UseVisualStyleBackColor = true;
            this.buttonWach.Click += new System.EventHandler(this.buttonWach_Click);
            // 
            // checkBoxSortInventar
            // 
            this.checkBoxSortInventar.AutoSize = true;
            this.checkBoxSortInventar.Location = new System.Drawing.Point(447, 371);
            this.checkBoxSortInventar.Name = "checkBoxSortInventar";
            this.checkBoxSortInventar.Size = new System.Drawing.Size(195, 17);
            this.checkBoxSortInventar.TabIndex = 3;
            this.checkBoxSortInventar.Text = "Сортировать по инвентарному";
            this.checkBoxSortInventar.UseVisualStyleBackColor = true;
            // 
            // buttonAddMag
            // 
            this.buttonAddMag.Location = new System.Drawing.Point(43, 277);
            this.buttonAddMag.Name = "buttonAddMag";
            this.buttonAddMag.Size = new System.Drawing.Size(157, 66);
            this.buttonAddMag.TabIndex = 8;
            this.buttonAddMag.Text = "Добавить";
            this.buttonAddMag.UseVisualStyleBackColor = true;
            this.buttonAddMag.Click += new System.EventHandler(this.buttonAddMag_Click);
            // 
            // numericMagDate
            // 
            this.numericMagDate.Location = new System.Drawing.Point(100, 117);
            this.numericMagDate.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericMagDate.Name = "numericMagDate";
            this.numericMagDate.Size = new System.Drawing.Size(120, 22);
            this.numericMagDate.TabIndex = 9;
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(100, 53);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(120, 22);
            this.textBoxValue.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Инвентарный";
            // 
            // numericMagInvNumb
            // 
            this.numericMagInvNumb.Location = new System.Drawing.Point(100, 147);
            this.numericMagInvNumb.Name = "numericMagInvNumb";
            this.numericMagInvNumb.Size = new System.Drawing.Size(120, 22);
            this.numericMagInvNumb.TabIndex = 12;
            // 
            // checkBoxMagExistence
            // 
            this.checkBoxMagExistence.AutoSize = true;
            this.checkBoxMagExistence.Location = new System.Drawing.Point(14, 204);
            this.checkBoxMagExistence.Name = "checkBoxMagExistence";
            this.checkBoxMagExistence.Size = new System.Drawing.Size(72, 17);
            this.checkBoxMagExistence.TabIndex = 13;
            this.checkBoxMagExistence.Text = "Наличие";
            this.checkBoxMagExistence.UseVisualStyleBackColor = true;
            // 
            // checkBoxMagRefund
            // 
            this.checkBoxMagRefund.AutoSize = true;
            this.checkBoxMagRefund.Location = new System.Drawing.Point(144, 204);
            this.checkBoxMagRefund.Name = "checkBoxMagRefund";
            this.checkBoxMagRefund.Size = new System.Drawing.Size(127, 17);
            this.checkBoxMagRefund.TabIndex = 14;
            this.checkBoxMagRefund.Text = "Возвращает в срок";
            this.checkBoxMagRefund.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(100, 237);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(78, 17);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "Подписка";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 411);
            this.Controls.Add(this.checkBoxSortInventar);
            this.Controls.Add(this.buttonWach);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPeriodUse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInventar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPages)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMagNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMagDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMagInvNumb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox checkBoxExistence;
        private System.Windows.Forms.NumericUpDown numericPeriodUse;
        private System.Windows.Forms.NumericUpDown numericInventar;
        private System.Windows.Forms.NumericUpDown numericYear;
        private System.Windows.Forms.NumericUpDown numericPages;
        private System.Windows.Forms.TextBox textBoxPublishHouse;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.Label labelUsePeriod;
        private System.Windows.Forms.Label labelInvNumber;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelPage;
        private System.Windows.Forms.Label labelPublishHouse;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.CheckBox checkBoxRefund;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonWach;
        private System.Windows.Forms.CheckBox checkBoxSortInventar;
        private System.Windows.Forms.NumericUpDown numericMagNumber;
        private System.Windows.Forms.TextBox textMagTitle;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelNumb;
        private System.Windows.Forms.Label labelVol;
        private System.Windows.Forms.Label labelMagName;
        private System.Windows.Forms.Button buttonAddMag;
        private System.Windows.Forms.NumericUpDown numericMagDate;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.NumericUpDown numericMagInvNumb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxMagExistence;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBoxMagRefund;
    }
}

