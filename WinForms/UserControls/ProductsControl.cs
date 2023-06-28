using Data;

namespace WinForms.UserControls
{
    public partial class ProductsControl : UserControl
    {
        ProductDbContext Context;
        public ProductsControl()
        {
            InitializeComponent();
            Context = new ProductDbContext();
        }

        public void PopulateGrid()
        {
            Context.SaveChanges();
            dataGridView.DataSource = Context.Products.ToList();
        }
    }
}
