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
    public partial class DelForm : Form
    {
        public DelForm()
        {
            InitializeComponent();
        }

        private void button2Del_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=AdventureWorks2017;Data Source=."))
            {
                cn.Open();
                string tex = textBox1.Text.ToString();
                if (tex.IndexOf(',') == 0)
                
                using (SqlCommand cmd = new SqlCommand
                     ("DELETE FROM [Person].[Person] " +
                     $"WHERE BusinessEntityID = {tex}", cn))
                    cmd.ExecuteNonQuery();

                else
                {
                    using (SqlCommand cmd = new SqlCommand
                     ("DELETE FROM [Person].[Person] " +
                     $"WHERE BusinessEntityID in ({tex})", cn))
                        cmd.ExecuteNonQuery();
                }

            }
            
            Close();
        }
    }
}