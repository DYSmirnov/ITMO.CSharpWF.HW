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
            using (SqlConnection cn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=AdventureWorks2017;Data Source=."))
            {
                cn.Open();


                using (SqlCommand cmd = new SqlCommand
                     ("INSERT INTO [Person].[Person] " +
                     "([BusinessEntityID],[PersonType],[NameStyle],[FirstName],[LastName],[EmailPromotion] ,[rowguid],[ModifiedDate])" +
                     " VALUES ((select max([BusinessEntityID]) from [Person].[Person])+1," +
                     $"'EM', 0, '{textBoxFName.Text}', '{textBoxLName.Text}', 0, NEWID(), GETDATE())", cn))
                    cmd.ExecuteNonQuery();

            }
            Close();
        }
    }
}

