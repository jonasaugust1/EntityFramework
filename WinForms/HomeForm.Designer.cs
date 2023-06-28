namespace WinForms
{
    partial class HomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAddProduct = new Button();
            btnAddStore = new Button();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnDeleteStore = new Button();
            btnProducts = new Button();
            btnStores = new Button();
            btnEditProduct = new Button();
            btnEditStore = new Button();
            btnDeleteProduct = new Button();
            panel2 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(3, 71);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(190, 55);
            btnAddProduct.TabIndex = 0;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // btnAddStore
            // 
            btnAddStore.Location = new Point(3, 3);
            btnAddStore.Name = "btnAddStore";
            btnAddStore.Size = new Size(190, 55);
            btnAddStore.TabIndex = 1;
            btnAddStore.Text = "Add Store";
            btnAddStore.UseVisualStyleBackColor = true;
            btnAddStore.Click += btnAddStore_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 511);
            panel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnDeleteStore, 0, 6);
            tableLayoutPanel1.Controls.Add(btnProducts, 0, 5);
            tableLayoutPanel1.Controls.Add(btnStores, 0, 4);
            tableLayoutPanel1.Controls.Add(btnEditProduct, 0, 3);
            tableLayoutPanel1.Controls.Add(btnEditStore, 0, 2);
            tableLayoutPanel1.Controls.Add(btnDeleteProduct, 0, 7);
            tableLayoutPanel1.Controls.Add(btnAddStore, 0, 0);
            tableLayoutPanel1.Controls.Add(btnAddProduct, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.757576F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 49.242424F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 63F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 61F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 63F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(196, 509);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnDeleteStore
            // 
            btnDeleteStore.Location = new Point(3, 388);
            btnDeleteStore.Name = "btnDeleteStore";
            btnDeleteStore.Size = new Size(190, 53);
            btnDeleteStore.TabIndex = 6;
            btnDeleteStore.Text = "Delete Store";
            btnDeleteStore.UseVisualStyleBackColor = true;
            btnDeleteStore.Click += btnDeleteStore_Click;
            // 
            // btnProducts
            // 
            btnProducts.Location = new Point(3, 325);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(190, 55);
            btnProducts.TabIndex = 5;
            btnProducts.Text = "Products";
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnStores
            // 
            btnStores.Location = new Point(3, 260);
            btnStores.Name = "btnStores";
            btnStores.Size = new Size(190, 55);
            btnStores.TabIndex = 4;
            btnStores.Text = "Stores";
            btnStores.UseVisualStyleBackColor = true;
            btnStores.Click += btnStores_Click;
            // 
            // btnEditProduct
            // 
            btnEditProduct.Location = new Point(3, 199);
            btnEditProduct.Name = "btnEditProduct";
            btnEditProduct.Size = new Size(190, 55);
            btnEditProduct.TabIndex = 3;
            btnEditProduct.Text = "Edit Product";
            btnEditProduct.UseVisualStyleBackColor = true;
            btnEditProduct.Click += btnEditProduct_Click;
            // 
            // btnEditStore
            // 
            btnEditStore.Location = new Point(3, 136);
            btnEditStore.Name = "btnEditStore";
            btnEditStore.Size = new Size(190, 55);
            btnEditStore.TabIndex = 0;
            btnEditStore.Text = "Edit Store";
            btnEditStore.UseVisualStyleBackColor = true;
            btnEditStore.Click += btnEditStore_Click;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Location = new Point(3, 447);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(190, 55);
            btnDeleteProduct.TabIndex = 2;
            btnDeleteProduct.Text = "Delete Product";
            btnDeleteProduct.UseVisualStyleBackColor = true;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(200, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(600, 511);
            panel2.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 511);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "HomeForm";
            Text = "Form1";
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddProduct;
        private Button btnAddStore;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Button btnDeleteProduct;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnDeleteStore;
        private Button btnProducts;
        private Button btnStores;
        private Button btnEditProduct;
        private Button btnEditStore;
    }
}