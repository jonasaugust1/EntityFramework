using Data;
using Domain;
using System.Data.Entity;

namespace WinForms.UserControls
{
    public partial class UpdateProductControl : UserControl
    {
        ProductDbContext Context;
        public UpdateProductControl()
        {
            InitializeComponent();
            Context = new ProductDbContext();
        }

        public void PopulateProductsDropDown()
        {
            List<Product> products = Context.Products.ToList();

            foreach (Product product in products)
            {
                if(!DropDownProducts.Items.Contains(product.Name))
                {
                    DropDownProducts.Items.Add(product.Name);
                }
            }
        }

        public void PopulateStoresDropDown()
        {
            List<Store> stores = Context.Stores.ToList();

            foreach (Store store in stores)
            {
                if(!DropDownStores.Items.Contains(store.Name))
                {
                    DropDownStores.Items.Add(store.Name);
                }
            }
        }

        private void PoupulateInputs()
        {
            Product product = SelectProduct();

            if (product != null)
            {
                textBoxName.Text = product.Name;
                textBoxPrice.Text = product.Price.ToString();
                textBoxDescription.Text = product.Description;
                DropDownStores.SelectedItem = product.Store.Name;
            }
        }

        private void UpdateProductsDropDown(int oldProductIndex, string productUpdated)
        {
            DropDownProducts.Items[oldProductIndex] = productUpdated;
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

        private void DropDownProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            PoupulateInputs();
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            Product product = SelectProduct();

            int productIndex = DropDownProducts.SelectedIndex;

            try
            {
                if (!decimal.TryParse(textBoxPrice.Text, out decimal price))
                {
                    throw new Exception("Price must be a valid number.");
                }

                if (DropDownStores.SelectedIndex == -1)
                {
                    throw new Exception("Store is required.");
                }

                string selectedStore = DropDownStores.SelectedItem.ToString();

                Store store = Context.Stores.FirstOrDefault(s => s.Name == selectedStore);

                if (store != null)
                {
                    product.Name = textBoxName.Text;
                    product.Price = price;
                    product.Description = textBoxDescription.Text;
                    product.Store = store;

                    Context.SaveChanges();

                    UpdateProductsDropDown(productIndex, product.Name);

                    MessageBox.Show("Product updated with success.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                textBoxName.Text = String.Empty;
                textBoxPrice.Text = String.Empty;
                textBoxDescription.Text = String.Empty;
                DropDownStores.SelectedItem = null;
                DropDownProducts.SelectedItem = null;
            }
        }
    }
}
