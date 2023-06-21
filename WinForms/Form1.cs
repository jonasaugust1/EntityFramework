using Data;
using Domain;

namespace WinForms
{
    public partial class Form1 : Form
    {
        private ProductDbContext context;

        public Form1()
        {
            InitializeComponent();

            context = new ProductDbContext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Store store = new("Test Store");

            context.Stores.Add(store);

            Product product = new("Test Product", 10m, store);

            context.Products.Add(product);

            context.SaveChanges();
        }
    }
}