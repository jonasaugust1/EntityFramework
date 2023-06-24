using Data;
using Domain;
using WinForms;

namespace AddProductForm
{
    public partial class ProductForm : Form
    {
        private ProductDbContext context;

        public ProductForm()
        {
            InitializeComponent();
        }

        private void DropDownStores_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Store> stores = context.Stores.ToList();

            foreach (Store store in stores)
            {
                DropDownStores.Items.Add(store);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBoxName.Text;

                if (!decimal.TryParse(textBoxPrice.Text, out decimal price))
                {
                    throw new Exception("Price must be a valid number.");
                }

                Store? store = DropDownStores.SelectedItem as Store;

                if (store == null)
                {
                    throw new Exception("You must select a store.");
                }

                Product product = new(name, price, store);

                context.Products.Add(product);

                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Alert", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            using(Factory home = new())
            {
                DialogResult result = home.ShowDialog();
            }
        }
    }
}