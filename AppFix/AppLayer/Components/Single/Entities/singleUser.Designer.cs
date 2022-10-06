namespace AppLayer.Components.Single
{
    partial class singleUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(singleUser));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnUpDate1 = new AppLayer.Components.Single.btnAction.btnUpDate();
            this.btnDelete1 = new AppLayer.Components.Single.btnDelete();
            this.password = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnShow1 = new AppLayer.Components.Single.btnShow();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 11;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.55888F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.59783F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.38772F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.444881F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.37295F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.63772F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Controls.Add(this.btnUpDate1, 9, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDelete1, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.password, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.email, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.type, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.lastName, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.firstName, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.id, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.num, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnShow1, 10, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(744, 35);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnUpDate1
            // 
            this.btnUpDate1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpDate1.Location = new System.Drawing.Point(674, 3);
            this.btnUpDate1.Name = "btnUpDate1";
            this.btnUpDate1.Size = new System.Drawing.Size(29, 29);
            this.btnUpDate1.TabIndex = 3;
            // 
            // btnDelete1
            // 
            this.btnDelete1.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete1.Location = new System.Drawing.Point(639, 3);
            this.btnDelete1.Name = "btnDelete1";
            this.btnDelete1.Size = new System.Drawing.Size(29, 29);
            this.btnDelete1.TabIndex = 3;
            // 
            // password
            // 
            this.password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.password.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.password.Location = new System.Drawing.Point(555, 0);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(78, 35);
            this.password.TabIndex = 7;
            this.password.Text = "1234567890";
            this.password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // email
            // 
            this.email.Dock = System.Windows.Forms.DockStyle.Fill;
            this.email.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.email.Location = new System.Drawing.Point(433, 0);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(116, 35);
            this.email.TabIndex = 6;
            this.email.Text = "aa@aaaa.aaa";
            this.email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // type
            // 
            this.type.Dock = System.Windows.Forms.DockStyle.Fill;
            this.type.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.type.Location = new System.Drawing.Point(379, 0);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(48, 35);
            this.type.TabIndex = 5;
            this.type.Text = "worker";
            this.type.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lastName
            // 
            this.lastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastName.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lastName.Location = new System.Drawing.Point(280, 0);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(93, 35);
            this.lastName.TabIndex = 4;
            this.lastName.Text = "last Name";
            this.lastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // firstName
            // 
            this.firstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstName.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.firstName.Location = new System.Drawing.Point(174, 0);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(100, 35);
            this.firstName.TabIndex = 3;
            this.firstName.Text = "first Name";
            this.firstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // id
            // 
            this.id.CausesValidation = false;
            this.id.Dock = System.Windows.Forms.DockStyle.Fill;
            this.id.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.id.Location = new System.Drawing.Point(68, 0);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 35);
            this.id.TabIndex = 1;
            this.id.Text = "123456789";
            this.id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num
            // 
            this.num.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num.Location = new System.Drawing.Point(3, 0);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(19, 35);
            this.num.TabIndex = 0;
            this.num.Text = "12";
            this.num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnShow1
            // 
            this.btnShow1.BackColor = System.Drawing.Color.Transparent;
            this.btnShow1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShow1.Location = new System.Drawing.Point(709, 3);
            this.btnShow1.Name = "btnShow1";
            this.btnShow1.Size = new System.Drawing.Size(32, 29);
            this.btnShow1.TabIndex = 8;
            // 
            // singleUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "singleUser";
            this.Size = new System.Drawing.Size(823, 142);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label num;
        private PictureBox pictureBox1;
        private Label id;
        private Label password;
        private Label email;
        private Label type;
        private Label lastName;
        private Label firstName;
        private btnDelete btnDelete1;
        private btnAction.btnUpDate btnUpDate1;
        private btnShow btnShow1;
    }
}
