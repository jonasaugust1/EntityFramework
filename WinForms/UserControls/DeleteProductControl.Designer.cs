namespace WinForms.UserControls
{
    partial class DeleteProductControl
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
            label2 = new Label();
            DropDownProducts = new ComboBox();
            btnDeleteStore = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(17, 29);
            label1.Name = "label1";
            label1.Size = new Size(177, 32);
            label1.TabIndex = 2;
            label1.Text = "Delete Product";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(17, 98);
            label2.Name = "label2";
            label2.Size = new Size(130, 20);
            label2.TabIndex = 17;
            label2.Text = "Select the product";
            // 
            // DropDownProducts
            // 
            DropDownProducts.FormattingEnabled = true;
            DropDownProducts.Location = new Point(17, 121);
            DropDownProducts.Name = "DropDownProducts";
            DropDownProducts.Size = new Size(228, 23);
            DropDownProducts.TabIndex = 18;
            // 
            // btnDeleteStore
            // 
            btnDeleteStore.Location = new Point(17, 228);
            btnDeleteStore.Name = "btnDeleteStore";
            btnDeleteStore.Size = new Size(228, 45);
            btnDeleteStore.TabIndex = 21;
            btnDeleteStore.Text = "Delete";
            btnDeleteStore.UseVisualStyleBackColor = true;
            btnDeleteStore.Click += btnDeleteStore_Click;
            // 
            // DeleteProductControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnDeleteStore);
            Controls.Add(DropDownProducts);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DeleteProductControl";
            Size = new Size(700, 400);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox DropDownProducts;
        private Button btnDeleteStore;
    }
}
