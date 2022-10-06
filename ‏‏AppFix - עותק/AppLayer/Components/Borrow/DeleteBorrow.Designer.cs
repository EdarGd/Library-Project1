namespace AppLayer.Components.Borrow
{
    partial class DeleteBorrow
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
            this.secondaryCategory = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.specialButton2 = new AppLayer.SpecialComponents.SpecialButton();
            this.SuspendLayout();
            // 
            // secondaryCategory
            // 
            this.secondaryCategory.Location = new System.Drawing.Point(296, 92);
            this.secondaryCategory.MaxLength = 9;
            this.secondaryCategory.Name = "secondaryCategory";
            this.secondaryCategory.PlaceholderText = "Enter User Id ...";
            this.secondaryCategory.Size = new System.Drawing.Size(153, 23);
            this.secondaryCategory.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Guttman Stam", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(106, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "id ( 9 digits) :";
            // 
            // category
            // 
            this.category.Location = new System.Drawing.Point(296, 54);
            this.category.MaxLength = 13;
            this.category.Name = "category";
            this.category.PlaceholderText = "Enter Book Code ...";
            this.category.Size = new System.Drawing.Size(153, 23);
            this.category.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Guttman Stam", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(106, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Code ( 13 digits ) :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(140, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 21);
            this.label4.TabIndex = 39;
            this.label4.Text = "Insert  borrow details :";
            // 
            // specialButton2
            // 
            this.specialButton2.BackColor = System.Drawing.Color.Transparent;
            this.specialButton2.BackgroundColor = System.Drawing.Color.Transparent;
            this.specialButton2.BackgroundImage = global::AppLayer.Properties.Resources.deleteButton;
            this.specialButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.specialButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.specialButton2.BorderRadius = 20;
            this.specialButton2.BorderSize = 0;
            this.specialButton2.FlatAppearance.BorderSize = 0;
            this.specialButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.specialButton2.ForeColor = System.Drawing.Color.White;
            this.specialButton2.Location = new System.Drawing.Point(209, 131);
            this.specialButton2.Name = "specialButton2";
            this.specialButton2.Size = new System.Drawing.Size(144, 38);
            this.specialButton2.TabIndex = 57;
            this.specialButton2.TextColor = System.Drawing.Color.White;
            this.specialButton2.UseVisualStyleBackColor = false;
            // 
            // DeleteBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Controls.Add(this.specialButton2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.secondaryCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.category);
            this.Controls.Add(this.label1);
            this.Name = "DeleteBorrow";
            this.Size = new System.Drawing.Size(557, 173);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox secondaryCategory;
        private Label label3;
        private TextBox category;
        private Label label1;
        private Label label4;
        private SpecialComponents.SpecialButton specialButton2;
    }
}
