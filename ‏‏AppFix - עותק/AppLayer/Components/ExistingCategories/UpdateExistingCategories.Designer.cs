namespace AppLayer.Components.ExistingCategories
{
    partial class UpdateExistingCategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateExistingCategories));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.ComboBox();
            this.secondaryCategory = new System.Windows.Forms.ComboBox();
            this.specialButton1 = new AppLayer.SpecialComponents.SpecialButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.newSecondaryCategory = new System.Windows.Forms.TextBox();
            this.newCategory = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Guttman Stam", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(106, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "Secondary Category :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Guttman Stam", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(106, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Category :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(130, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "Insert  category details :";
            // 
            // category
            // 
            this.category.FormattingEnabled = true;
            this.category.Location = new System.Drawing.Point(297, 55);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(153, 23);
            this.category.TabIndex = 57;
            // 
            // secondaryCategory
            // 
            this.secondaryCategory.FormattingEnabled = true;
            this.secondaryCategory.Location = new System.Drawing.Point(297, 92);
            this.secondaryCategory.Name = "secondaryCategory";
            this.secondaryCategory.Size = new System.Drawing.Size(153, 23);
            this.secondaryCategory.TabIndex = 58;
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
            this.specialButton1.Location = new System.Drawing.Point(202, 264);
            this.specialButton1.Name = "specialButton1";
            this.specialButton1.Size = new System.Drawing.Size(162, 43);
            this.specialButton1.TabIndex = 59;
            this.specialButton1.TextColor = System.Drawing.Color.White;
            this.specialButton1.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(56, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(448, 21);
            this.label8.TabIndex = 70;
            this.label8.Text = "Insert Category details to be updated :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Guttman Stam", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(106, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 24);
            this.label4.TabIndex = 72;
            this.label4.Text = "Secondary Category :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Guttman Stam", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(106, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 24);
            this.label5.TabIndex = 71;
            this.label5.Text = "Category :";
            // 
            // newSecondaryCategory
            // 
            this.newSecondaryCategory.Location = new System.Drawing.Point(297, 222);
            this.newSecondaryCategory.MaxLength = 35;
            this.newSecondaryCategory.Name = "newSecondaryCategory";
            this.newSecondaryCategory.PlaceholderText = "Enter Secondary Category  ...";
            this.newSecondaryCategory.Size = new System.Drawing.Size(153, 23);
            this.newSecondaryCategory.TabIndex = 77;
            // 
            // newCategory
            // 
            this.newCategory.Location = new System.Drawing.Point(297, 183);
            this.newCategory.MaxLength = 25;
            this.newCategory.Name = "newCategory";
            this.newCategory.PlaceholderText = "Enter Category ...";
            this.newCategory.Size = new System.Drawing.Size(153, 23);
            this.newCategory.TabIndex = 76;
            // 
            // UpdateExistingCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Controls.Add(this.newSecondaryCategory);
            this.Controls.Add(this.newCategory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.specialButton1);
            this.Controls.Add(this.secondaryCategory);
            this.Controls.Add(this.category);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "UpdateExistingCategories";
            this.Size = new System.Drawing.Size(557, 314);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label3;
        private Label label1;
        private Label label2;
        private ComboBox category;
        private ComboBox secondaryCategory;
        private SpecialComponents.SpecialButton specialButton1;
        private Label label8;
        private Label label4;
        private Label label5;
        private TextBox newSecondaryCategory;
        private TextBox newCategory;
    }
}
