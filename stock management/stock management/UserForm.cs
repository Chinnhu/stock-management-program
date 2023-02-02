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
    public partial class UserForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=localhost;Persist Security Info=True;User ID=sa;Password=Loktar00");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dataReader;

        public UserForm()
        {
            InitializeComponent();
            LoadUser();
        }

        public void LoadUser()
        {         
            dataGridUsers.Rows.Clear();
            cmd = new SqlCommand("SELECT * FROM [Users]", con);
            con.Open();

            dataReader = cmd.ExecuteReader();
            while(dataReader.Read())
            {              
                dataGridUsers.Rows.Add(dataReader[0].ToString(), dataReader[1].ToString(), dataReader[2].ToString(), dataReader[3].ToString(), dataReader[4].ToString());
            }

            dataReader.Close();
            con.Close();
            
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            UserEditorForm userEditor = new UserEditorForm();
            userEditor.saveBtn.Enabled = true;
            userEditor.updateBtn.Enabled = false;
            userEditor.ShowDialog();
        }

        private void dataGridUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridUsers.Columns[e.ColumnIndex].Name;
            if(colName == "Edit")
            {
                UserEditorForm userEditor = new UserEditorForm();
                userEditor.textBoxId.Text = dataGridUsers.Rows[e.RowIndex].Cells[0].Value.ToString();
                userEditor.textBoxUsername.Text = dataGridUsers.Rows[e.RowIndex].Cells[1].Value.ToString();
                userEditor.textBoxFullName.Text = dataGridUsers.Rows[e.RowIndex].Cells[2].Value.ToString();
                userEditor.textBoxPass.Text = dataGridUsers.Rows[e.RowIndex].Cells[3].Value.ToString();
                userEditor.textBoxPhone.Text = dataGridUsers.Rows[e.RowIndex].Cells[4].Value.ToString();

                userEditor.saveBtn.Enabled = false;
                userEditor.updateBtn.Enabled = true;

                userEditor.ShowDialog();
            }
            else if(colName == "Delete")
            {
                if(MessageBox.Show("Are you sure you want to delete this user?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();

                    cmd = new SqlCommand($"DELETE FROM [Users] WHERE [Id] LIKE '{dataGridUsers.Rows[e.RowIndex].Cells[0].Value}'", con);
                    cmd.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Record has been successfully deleted!");
                }
            }

            LoadUser();
        }
    }
}
