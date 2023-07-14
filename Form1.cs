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
using System.Threading;

namespace MultiLanguageSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=desktop-feug4aj\\sqlexpress;" +
                "Initial Catalog=userregcs;Integrated Security = True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[register]
                ([firstname]
                ,[lastname]
                ,[address]
                ,[Gender]
                ,[email]
                ,[phone]
                ,[username]
                ,[password])
              VALUES

                ('" + txtFname.Text + "', '" + txtLname.Text + "', '" + txtAdd.Text + "', '" + cmbGender.SelectedItem.
                ToString() + "', '" + txtEmail.Text + "','" + txtPhone.Text + "','" + txtUser.Text +"','"+txtPass.Text+"')", con);
                con.Open();
                cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Register Successfully");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
                    break;
                case 1:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es");
                    break;
                case 2:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("fr");
                    break;
            }
            this.Controls.Clear();
            InitializeComponent();

        }
    }
}
