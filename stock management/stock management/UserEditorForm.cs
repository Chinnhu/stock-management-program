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
    public partial class UserEditorForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=localhost;Persist Security Info=True;User ID=sa;Password=Loktar00");
        SqlCommand cmd = new SqlCommand();

        public UserEditorForm()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Are you sure you want to save this user?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("INSERT INTO [Users](Username, FullName, Password, Phone)VALUES(@Username, @FullName, @Password, @Phone)", con);
                    cmd.Parameters.AddWithValue("@Username", textBoxUsername.Text);
                    cmd.Parameters.AddWithValue("@FullName", textBoxFullName.Text);
                    cmd.Parameters.AddWithValue("@Password", textBoxPass.Text);
                    cmd.Parameters.AddWithValue("@Phone", textBoxPhone.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("User has been saved!");
                    Clear();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            textBoxUsername.Clear();
            textBoxFullName.Clear();
            textBoxPass.Clear();
            textBoxPhone.Clear();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this user?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand($"UPDATE [Users] SET Username = @Username, FullName = @FullName, Password = @Password, Phone = @Phone WHERE [Id] LIKE '{textBoxId.Text}' ", con);
                    cmd.Parameters.AddWithValue("@Username", textBoxUsername.Text);
                    cmd.Parameters.AddWithValue("@FullName", textBoxFullName.Text);
                    cmd.Parameters.AddWithValue("@Password", textBoxPass.Text);
                    cmd.Parameters.AddWithValue("@Phone", textBoxPhone.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("User has been successfully updated.");
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
