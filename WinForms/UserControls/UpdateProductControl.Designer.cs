namespace WinForms.UserControls
{
    partial class UpdateProductControl
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
            textBoxName = new TextBox();
            labelPrice = new Label();
            textBoxPrice = new TextBox();
            labelDescription = new Label();
            textBoxDescription = new TextBox();
            labelStore = new Label();
            DropDownStores = new ComboBox();
            btnUpdateProduct = new Button();
            label2 = new Label();
            DropDownProducts = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 17);
            label1.Name = "label1";
            label1.Size = new Size(186, 32);
            label1.TabIndex = 1;
            label1.Text = "Update Product";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.Location = new Point(377, 81);
            labelName.Name = "labelName";
            labelName.Size = new Size(49, 20);
            labelName.TabIndex = 2;
            labelName.Text = "Name";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(377, 104);
            textBoxName.MaxLength = 200;
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(228, 23);
            textBoxName.TabIndex = 5;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelPrice.Location = new Point(377, 144);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(41, 20);
            labelPrice.TabIndex = 7;
            labelPrice.Text = "Price";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(377, 167);
            textBoxPrice.MaxLength = 100;
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(228, 23);
            textBoxPrice.TabIndex = 8;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelDescription.Location = new Point(377, 204);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(85, 20);
            labelDescription.TabIndex = 11;
            labelDescription.Text = "Description";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(377, 227);
            textBoxDescription.MaxLength = 2000;
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(228, 77);
            textBoxDescription.TabIndex = 12;
            // 
            // labelStore
            // 
            labelStore.AutoSize = true;
            labelStore.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelStore.Location = new Point(377, 319);
            labelStore.Name = "labelStore";
            labelStore.Size = new Size(44, 20);
            labelStore.TabIndex = 13;
            labelStore.Text = "Store";
            // 
            // DropDownStores
            // 
            DropDownStores.FormattingEnabled = true;
            DropDownStores.Location = new Point(377, 342);
            DropDownStores.Name = "DropDownStores";
            DropDownStores.Size = new Size(228, 23);
            DropDownStores.TabIndex = 14;
            // 
            // btnUpdateProduct
            // 
            btnUpdateProduct.Location = new Point(377, 404);
            btnUpdateProduct.Name = "btnUpdateProduct";
            btnUpdateProduct.Size = new Size(228, 45);
            btnUpdateProduct.TabIndex = 15;
            btnUpdateProduct.Text = "Update";
            btnUpdateProduct.UseVisualStyleBackColor = true;
            btnUpdateProduct.Click += btnUpdateProduct_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(14, 81);
            label2.Name = "label2";
            label2.Size = new Size(130, 20);
            label2.TabIndex = 16;
            label2.Text = "Select the product";
            // 
            // DropDownProducts
            // 
            DropDownProducts.FormattingEnabled = true;
            DropDownProducts.Location = new Point(14, 104);
            DropDownProducts.Name = "DropDownProducts";
            DropDownProducts.Size = new Size(228, 23);
            DropDownProducts.TabIndex = 17;
            DropDownProducts.SelectedIndexChanged += DropDownProducts_SelectedIndexChanged;
            // 
            // UpdateProductControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DropDownProducts);
            Controls.Add(label2);
            Controls.Add(btnUpdateProduct);
            Controls.Add(DropDownStores);
            Controls.Add(labelStore);
            Controls.Add(textBoxDescription);
            Controls.Add(labelDescription);
            Controls.Add(textBoxPrice);
            Controls.Add(labelPrice);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            Controls.Add(label1);
            Name = "UpdateProductControl";
            Size = new Size(700, 470);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelName;
        private TextBox textBoxName;
        private Label labelPrice;
        private TextBox textBoxPrice;
        private Label labelDescription;
        private TextBox textBoxDescription;
        private Label labelStore;
        private ComboBox DropDownStores;
        private Button btnUpdateProduct;
        private Label label2;
        private ComboBox DropDownProducts;
    }
}
