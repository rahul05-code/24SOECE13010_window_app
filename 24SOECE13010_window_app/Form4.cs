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

namespace _24SOECE13010_window_app
{
    public partial class Form4 : Form
    {
        string gender;
        string cn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\kanza\\source\\repos\\24SOECE13010_window_app\\24SOECE13010_window_app\\Database4.mdf;Integrated Security=True";
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cn);

            con.Open();
            string query = "insert into register values('"+textBox1.Text+"','"+textBox2.Text+"','"+comboBox1.SelectedItem.ToString()+"','"+comboBox2.SelectedItem.ToString()+"','"+gender+"')";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Registered successfully !");


            con.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }
    }
}
