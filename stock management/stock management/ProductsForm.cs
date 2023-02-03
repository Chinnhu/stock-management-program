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
    public partial class ProductsForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=master;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dataReader;

        public ProductsForm()
        {
            InitializeComponent();
            LoadProduct();
        }
        public void LoadProduct()
        {
            dataGridProducts.Rows.Clear();
            cmd = new SqlCommand("SELECT * FROM [Products]", con);
            con.Open();

            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                dataGridProducts.Rows.Add(dataReader[0].ToString(), dataReader[1].ToString(), dataReader[2].ToString(),
                    dataReader[3].ToString(), dataReader[4].ToString(), dataReader[5].ToString());
            }
            dataReader.Close();
            con.Close();

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            ProductsEditorForm productsForm = new ProductsEditorForm();
            productsForm.saveBtn.Enabled = true;
            productsForm.updateBtn.Enabled = false;
            productsForm.ShowDialog();
            LoadProduct();

        }

        private void dataGridProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridProducts.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                ProductsEditorForm productEditor = new ProductsEditorForm();
                productEditor.textBoxId.Text = dataGridProducts.Rows[e.RowIndex].Cells[0].Value.ToString();
                productEditor.textBoxProductName.Text = dataGridProducts.Rows[e.RowIndex].Cells[1].Value.ToString();
                productEditor.textBoxQuantity.Text = dataGridProducts.Rows[e.RowIndex].Cells[2].Value.ToString();
                productEditor.textBoxPrice.Text = dataGridProducts.Rows[e.RowIndex].Cells[3].Value.ToString();
                productEditor.textBoxDescription.Text = dataGridProducts.Rows[e.RowIndex].Cells[4].Value.ToString();
                productEditor.comboBoxCategory.Text = dataGridProducts.Rows[e.RowIndex].Cells[5].Value.ToString();

                productEditor.saveBtn.Enabled = false;
                productEditor.updateBtn.Enabled = true;

                productEditor.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this product?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();

                    cmd = new SqlCommand($"DELETE FROM [Products] WHERE [ProductId] LIKE '{dataGridProducts.Rows[e.RowIndex].Cells[0].Value}'", con);
                    cmd.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Record has been successfully deleted!");
                }
            }

            LoadProduct();
        }
    }
}
