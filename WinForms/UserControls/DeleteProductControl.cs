using Data;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.UserControls
{
    public partial class DeleteProductControl : UserControl
    {
        ProductDbContext Context;

        public DeleteProductControl()
        {
            InitializeComponent();
            Context = new ProductDbContext();
        }


        private void DeleteProductControl_Load(object sender, EventArgs e)
        {
            PopulateProductsDropDown();
        }

        private void PopulateProductsDropDown()
        {
            List<Product> products = Context.Products.ToList();

            foreach (Product product in products)
            {
                DropDownProducts.Items.Add(product.Name);
            }
        }

        private void UpdateProductsDropDown(int oldProductIndex)
        {
            var product = DropDownProducts.Items[oldProductIndex];

            DropDownProducts.Items.Remove(product);
        }

        private Product SelectProduct()
        {
            if (DropDownProducts.SelectedItem != null)
            {
                string selectedProduct = DropDownProducts.SelectedItem.ToString();

                Product product = Context.Products.FirstOrDefault(p => p.Name == selectedProduct);

                return product;
            }

            return null;
        }

        private void btnDeleteStore_Click(object sender, EventArgs e)
        {
            Product product = SelectProduct();

            int productIndex = DropDownProducts.SelectedIndex;

            try
            {
                if (product == null)
                {
                    throw new Exception("Product doesn't exists.");
                }

                DialogResult result = MessageBox.Show($"Are you sure you want to delete {product.Name}?", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                if (result == DialogResult.OK)
                {
                    Context.Products.Remove(product);

                    Context.SaveChanges();

                    UpdateProductsDropDown(productIndex);

                    MessageBox.Show("Product deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
