namespace AppLayer.Components.Borrow
{
    partial class AreaBorrow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AreaBorrow));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addBorrow1 = new AppLayer.Components.Borrow.AddBorrow();
            this.deleteBorrow1 = new AppLayer.Components.Borrow.DeleteBorrow();
            this.showBorrow1 = new AppLayer.Components.Borrow.ShowBorrow();
            this.updateBorrow1 = new AppLayer.Components.Borrow.UpdateBorrow();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Wheat;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(290, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Borrow area";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::AppLayer.Properties.Resources.closeForm;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // addBorrow1
            // 
            this.addBorrow1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.addBorrow1.Location = new System.Drawing.Point(120, 135);
            this.addBorrow1.Name = "addBorrow1";
            this.addBorrow1.Size = new System.Drawing.Size(557, 184);
            this.addBorrow1.TabIndex = 8;
            // 
            // deleteBorrow1
            // 
            this.deleteBorrow1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.deleteBorrow1.Location = new System.Drawing.Point(120, 135);
            this.deleteBorrow1.Name = "deleteBorrow1";
            this.deleteBorrow1.Size = new System.Drawing.Size(557, 173);
            this.deleteBorrow1.TabIndex = 9;
            // 
            // showBorrow1
            // 
            this.showBorrow1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.showBorrow1.Location = new System.Drawing.Point(120, 115);
            this.showBorrow1.Name = "showBorrow1";
            this.showBorrow1.Size = new System.Drawing.Size(557, 216);
            this.showBorrow1.TabIndex = 10;
            // 
            // updateBorrow1
            // 
            this.updateBorrow1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.updateBorrow1.Location = new System.Drawing.Point(120, 115);
            this.updateBorrow1.Name = "updateBorrow1";
            this.updateBorrow1.Size = new System.Drawing.Size(557, 216);
            this.updateBorrow1.TabIndex = 11;
            // 
            // AreaBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.updateBorrow1);
            this.Controls.Add(this.showBorrow1);
            this.Controls.Add(this.deleteBorrow1);
            this.Controls.Add(this.addBorrow1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AreaBorrow";
            this.Text = "AreaBorrow";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private AddBorrow addBorrow1;
        private DeleteBorrow deleteBorrow1;
        private ShowBorrow showBorrow1;
        private UpdateBorrow updateBorrow1;
    }
}