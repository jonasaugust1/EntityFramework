namespace AddProductForm
{
    partial class ProductForm
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
            label1 = new Label();
            textBoxName = new TextBox();
            label2 = new Label();
            textBoxPrice = new TextBox();
            label3 = new Label();
            DropDownStores = new ComboBox();
            label4 = new Label();
            btnAdd = new Button();
            entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            btnReturn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(165, 37);
            label1.TabIndex = 0;
            label1.Text = "Add Product";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(12, 85);
            textBoxName.MaxLength = 200;
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(165, 23);
            textBoxName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(12, 141);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(165, 23);
            textBoxPrice.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 123);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 4;
            label3.Text = "Price";
            // 
            // DropDownStores
            // 
            DropDownStores.FormattingEnabled = true;
            DropDownStores.Location = new Point(12, 194);
            DropDownStores.Name = "DropDownStores";
            DropDownStores.Size = new Size(165, 23);
            DropDownStores.TabIndex = 6;
            DropDownStores.SelectedIndexChanged += DropDownStores_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 176);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 7;
            label4.Text = "Store";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 253);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(92, 23);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // entityCommand1
            // 
            entityCommand1.CommandTimeout = 0;
            entityCommand1.CommandTree = null;
            entityCommand1.Connection = null;
            entityCommand1.EnablePlanCaching = true;
            entityCommand1.Transaction = null;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(133, 253);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(92, 23);
            btnReturn.TabIndex = 9;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 450);
            Controls.Add(btnReturn);
            Controls.Add(btnAdd);
            Controls.Add(label4);
            Controls.Add(DropDownStores);
            Controls.Add(label3);
            Controls.Add(textBoxPrice);
            Controls.Add(label2);
            Controls.Add(textBoxName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxName;
        private Label label2;
        private TextBox textBoxPrice;
        private Label label3;
        private ComboBox DropDownStores;
        private Label label4;
        private Button btnAdd;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private Button btnReturn;
    }
}