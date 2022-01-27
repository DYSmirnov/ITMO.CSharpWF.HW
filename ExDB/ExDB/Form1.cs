using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ExDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // подключение к бд
        //private void dbConect()
        //{
        //    using (SqlConnection cn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=AdventureWorks2017;Data Source=."))
        //    {
        //        cn.Open();
        //    }
        //}

        //Запрос
        private void buttonQuery_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            using (SqlConnection cn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=AdventureWorks2017;Data Source=."))
            {
                cn.Open();

                //запрос с сортировкой ID по возрастанию
                if (checkBoxSort.Checked == true)

                    using (SqlCommand cmd = new SqlCommand
                        ("SELECT  BusinessEntityID, [FirstName],[MiddleName],[LastName] " +
                        "FROM [Person].[Person] order by  BusinessEntityID  ", cn))
                    //using (sqlcommand cmd = new sqlcommand
                    //     ("select  p.businessentityid, [firstname],[middlename],[lastname], [phonenumber] " +
                    //     "from [person].[person] as p " +
                    //     "join[person].[personphone] as ph on ph.businessentityID = p.BusinessEntityID order by  p.BusinessEntityID  ", cn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listBox.Items.Add(reader[0] + " " + reader[1] + " " + reader[2] + " " + reader[3]); //+", Tel: " + reader[4]);
                        }
                    }


                //запрос с сортировкой ID по убыванию
                else
                {
                    //using (SqlCommand cmd = new SqlCommand
                    //           ("SELECT  p.BusinessEntityID, [FirstName],[MiddleName],[LastName], [PhoneNumber] " +
                    //           "FROM [Person].[Person] as p " +
                    //           "join[Person].[PersonPhone] as ph on ph.BusinessEntityID = p.BusinessEntityID order by  p.BusinessEntityID desc ", cn))
                    using (SqlCommand cmd = new SqlCommand
                                                       ("SELECT  BusinessEntityID, [FirstName],[MiddleName],[LastName] " +
                        "FROM [Person].[Person] order by  BusinessEntityID desc ", cn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                            listBox.Items.Add(reader[0] + " " + reader[1] + " " + reader[2] + " " + reader[3]); //+ ", Tel: " + reader[4]);
                            }
                        }
                }
            }
        }

        //Добавить значение
        private void button1_Click(object sender, EventArgs e)
        {
            AddForm newForm = new AddForm();
            newForm.Show();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            DelForm newForm = new DelForm();
            newForm.Show();
        }
    }
}

