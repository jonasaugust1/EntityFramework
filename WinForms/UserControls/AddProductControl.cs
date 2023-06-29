using Data;
using Domain;
using System.Data.Entity;

namespace WinForms.UserControls
{
    public partial class AddProductControl : UserControl
    {
        ProductDbContext Context;

        public AddProductControl()
        {
            InitializeComponent();
            Context = new ProductDbContext();
        }
 
        public void PopulateDropDown()
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

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBoxName.Text;

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
                    Product product = new(name, price, store);

                    product.Description = textBoxDescription.Text;

                    Context.Products.Add(product);

                    Context.SaveChanges();

                    MessageBox.Show("Product saved with success.", "Success",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                textBoxName.Text = String.Empty;
                textBoxDescription.Text = String.Empty;
                textBoxPrice.Text = String.Empty;
                DropDownStores.SelectedItem = null;
            }
        }

        private bool IsControlInFront(Control control)
        {
            if (control.Parent != null)
            {
                int controlIndex = control.Parent.Controls.GetChildIndex(control);
                int topControlIndex = control.Parent.Controls.GetChildIndex(control.Parent.Controls[control.Parent.Controls.Count - 1]);


                return (controlIndex == topControlIndex);
            }

            return false;
        }
    }
}
