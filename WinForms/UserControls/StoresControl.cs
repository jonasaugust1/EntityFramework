using Data;

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
            Context.SaveChanges();
            dataGridView.DataSource = Context.Stores.ToList();
        }
    }
}
