using Data;
using Domain;

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
            List<Product> products = Context.Products.ToList();

            foreach (Product product in products)
            {
                Context.Entry(product).Reload();
            }
            
            dataGridView.DataSource = products;
        }
    }
}
