namespace AppLayer.Components.User
{
    partial class ShowUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateUser));
            this.email = new System.Windows.Forms.TextBox();
            this.specialButton1 = new AppLayer.SpecialComponents.SpecialButton();
            this.type = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(305, 280);
            this.email.MaxLength = 50;
            this.email.Name = "email";
            this.email.PlaceholderText = "Enter email ...";
            this.email.Size = new System.Drawing.Size(153, 23);
            this.email.TabIndex = 51;
            // 
            // specialButton1
            // 
            this.specialButton1.BackColor = System.Drawing.Color.Transparent;
            this.specialButton1.BackgroundColor = System.Drawing.Color.Transparent;
            this.specialButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("specialButton1.BackgroundImage")));
            this.specialButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.specialButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.specialButton1.BorderRadius = 40;
            this.specialButton1.BorderSize = 0;
            this.specialButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.specialButton1.FlatAppearance.BorderSize = 0;
            this.specialButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.specialButton1.ForeColor = System.Drawing.Color.White;
            this.specialButton1.Location = new System.Drawing.Point(218, 379);
            this.specialButton1.Name = "specialButton1";
            this.specialButton1.Size = new System.Drawing.Size(162, 43);
            this.specialButton1.TabIndex = 50;
            this.specialButton1.TextColor = System.Drawing.Color.White;
            this.specialButton1.UseVisualStyleBackColor = false;
            // 
            // type
            // 
            this.type.FormattingEnabled = true;
            this.type.Items.AddRange(new object[] {
            "Worker",
            "Subscription"});
            this.type.Location = new System.Drawing.Point(305, 236);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(153, 23);
            this.type.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Guttman Stam", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(114, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 24);
            this.label7.TabIndex = 48;
            this.label7.Text = "Password :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Guttman Stam", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(114, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 24);
            this.label6.TabIndex = 47;
            this.label6.Text = "Email :";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(305, 327);
            this.password.MaxLength = 10;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.PlaceholderText = "Enter password ...";
            this.password.Size = new System.Drawing.Size(153, 23);
            this.password.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Guttman Stam", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(114, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 24);
            this.label5.TabIndex = 45;
            this.label5.Text = "Type";
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(305, 194);
            this.lastName.MaxLength = 20;
            this.lastName.Name = "lastName";
            this.lastName.PlaceholderText = "Enter Last Name ...";
            this.lastName.Size = new System.Drawing.Size(153, 23);
            this.lastName.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Guttman Stam", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(114, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 43;
            this.label4.Text = "Last Name :";
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(305, 150);
            this.firstName.MaxLength = 20;
            this.firstName.Name = "firstName";
            this.firstName.PlaceholderText = "Enter First Name ...";
            this.firstName.Size = new System.Drawing.Size(153, 23);
            this.firstName.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Guttman Stam", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(114, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 24);
            this.label3.TabIndex = 41;
            this.label3.Text = "First Name :";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(305, 50);
            this.id.MaxLength = 9;
            this.id.Name = "id";
            this.id.PlaceholderText = "Enter id ...";
            this.id.Size = new System.Drawing.Size(153, 23);
            this.id.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Guttman Stam", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(114, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 39;
            this.label1.Text = "Id ( 9 digits ) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(152, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 21);
            this.label2.TabIndex = 38;
            this.label2.Text = "Insert  user details :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(86, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(394, 21);
            this.label8.TabIndex = 52;
            this.label8.Text = "Insert user details to be updated :";
            // 
            // UpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.email);
            this.Controls.Add(this.specialButton1);
            this.Controls.Add(this.type);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "UpdateUser";
            this.Size = new System.Drawing.Size(557, 437);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox email;
        private SpecialComponents.SpecialButton specialButton1;
        private ComboBox type;
        private Label label7;
        private Label label6;
        private TextBox password;
        private Label label5;
        private TextBox lastName;
        private Label label4;
        private TextBox firstName;
        private Label label3;
        private TextBox id;
        private Label label1;
        private Label label2;
        private Label label8;
    }
}
