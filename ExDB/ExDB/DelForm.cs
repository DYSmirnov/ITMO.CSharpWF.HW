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
            using (SqlConnection cn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CSharpDB;Data Source=."))
            {
                cn.Open();
                string tex = textBox1.Text.ToString();
                if (tex.IndexOf(',') == 0)

                    using (SqlCommand cmd = new SqlCommand
                     ("DELETE FROM [dbo].[Contact] " +
                     $"WHERE ID = {tex}", cn))
                        cmd.ExecuteNonQuery();
                if (tex.IndexOf(',') == 0)
                    using (SqlCommand cmd = new SqlCommand
                ("DELETE FROM [dbo].[Phone] " +
                    $"WHERE ID = {tex}", cn))
                    cmd.ExecuteNonQuery();

                if (tex.IndexOf(',') != 0)
                
                    using (SqlCommand cmd = new SqlCommand
                     ("DELETE FROM [dbo].[Contact] " +
                     $"WHERE ID in ({tex})", cn)) cmd.ExecuteNonQuery();
                if (tex.IndexOf(',') != 0)
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM [dbo].[Phone] " +
                     $"WHERE ID in ({tex})", cn))
                        cmd.ExecuteNonQuery();
                

            }
            
            Close();
        }
    }
}