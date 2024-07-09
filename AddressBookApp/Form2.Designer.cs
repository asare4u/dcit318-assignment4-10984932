namespace AddressBookApp
{
    partial class Form2
    {
        
        private System.ComponentModel.IContainer components = null;

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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.phoneNumberField = new System.Windows.Forms.TextBox();
            this.emailField = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameField = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.titleLabel);
            this.panel2.Controls.Add(this.saveButton);
            this.panel2.Controls.Add(this.emailLabel);
            this.panel2.Controls.Add(this.phoneLabel);
            this.panel2.Controls.Add(this.phoneNumberField);
            this.panel2.Controls.Add(this.emailField);
            this.panel2.Controls.Add(this.nameLabel);
            this.panel2.Controls.Add(this.nameField);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(709, 433);
            this.panel2.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.titleLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.titleLabel.Location = new System.Drawing.Point(72, 30);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(287, 39);
            this.titleLabel.TabIndex = 7;
            this.titleLabel.Text = "Create New Contact";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.saveButton.Location = new System.Drawing.Point(405, 308);
            this.saveButton.MaximumSize = new System.Drawing.Size(200, 44);
            this.saveButton.MinimumSize = new System.Drawing.Size(200, 44);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(200, 44);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.emailLabel.Location = new System.Drawing.Point(62, 172);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(100, 30);
            this.emailLabel.TabIndex = 5;
            this.emailLabel.Text = "Email:";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // phoneLabel
            // 
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.phoneLabel.Location = new System.Drawing.Point(66, 231);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(96, 39);
            this.phoneLabel.TabIndex = 4;
            this.phoneLabel.Text = "Phone :";
            this.phoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // phoneNumberField
            // 
            this.phoneNumberField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneNumberField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.phoneNumberField.Location = new System.Drawing.Point(172, 240);
            this.phoneNumberField.Multiline = true;
            this.phoneNumberField.Name = "phoneNumberField";
            this.phoneNumberField.Size = new System.Drawing.Size(432, 30);
            this.phoneNumberField.TabIndex = 3;
            // 
            // emailField
            // 
            this.emailField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.emailField.Location = new System.Drawing.Point(172, 172);
            this.emailField.Multiline = true;
            this.emailField.Name = "emailField";
            this.emailField.Size = new System.Drawing.Size(432, 30);
            this.emailField.TabIndex = 2;
            this.emailField.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nameLabel.Location = new System.Drawing.Point(62, 108);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(100, 32);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name:";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nameLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // nameField
            // 
            this.nameField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nameField.Location = new System.Drawing.Point(172, 110);
            this.nameField.Multiline = true;
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(432, 30);
            this.nameField.TabIndex = 0;
            this.nameField.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Contact
            // 
            this.ClientSize = new System.Drawing.Size(709, 433);
            this.Controls.Add(this.panel2);
            this.Name = "Contact";
            this.Text = "Address Book";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox phoneNumberField;
        private System.Windows.Forms.TextBox emailField;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label titleLabel;
    }
}
