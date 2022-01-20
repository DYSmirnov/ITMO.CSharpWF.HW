using System;
using MyClass;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ITMO.CSharpWF.HW.Lab2.Ex6_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Item> its = new List<Item>();

        //
        //Book
        //

        public string Author // автор
        {
            get { return textBoxAuthor.Text; }
            set { textBoxAuthor.Text = value; }
        }
        public string Title // Название
        {
            get { return textBoxTitle.Text; }
            set { textBoxTitle.Text = value; }
        }
        public string PublishHouse // Издательство
        {
            get { return textBoxPublishHouse.Text; }
            set { textBoxPublishHouse.Text = value; }
        }
        public int Page // Количество страниц
        {
            get { return (int)numericPages.Value; }
            set { numericPages.Value = value; }
        }
        public int Year // Год издания
        {
            get { return (int)numericYear.Value; }
            set { numericYear.Value = value; }
        }
        public int InvNumber // Инвентарный номер
        {
            get { return (int)numericInventar.Value; }
            set { numericInventar.Value = value; }
        }
        public bool Existence // Наличие
        {
            get { return checkBoxExistence.Checked; }
            set { checkBoxExistence.Checked = value; }
        }
        public bool SortInvNumber // Сортировка по инвентарному номеру
        {
            get { return checkBoxSortInventar.Checked; }
            set { checkBoxSortInventar.Checked = value; }
        }
        public bool ReturnTime // Возвращение в срок
        {
            get { return checkBoxRefund.Checked; }
            set { checkBoxRefund.Checked = value; }
        }
        public int PeriodUse // Срок пользования
        {
            get { return (int)numericPeriodUse.Value; }
            set { numericPeriodUse.Value = value; }
        }

        //
        //Magazine
        //

        public string MagTitle // название
        {
            get { return textMagTitle.Text; }
            set { textMagTitle.Text = value; }
        }

        public string Volume // том 
        {
            get { return textBoxValue.Text; }
            set { textBoxValue.Text = value; }
        }

        public int MagNumber // номер
        {
            get { return (int)numericMagNumber.Value; }
            set { numericMagNumber.Value = value; }
        }

        public int MagDate //год выпуска
        {
            get { return (int)numericMagDate.Value; }
            set { numericMagDate.Value = value; }
        }

        public int MagInvNumber // Инвентарный номер
        {
            get { return (int)numericMagInvNumb.Value; }
            set { numericMagInvNumb.Value = value; }
        }
        public bool MagExistence // Наличие
        {
            get { return checkBoxMagExistence.Checked; }
            set { checkBoxMagExistence.Checked = value; }
        }
        public bool MagReturnTime // Возвращение в срок
        {
            get { return checkBoxMagRefund.Checked; }
            set { checkBoxMagRefund.Checked = value; }
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Book b = new Book(Author, Title, PublishHouse,
            Page, Year, InvNumber, Existence);
            if (ReturnTime)
                b.ReturnSrok();
            b.PriceBook(PeriodUse);
            its.Add(b);
            Author = Title = PublishHouse = "";
            Page = InvNumber = PeriodUse = 0;
            Year = 2000;
            Existence = ReturnTime = false;
        }

        private void buttonWach_Click(object sender, EventArgs e)
        {
            if (SortInvNumber)
                its.Sort();
            StringBuilder sb = new StringBuilder();
            foreach (Item item in its)
            {
                sb.Append("\n" + item.ToString());
                richTextBox1.Text = sb.ToString();

            }
        }

        private void buttonAddMag_Click(object sender, EventArgs e)
        {
            Magazine m = new Magazine(Volume, MagNumber, MagTitle, MagDate, MagInvNumber, Existence);
            its.Add(m);
            Volume = MagTitle  = "";
            MagNumber = MagInvNumber =  0;
            MagDate = 2000;
            Existence = ReturnTime = false;
        }
    }
}

