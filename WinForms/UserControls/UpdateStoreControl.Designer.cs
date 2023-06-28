namespace WinForms.UserControls
{
    partial class UpdateStoreControl
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
            textBoxName = new TextBox();
            labelName = new Label();
            textBoxDescription = new TextBox();
            labelDescription = new Label();
            btnUpdateStore = new Button();
            label2 = new Label();
            DropDownStores = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(21, 20);
            label1.Name = "label1";
            label1.Size = new Size(158, 32);
            label1.TabIndex = 0;
            label1.Text = "Update Store";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(415, 103);
            textBoxName.MaxLength = 200;
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(228, 23);
            textBoxName.TabIndex = 6;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.Location = new Point(415, 80);
            labelName.Name = "labelName";
            labelName.Size = new Size(49, 20);
            labelName.TabIndex = 7;
            labelName.Text = "Name";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(415, 170);
            textBoxDescription.MaxLength = 2000;
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(228, 77);
            textBoxDescription.TabIndex = 8;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelDescription.Location = new Point(415, 147);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(85, 20);
            labelDescription.TabIndex = 9;
            labelDescription.Text = "Description";
            // 
            // btnUpdateStore
            // 
            btnUpdateStore.Location = new Point(415, 298);
            btnUpdateStore.Name = "btnUpdateStore";
            btnUpdateStore.Size = new Size(228, 45);
            btnUpdateStore.TabIndex = 11;
            btnUpdateStore.Text = "Update";
            btnUpdateStore.UseVisualStyleBackColor = true;
            btnUpdateStore.Click += btnUpdateStore_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 80);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 17;
            label2.Text = "Select the store";
            // 
            // DropDownStores
            // 
            DropDownStores.FormattingEnabled = true;
            DropDownStores.Location = new Point(21, 103);
            DropDownStores.Name = "DropDownStores";
            DropDownStores.Size = new Size(228, 23);
            DropDownStores.TabIndex = 18;
            DropDownStores.SelectedIndexChanged += DropDownStores_SelectedIndexChanged;
            // 
            // UpdateStoreControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DropDownStores);
            Controls.Add(label2);
            Controls.Add(btnUpdateStore);
            Controls.Add(labelDescription);
            Controls.Add(textBoxDescription);
            Controls.Add(labelName);
            Controls.Add(textBoxName);
            Controls.Add(label1);
            Name = "UpdateStoreControl";
            Size = new Size(700, 400);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxName;
        private Label labelName;
        private TextBox textBoxDescription;
        private Label labelDescription;
        private Button btnUpdateStore;
        private Label label2;
        private ComboBox DropDownStores;
    }
}
