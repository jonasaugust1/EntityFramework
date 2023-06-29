using Data;
using Domain;
using System.Data.Entity;

namespace WinForms.UserControls
{
    public partial class StoresControl : UserControl
    {
        ProductDbContext Context;
        public StoresControl()
        {
            InitializeComponent();
            Context = new ProductDbContext();
        }

        public void PopulateGrid()
        {
            List<Store> stores = Context.Stores.ToList();

            foreach (Store store in stores)
            {
                Context.Entry(store).Reload();
            }

            dataGridView.DataSource = stores;
        }
    }
}
