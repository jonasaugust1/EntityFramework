namespace WinForms.UserControls
{
    partial class AddStoreControl
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
            labelDescription = new Label();
            textBoxDescription = new TextBox();
            btnSaveStore = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(25, 16);
            label1.Name = "label1";
            label1.Size = new Size(122, 32);
            label1.TabIndex = 0;
            label1.Text = "Add Store";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.Location = new Point(25, 90);
            labelName.Name = "labelName";
            labelName.Size = new Size(49, 20);
            labelName.TabIndex = 2;
            labelName.Text = "Name";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(25, 113);
            textBoxName.MaxLength = 200;
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(228, 23);
            textBoxName.TabIndex = 5;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelDescription.Location = new Point(25, 158);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(85, 20);
            labelDescription.TabIndex = 6;
            labelDescription.Text = "Description";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(25, 181);
            textBoxDescription.MaxLength = 2000;
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(228, 77);
            textBoxDescription.TabIndex = 7;
            // 
            // btnSaveStore
            // 
            btnSaveStore.Location = new Point(25, 300);
            btnSaveStore.Name = "btnSaveStore";
            btnSaveStore.Size = new Size(228, 45);
            btnSaveStore.TabIndex = 10;
            btnSaveStore.Text = "Save";
            btnSaveStore.UseVisualStyleBackColor = true;
            btnSaveStore.Click += btnSaveStore_Click;
            // 
            // AddStoreControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(btnSaveStore);
            Controls.Add(textBoxDescription);
            Controls.Add(labelDescription);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            Controls.Add(label1);
            Name = "AddStoreControl";
            Size = new Size(700, 400);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelName;
        private TextBox textBoxName;
        private Label labelDescription;
        private TextBox textBoxDescription;
        private Button btnSaveStore;
    }
}
