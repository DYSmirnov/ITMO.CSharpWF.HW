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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void button2Add_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CSharpDB;Data Source=."))
            {
                cn.Open();


                using (SqlCommand cmd = new SqlCommand
                     ("INSERT INTO [dbo].[Contact] " +
                     "(ID, [First Name],[Last Name])" +
                     " VALUES ((select max([ID]) from [dbo].[Contact])+1," +
                     $"'{textBoxFName.Text}', '{textBoxLName.Text}')", cn))
                    cmd.ExecuteNonQuery();
                using (SqlCommand cmd = new SqlCommand
                 ("INSERT INTO [dbo].[Phone] " +
                    "([ID], [Phone])" +
                    " VALUES ((select max([ID]) from [dbo].[Contact])+1," +
                 $"'{textBoxPhone.Text}')", cn))
                    cmd.ExecuteNonQuery();

            }
            Close();
        }
    }
}

