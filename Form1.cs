using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace emplogin
{
    public partial class Form1 : Form
    {
        private SqlConnection cn;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Naimishcs\emplogin\emplogin\bin\Debug\bin\ddb.mdf;Integrated Security=True;User Instance=True");
            string Sql="Select * from Table1 where Username='"+textBox1.Text+"' and Password='"+textBox2.Text+"'";
            SqlDataAdapter da = new SqlDataAdapter(Sql,cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                Home H=new Home();
                H.Show();
                this.Hide();
            }
            else
            {
                
            }


        }

    }
}
