using Data;
using Domain;

namespace WinForms.UserControls
{
    public partial class DeleteStoreControl : UserControl
    {
        ProductDbContext Context;
        public DeleteStoreControl()
        {
            InitializeComponent();
            Context = new ProductDbContext();
        }

        public void PopulateStoresDropDown()
        {
            List<Store> stores = Context.Stores.ToList();

            foreach (Store store in stores)
            {
                Context.Entry(store).Reload();

                if(!DropDownStores.Items.Contains(store.Name))
                {
                    DropDownStores.Items.Add(store.Name);
                }
            }
        }

        private void UpdateStoresDropDown(int oldStoreIndex)
        {
            var store = DropDownStores.Items[oldStoreIndex];

            DropDownStores.Items.Remove(store);
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

        private void btnDeleteStore_Click(object sender, EventArgs e)
        {
            Store store = SelectStore();

            int storeIndex = DropDownStores.SelectedIndex;

            try
            {
                if (store == null)
                {
                    throw new Exception("Store doesn't exists.");
                }

                DialogResult result = MessageBox.Show($"Are you sure you want to delete {store.Name}?", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                if (result == DialogResult.OK)
                {
                    Context.Stores.Remove(store);

                    Context.SaveChanges();

                    UpdateStoresDropDown(storeIndex);

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
