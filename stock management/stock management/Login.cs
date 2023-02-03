using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stock_management
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=master;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dataReader;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
                tbxPass.UseSystemPasswordChar = true;
            else
                tbxPass.UseSystemPasswordChar = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("select * from Users where Username=@Username AND Password = @Password", con);
                cmd.Parameters.AddWithValue("@Username", tbxUser.Text);
                cmd.Parameters.AddWithValue("@Password", tbxPass.Text);
                con.Open();
                dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    MessageBox.Show("Welcome" , ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dashboard dashboard = new Dashboard();
                    dashboard.ShowDialog();
                }
                else {
                    MessageBox.Show("WRONG!!!!!!!!!",">:(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
