namespace AppLayer.Components.Single
{
    partial class updateFromTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updateFromTable));
            this.updateBorrow1 = new AppLayer.Components.comBorrow.UpdateBorrow();
            this.updateExistingCategories1 = new AppLayer.Components.comExistingCategories.UpdateExistingCategories();
            this.updateUser1 = new AppLayer.Components.comUser.UpdateUser();
            this.updateBook1 = new AppLayer.Components.comBook.UpdateBook();
            this.showUser1 = new AppLayer.Components.comUser.ShowSearchUser();
            this.showExistingCategories1 = new AppLayer.Components.comExistingCategories.ShowSearchExistingCategories();
            this.showBorrow1 = new AppLayer.Components.comBorrow.ShowSearchBorrow();
            this.showBook3 = new AppLayer.Components.comBook.ShowSearchBook();
            this.SuspendLayout();
            // 
            // updateBorrow1
            // 
            this.updateBorrow1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.updateBorrow1.Location = new System.Drawing.Point(63, 12);
            this.updateBorrow1.Name = "updateBorrow1";
            this.updateBorrow1.Size = new System.Drawing.Size(557, 216);
            this.updateBorrow1.TabIndex = 0;
            // 
            // updateExistingCategories1
            // 
            this.updateExistingCategories1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.updateExistingCategories1.Location = new System.Drawing.Point(63, 21);
            this.updateExistingCategories1.Name = "updateExistingCategories1";
            this.updateExistingCategories1.Size = new System.Drawing.Size(557, 314);
            this.updateExistingCategories1.TabIndex = 1;
            // 
            // updateUser1
            // 
            this.updateUser1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.updateUser1.Location = new System.Drawing.Point(63, 12);
            this.updateUser1.Name = "updateUser1";
            this.updateUser1.Size = new System.Drawing.Size(557, 437);
            this.updateUser1.TabIndex = 2;
            // 
            // updateBook1
            // 
            this.updateBook1.AutoSize = true;
            this.updateBook1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.updateBook1.Book = null;
            this.updateBook1.Location = new System.Drawing.Point(63, 21);
            this.updateBook1.Name = "updateBook1";
            this.updateBook1.Size = new System.Drawing.Size(557, 487);
            this.updateBook1.TabIndex = 3;
            // 
            // showUser1
            // 
            this.showUser1.AutoSize = true;
            this.showUser1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.showUser1.Location = new System.Drawing.Point(63, 12);
            this.showUser1.Name = "showUser1";
            this.showUser1.Size = new System.Drawing.Size(557, 107);
            this.showUser1.TabIndex = 4;
            // 
            // showExistingCategories1
            // 
            this.showExistingCategories1.AutoSize = true;
            this.showExistingCategories1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.showExistingCategories1.Location = new System.Drawing.Point(63, 12);
            this.showExistingCategories1.Name = "showExistingCategories1";
            this.showExistingCategories1.Size = new System.Drawing.Size(557, 107);
            this.showExistingCategories1.TabIndex = 5;
            // 
            // showBorrow1
            // 
            this.showBorrow1.AutoSize = true;
            this.showBorrow1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.showBorrow1.Location = new System.Drawing.Point(63, 12);
            this.showBorrow1.Name = "showBorrow1";
            this.showBorrow1.Size = new System.Drawing.Size(557, 107);
            this.showBorrow1.TabIndex = 6;
            // 
            // showBook3
            // 
            this.showBook3.AutoSize = true;
            this.showBook3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.showBook3.Location = new System.Drawing.Point(63, 12);
            this.showBook3.Name = "showBook3";
            this.showBook3.Size = new System.Drawing.Size(557, 96);
            this.showBook3.TabIndex = 7;
            // 
            // updateFromTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::AppLayer.Properties.Resources.upImage;
            this.ClientSize = new System.Drawing.Size(680, 650);
            this.Controls.Add(this.showBook3);
            this.Controls.Add(this.showBorrow1);
            this.Controls.Add(this.showExistingCategories1);
            this.Controls.Add(this.showUser1);
            this.Controls.Add(this.updateBook1);
            this.Controls.Add(this.updateUser1);
            this.Controls.Add(this.updateExistingCategories1);
            this.Controls.Add(this.updateBorrow1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "updateFromTable";
            this.Text = "updateFromTable";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private comBorrow.UpdateBorrow updateBorrow1;
        private comExistingCategories.UpdateExistingCategories updateExistingCategories1;
        private comUser.UpdateUser updateUser1;
        private comBook.UpdateBook updateBook1;
        private comUser.ShowSearchUser showUser1;
        private comExistingCategories.ShowSearchExistingCategories showExistingCategories1;
        private comBorrow.ShowSearchBorrow showBorrow1;
        private comBook.ShowSearchBook showBook3;
    }
}