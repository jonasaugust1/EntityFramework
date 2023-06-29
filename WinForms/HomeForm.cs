using Data;
using WinForms.UserControls;

namespace WinForms
{
    public partial class HomeForm : Form
    {
        NavigationControl NavigationControl;
        NavigationButtons NavigationButtons;

        Color BtnDefaultColor = Color.FromKnownColor(KnownColor.ControlLight);
        Color BtnSelectedColor = Color.FromKnownColor(KnownColor.ControlDark);

        AddProductControl AddProductControl = new();
        AddStoreControl AddStoreControl = new();
        UpdateStoreControl UpdateStoreControl  = new();
        UpdateProductControl UpdateProductControl = new();
        StoresControl StoresControl = new();
        ProductsControl ProductsControl = new();
        DeleteStoreControl DeleteStoreControl = new();
        DeleteProductControl DeleteProductControl = new();

        public HomeForm()
        {
            InitializeComponent();
            InitializeNavigationControl();
            InitializeNavigationButton();
        }

        private void InitializeNavigationControl()
        {
            List<UserControl> usersControls = new() 
            {
               AddProductControl,
               AddStoreControl,
               UpdateStoreControl,
               UpdateProductControl,
               StoresControl,
               ProductsControl,
               DeleteStoreControl,
               DeleteProductControl
            };

            NavigationControl = new(usersControls, panel2);
            NavigationControl.Display(1); // display AddStoreControl as default
        }

        private void InitializeNavigationButton()
        {
            List<Button> buttons = new() 
            { 
                btnAddProduct, 
                btnAddStore,
                btnEditStore,
                btnEditProduct,
                btnStores,
                btnProducts,
                btnDeleteStore,
                btnDeleteProduct,
            };

            NavigationButtons = new(buttons, BtnDefaultColor, BtnSelectedColor);
            NavigationButtons.Highlight(btnAddStore);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            NavigationControl.Display(0);
            NavigationButtons.Highlight(btnAddProduct);

            AddProductControl.PopulateDropDown();
        }

        private void btnAddStore_Click(object sender, EventArgs e)
        {
            NavigationControl.Display(1);
            NavigationButtons.Highlight(btnAddStore);
        }

        private void btnEditStore_Click(object sender, EventArgs e)
        {
            NavigationControl.Display(2);
            NavigationButtons.Highlight(btnEditStore);

            UpdateStoreControl.PopulateStoresDropDown();
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            NavigationControl.Display(3);
            NavigationButtons.Highlight(btnEditProduct);

            UpdateProductControl.PopulateStoresDropDown();
            UpdateProductControl.PopulateProductsDropDown();
        }

        private void btnStores_Click(object sender, EventArgs e)
        {
            NavigationControl.Display(4);
            NavigationButtons.Highlight(btnStores);

            StoresControl.PopulateGrid();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            NavigationControl.Display(5);
            NavigationButtons.Highlight(btnProducts);

            ProductsControl.PopulateGrid();
        }

        private void btnDeleteStore_Click(object sender, EventArgs e)
        {
            NavigationControl.Display(6);
            NavigationButtons.Highlight(btnDeleteStore);

            DeleteStoreControl.PopulateStoresDropDown();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            NavigationControl.Display(7);
            NavigationButtons.Highlight(btnDeleteStore);

            DeleteProductControl.PopulateProductsDropDown();
        }
    }
}