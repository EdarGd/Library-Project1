namespace AppLayer
{
    partial class Login
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.specialButton1 = new AppLayer.SpecialComponents.SpecialButton();
            this.errorId = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Turquoise;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(68, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(674, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the library management system of AED\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("ROG Fonts", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(235, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter user details";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Narkisim", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(11, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Id :\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Narkisim", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(11, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password :\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Narkisim", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(11, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email :";
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Narkisim", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.id.Location = new System.Drawing.Point(132, 13);
            this.id.MaxLength = 9;
            this.id.Name = "id";
            this.id.PlaceholderText = "Your id";
            this.id.Size = new System.Drawing.Size(100, 26);
            this.id.TabIndex = 5;
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Narkisim", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.email.Location = new System.Drawing.Point(132, 57);
            this.email.MaxLength = 50;
            this.email.Name = "email";
            this.email.PlaceholderText = "Your email";
            this.email.Size = new System.Drawing.Size(100, 26);
            this.email.TabIndex = 6;
            this.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Narkisim", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.password.Location = new System.Drawing.Point(132, 99);
            this.password.MaxLength = 10;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.PlaceholderText = "Your password";
            this.password.Size = new System.Drawing.Size(100, 26);
            this.password.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.id);
            this.panel1.Location = new System.Drawing.Point(235, 159);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(279, 140);
            this.panel1.TabIndex = 8;
            // 
            // specialButton1
            // 
            this.specialButton1.BackColor = System.Drawing.Color.Transparent;
            this.specialButton1.BackgroundColor = System.Drawing.Color.Transparent;
            this.specialButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("specialButton1.BackgroundImage")));
            this.specialButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.specialButton1.BorderColor = System.Drawing.Color.Transparent;
            this.specialButton1.BorderRadius = 20;
            this.specialButton1.BorderSize = 0;
            this.specialButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.specialButton1.FlatAppearance.BorderSize = 0;
            this.specialButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.specialButton1.ForeColor = System.Drawing.Color.Transparent;
            this.specialButton1.Location = new System.Drawing.Point(327, 305);
            this.specialButton1.Name = "specialButton1";
            this.specialButton1.Size = new System.Drawing.Size(106, 41);
            this.specialButton1.TabIndex = 10;
            this.specialButton1.TextColor = System.Drawing.Color.Transparent;
            this.specialButton1.UseVisualStyleBackColor = false;
            this.specialButton1.Click += new System.EventHandler(this.specialButton1_Click);
            // 
            // errorId
            // 
            this.errorId.ContainerControl = this;
            this.errorId.Icon = ((System.Drawing.Icon)(resources.GetObject("errorId.Icon")));
            // 
            // errorEmail
            // 
            this.errorEmail.ContainerControl = this;
            this.errorEmail.Icon = ((System.Drawing.Icon)(resources.GetObject("errorEmail.Icon")));
            // 
            // errorPassword
            // 
            this.errorPassword.ContainerControl = this;
            this.errorPassword.Icon = ((System.Drawing.Icon)(resources.GetObject("errorPassword.Icon")));
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 358);
            this.Controls.Add(this.specialButton1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox id;
        private TextBox email;
        private TextBox password;
        private Panel panel1;
        private SpecialComponents.SpecialButton specialButton1;
        private ErrorProvider errorId;
        private ErrorProvider errorEmail;
        private ErrorProvider errorPassword;
        private ErrorProvider errorProvider1;
    }
}