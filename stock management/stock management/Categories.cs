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
    public partial class Categories : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=localhost;Persist Security Info=True;User ID=sa;Password=Loktar00");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dataReader;

        public Categories()
        {
            InitializeComponent();
            LoadCategory();
        }

        public void LoadCategory()
        {
            dataGridCategory.Rows.Clear();
            cmd = new SqlCommand("SELECT * FROM [Category]", con);
            con.Open();

            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                dataGridCategory.Rows.Add(dataReader[0].ToString(), dataReader[1].ToString(), dataReader[2].ToString());
            }

            dataReader.Close();
            con.Close();

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            CategoryEditorForm categoryEditor = new CategoryEditorForm();
            categoryEditor.saveBtn.Enabled = true;
            categoryEditor.updateBtn.Enabled = false;
            categoryEditor.ShowDialog();
            LoadCategory();
        }

        private void dataGridCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridCategory.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                CategoryEditorForm categoryEditor = new CategoryEditorForm();
                categoryEditor.textBoxCategoryId.Text = dataGridCategory.Rows[e.RowIndex].Cells[0].Value.ToString();
                categoryEditor.textBoxCategoryName.Text = dataGridCategory.Rows[e.RowIndex].Cells[1].Value.ToString();
                categoryEditor.textBoxCategoryDiscription.Text = dataGridCategory.Rows[e.RowIndex].Cells[2].Value.ToString();

                categoryEditor.saveBtn.Enabled = false;
                categoryEditor.updateBtn.Enabled = true;

                categoryEditor.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this category?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();

                    cmd = new SqlCommand($"DELETE FROM [Category] WHERE [CategoryId] LIKE '{dataGridCategory.Rows[e.RowIndex].Cells[0].Value}'", con);
                    cmd.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Record has been successfully deleted!");
                }
            }

            LoadCategory();
        }
    }
}
