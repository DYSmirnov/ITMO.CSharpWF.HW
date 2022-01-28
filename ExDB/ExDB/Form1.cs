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



        //Запрос
        private void buttonQuery_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            using (SqlConnection cn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CSharpDB;Data Source=."))
            {
                cn.Open();

                //запрос с сортировкой ID по возрастанию
                if (checkBoxSort.Checked == true)

                    using (SqlCommand cmd = new SqlCommand
                        ("SELECT  c.ID, [First Name],[Last Name] , p.Phone " +
                        "FROM [dbo].[Contact] as c full join [dbo].[Phone] as p on	c.ID  = p.ID order by  ID ", cn))

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listBox.Items.Add(reader[0] + " " + reader[1] + " " + reader[2] + " " + reader[3]); 
                        }
                    }


                //запрос с сортировкой ID по убыванию
                else
                {
                    using (SqlCommand cmd = new SqlCommand
                        ("SELECT  c.ID, [First Name],[Last Name] , p.Phone " +
                        "FROM [dbo].[Contact] as c full join [dbo].[Phone] as p on	c.ID  = p.ID order by  ID desc", cn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                            listBox.Items.Add(reader[0] + " " + reader[1] + " " + reader[2] + " " + reader[3]); 
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

        //удалить значение
        private void buttonDel_Click(object sender, EventArgs e)
        {
            DelForm newForm = new DelForm();
            newForm.Show();
        }
    }
}

