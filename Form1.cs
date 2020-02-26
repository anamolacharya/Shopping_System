using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;                //here i am importing the data

namespace Admin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)          //this method is for Exit button in Admin panel
        {

            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)          //this method is for Login Button in admin panel
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\anamo\Desktop\Shopping System\Admin\Data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;");
                                                                        //connecting the sql connection from the database
                                                                        //try t fix the data using data adaptar
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Login where Username='" + textBox1.Text + "' and Password = '" + textBox2.Text +"'",con);
            
            DataTable dt = new DataTable();                             //getting result in data table
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
            this.Hide();
            Main ss = new Main();
            ss.Show();
            }
            else
            {
                MessageBox.Show("Please Check your Username and Password");
            }
        }
    }
}
//USER
//12345