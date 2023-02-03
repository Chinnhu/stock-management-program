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
    public partial class ProductsEditorForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=master;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dataReader;
        public ProductsEditorForm()
        {
            InitializeComponent();
            LoadCategory();
        }

        public void LoadCategory()
        {
            comboBoxCategory.Items.Clear();
            cmd = new SqlCommand("SELECT CategoryId FROM [Category]", con);
            con.Open();
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                comboBoxCategory.Items.Add(dataReader[0].ToString());
            }
            dataReader.Close();
            con.Close();

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this product?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("INSERT INTO [Products](ProductName, Quantity, Price, Discription, CategoryId) VALUES(@ProductName, @Quantity, @Price, @Discription, @CategoryId)", con);
                    cmd.Parameters.AddWithValue("@ProductName", textBoxProductName.Text);
                    cmd.Parameters.AddWithValue("@Quantity", textBoxQuantity.Text);
                    cmd.Parameters.AddWithValue("@Price", textBoxPrice.Text);
                    cmd.Parameters.AddWithValue("@Discription", textBoxDescription.Text);
                    cmd.Parameters.AddWithValue("@CategoryId", comboBoxCategory.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Product has been saved!");
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        public void Clear()
        {
            textBoxProductName.Clear();
            textBoxQuantity.Clear();
            textBoxPrice.Clear();
            textBoxDescription.Clear();
            comboBoxCategory.Text = "";
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
                if (MessageBox.Show("Are you sure you want to update this product?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand($"UPDATE [Products] SET ProductName = @ProductName, Quantity = @Quantity, Price = @Price, Discription = @Discription WHERE [ProductId] LIKE '{textBoxId.Text}' ", con);
                    cmd.Parameters.AddWithValue("@ProductName", textBoxProductName.Text);
                    cmd.Parameters.AddWithValue("@Quantity", textBoxQuantity.Text);
                    cmd.Parameters.AddWithValue("@Price", textBoxPrice.Text);
                    cmd.Parameters.AddWithValue("@Discription", textBoxDescription.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Product has been successfully updated.");
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
