namespace AppLayer.Components.Book
{
    partial class AreaBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AreaBook));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addBook2 = new AppLayer.Components.Book.AddBook();
            this.updateBook1 = new AppLayer.Components.Book.UpdateBook();
            this.deleteBook1 = new AppLayer.Components.Book.DeleteBook();
            this.showBook1 = new AppLayer.Components.Book.ShowBook();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Wheat;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(391, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book area";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::AppLayer.Properties.Resources.closeForm;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // addBook2
            // 
            this.addBook2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.addBook2.Location = new System.Drawing.Point(131, 77);
            this.addBook2.Name = "addBook2";
            this.addBook2.Size = new System.Drawing.Size(557, 413);
            this.addBook2.TabIndex = 7;
            // 
            // updateBook1
            // 
            this.updateBook1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.updateBook1.Location = new System.Drawing.Point(131, 77);
            this.updateBook1.Name = "updateBook1";
            this.updateBook1.Size = new System.Drawing.Size(557, 477);
            this.updateBook1.TabIndex = 8;
            // 
            // deleteBook1
            // 
            this.deleteBook1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.deleteBook1.Location = new System.Drawing.Point(131, 229);
            this.deleteBook1.Name = "deleteBook1";
            this.deleteBook1.Size = new System.Drawing.Size(557, 148);
            this.deleteBook1.TabIndex = 9;
            // 
            // showBook1
            // 
            this.showBook1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.showBook1.Location = new System.Drawing.Point(131, 67);
            this.showBook1.Name = "showBook1";
            this.showBook1.Size = new System.Drawing.Size(557, 487);
            this.showBook1.TabIndex = 10;
            // 
            // AreaBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 564);
            this.Controls.Add(this.showBook1);
            this.Controls.Add(this.deleteBook1);
            this.Controls.Add(this.updateBook1);
            this.Controls.Add(this.addBook2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AreaBook";
            this.Text = "AreaBook";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private AddBook addBook2;
        private UpdateBook updateBook1;
        private DeleteBook deleteBook1;
        private ShowBook showBook1;
    }
}