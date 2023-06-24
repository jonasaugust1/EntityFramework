namespace WinForms
{
    public class NavigationButtons
    {
        List<Button> Buttons;
        Color DefaultColor;
        Color SelectedColor;

        public NavigationButtons(List<Button> buttons, Color defaultColor, Color selectedColor)
        {
            Buttons = buttons;
            DefaultColor = defaultColor;
            SelectedColor = selectedColor;
            SetButtonColor();
        }

        private void SetButtonColor()
        {
            foreach (Button button in Buttons)
            {
                button.BackColor = DefaultColor;
            }
        }

        public void Highlight(Button selectedButton)
        {
            foreach(Button button in Buttons)
            {
                button.BackColor = button == selectedButton ? SelectedColor : DefaultColor; 
            }
        }
    }
}
