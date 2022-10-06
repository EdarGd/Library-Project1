namespace AppLayer.Components.Single.Show
{
    partial class showFormExistingCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(showFormExistingCategory));
            this.secondaryCategory = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // secondaryCategory
            // 
            this.secondaryCategory.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.secondaryCategory.ForeColor = System.Drawing.Color.SteelBlue;
            this.secondaryCategory.Location = new System.Drawing.Point(260, 174);
            this.secondaryCategory.Name = "secondaryCategory";
            this.secondaryCategory.Size = new System.Drawing.Size(137, 18);
            this.secondaryCategory.TabIndex = 79;
            this.secondaryCategory.Text = "secondaryCategory";
            this.secondaryCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // category
            // 
            this.category.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.category.ForeColor = System.Drawing.Color.SteelBlue;
            this.category.Location = new System.Drawing.Point(260, 128);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(137, 18);
            this.category.TabIndex = 78;
            this.category.Text = "Category";
            this.category.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppLayer.Properties.Resources.imgShow;
            this.pictureBox1.Location = new System.Drawing.Point(15, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Bisque;
            this.label8.Font = new System.Drawing.Font("Guttman Stam", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.DarkCyan;
            this.label8.Location = new System.Drawing.Point(25, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 22);
            this.label8.TabIndex = 71;
            this.label8.Text = "Secondary Category :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Bisque;
            this.label7.Font = new System.Drawing.Font("Guttman Stam", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.DarkCyan;
            this.label7.Location = new System.Drawing.Point(25, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 22);
            this.label7.TabIndex = 70;
            this.label7.Text = "Category :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(145, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 21);
            this.label2.TabIndex = 64;
            this.label2.Text = "borrow details";
            // 
            // showExistingCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 206);
            this.Controls.Add(this.secondaryCategory);
            this.Controls.Add(this.category);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "showExistingCategory";
            this.Text = "showExistingCategory";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label secondaryCategory;
        private Label category;
        private PictureBox pictureBox1;
        private Label label8;
        private Label label7;
        private Label label2;
    }
}