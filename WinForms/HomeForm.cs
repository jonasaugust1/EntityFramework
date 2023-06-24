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

        public HomeForm()
        {
            InitializeComponent();
            InitializeNavigationControl();
            InitializeNavigationButton();
        }

        private void InitializeNavigationControl()
        {
            List<UserControl> usersControls = new() {new AddProductControl(), new AddStoreControl() };

            NavigationControl = new(usersControls, panel2);
            NavigationControl.Display(1); // display AddStoreControl as default
        }

        private void InitializeNavigationButton()
        {
            List<Button> buttons = new() { btnAddProduct, btnAddStore };

            NavigationButtons = new(buttons, BtnDefaultColor, BtnSelectedColor);
            NavigationButtons.Highlight(btnAddStore);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
           NavigationControl.Display(0);
            NavigationButtons.Highlight(btnAddProduct);
        }

        private void btnAddStore_Click(object sender, EventArgs e)
        {
            NavigationControl.Display(1);
            NavigationButtons.Highlight(btnAddStore);
        }
    }
}