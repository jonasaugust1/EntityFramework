namespace WinForms.UserControls
{
    partial class AddProductControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            labelName = new Label();
            textBoxPrice = new TextBox();
            textBoxName = new TextBox();
            labelStore = new Label();
            labelPrice = new Label();
            DropDownStores = new ComboBox();
            btnSaveProduct = new Button();
            labelDescription = new Label();
            textBoxDescription = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(17, 14);
            label1.Name = "label1";
            label1.Size = new Size(150, 32);
            label1.TabIndex = 0;
            label1.Text = "Add Product";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.Location = new Point(17, 67);
            labelName.Name = "labelName";
            labelName.Size = new Size(49, 20);
            labelName.TabIndex = 1;
            labelName.Text = "Name";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(17, 149);
            textBoxPrice.MaxLength = 100;
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(228, 23);
            textBoxPrice.TabIndex = 3;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(17, 90);
            textBoxName.MaxLength = 200;
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(228, 23);
            textBoxName.TabIndex = 4;
            // 
            // labelStore
            // 
            labelStore.AutoSize = true;
            labelStore.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelStore.Location = new Point(17, 300);
            labelStore.Name = "labelStore";
            labelStore.Size = new Size(44, 20);
            labelStore.TabIndex = 5;
            labelStore.Text = "Store";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelPrice.Location = new Point(17, 126);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(41, 20);
            labelPrice.TabIndex = 6;
            labelPrice.Text = "Price";
            // 
            // DropDownStores
            // 
            DropDownStores.FormattingEnabled = true;
            DropDownStores.Location = new Point(17, 323);
            DropDownStores.Name = "DropDownStores";
            DropDownStores.Size = new Size(228, 23);
            DropDownStores.TabIndex = 7;
            // 
            // btnSaveProduct
            // 
            btnSaveProduct.Location = new Point(17, 379);
            btnSaveProduct.Name = "btnSaveProduct";
            btnSaveProduct.Size = new Size(228, 45);
            btnSaveProduct.TabIndex = 9;
            btnSaveProduct.Text = "Save";
            btnSaveProduct.UseVisualStyleBackColor = true;
            btnSaveProduct.Click += btnSaveProduct_Click;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelDescription.Location = new Point(17, 186);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(85, 20);
            labelDescription.TabIndex = 10;
            labelDescription.Text = "Description";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(17, 209);
            textBoxDescription.MaxLength = 2000;
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(228, 77);
            textBoxDescription.TabIndex = 11;
            // 
            // AddProductControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(textBoxDescription);
            Controls.Add(labelDescription);
            Controls.Add(btnSaveProduct);
            Controls.Add(DropDownStores);
            Controls.Add(labelPrice);
            Controls.Add(labelStore);
            Controls.Add(textBoxName);
            Controls.Add(textBoxPrice);
            Controls.Add(labelName);
            Controls.Add(label1);
            Name = "AddProductControl";
            Size = new Size(700, 470);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelName;
        private TextBox textBoxName;
        private TextBox textBoxPrice;
        private Label labelStore;
        private Label labelPrice;
        private ComboBox DropDownStores;
        private Button btnSaveProduct;
        private Label labelDescription;
        private TextBox textBoxDescription;
    }
}
