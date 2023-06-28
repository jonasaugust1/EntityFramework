using Data;
using Domain;
using System.Windows.Forms;

namespace WinForms.UserControls
{
    public partial class AddStoreControl : UserControl
    {
        ProductDbContext Context;

        public AddStoreControl()
        {
            InitializeComponent();
            Context = new ProductDbContext();
        }

        private void btnSaveStore_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBoxName.Text;

                Store store = new(name);

                store.Description = textBoxDescription.Text;

                Context.Stores.Add(store);
                Context.SaveChanges();

                MessageBox.Show("Store saved with success.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Alert", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                textBoxName.Text = String.Empty;
                textBoxDescription.Text = String.Empty;
            }
        }
    }
}
