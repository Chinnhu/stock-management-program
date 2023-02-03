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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace stock_management
{
    public partial class CategoryEditorForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=master;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        public CategoryEditorForm()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this category?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("INSERT INTO [Category]([Name], [Discription])VALUES(@Name, @Discription)", con);
                    cmd.Parameters.AddWithValue("@Name", textBoxCategoryName.Text);
                    cmd.Parameters.AddWithValue("@Discription", textBoxCategoryDiscription.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Category has been saved!");
                    Clear();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Clear()
        {
            textBoxCategoryName.Clear();
            textBoxCategoryDiscription.Clear();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            Clear();
            saveBtn.Enabled = true;
            updateBtn.Enabled = false;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this category?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand($"UPDATE [Category] SET [Name] = @Name, [Discription] = @Discription WHERE [CategoryId] LIKE '{textBoxCategoryId.Text}' ", con);
                    cmd.Parameters.AddWithValue("@Name", textBoxCategoryName.Text);
                    cmd.Parameters.AddWithValue("@Discription", textBoxCategoryDiscription.Text);                   

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Category has been successfully updated.");
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
