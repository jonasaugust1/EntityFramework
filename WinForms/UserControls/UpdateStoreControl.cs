using Data;
using Domain;

namespace WinForms.UserControls
{
    public partial class UpdateStoreControl : UserControl
    {
        ProductDbContext Context;
        public UpdateStoreControl()
        {
            InitializeComponent();
            Context = new ProductDbContext();
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

        private void UpdateStoresDropDown(int oldStoreIndex, string storeUpdated)
        {
            DropDownStores.Items[oldStoreIndex] = storeUpdated;
        }

        private void PoupulateInputs()
        {
            Store store = SelectStore();

            if (store != null)
            {
                textBoxName.Text = store.Name;
                textBoxDescription.Text = store.Description;
            }
        }

        private Store SelectStore()
        {
            if (DropDownStores.SelectedItem != null)
            {
                string selectedStore = DropDownStores.SelectedItem.ToString();

                Store store = Context.Stores.FirstOrDefault(s => s.Name == selectedStore);

                return store;
            }

            return null;
        }

        private void DropDownStores_SelectedIndexChanged(object sender, EventArgs e)
        {
            PoupulateInputs();
        }

        private void btnUpdateStore_Click(object sender, EventArgs e)
        {

            Store store = SelectStore();

            int storeIndex = DropDownStores.SelectedIndex;

            try
            {
                store.Name = textBoxName.Text;

                store.Description = textBoxDescription.Text;

                Context.SaveChanges();

                Context.Entry(store).Reload();

                UpdateStoresDropDown(storeIndex, store.Name);

                MessageBox.Show("Store updated with success.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Alert", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                textBoxName.Text = String.Empty;
                textBoxDescription.Text = String.Empty;
                DropDownStores.SelectedItem = null;
            }
        }
    }
}
