namespace AppLayer.Components.ExistingCategories
{
    partial class AreaExistingCategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AreaExistingCategories));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addExistingCategories1 = new AppLayer.Components.ExistingCategories.AddExistingCategories();
            this.showExistingCategories1 = new AppLayer.Components.ExistingCategories.ShowExistingCategories();
            this.deleteExistingCategories1 = new AppLayer.Components.ExistingCategories.DeleteExistingCategories();
            this.updateExistingCategories1 = new AppLayer.Components.ExistingCategories.UpdateExistingCategories();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Wheat;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(204, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Existing Categories area";
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
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // addExistingCategories1
            // 
            this.addExistingCategories1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.addExistingCategories1.Location = new System.Drawing.Point(125, 127);
            this.addExistingCategories1.Name = "addExistingCategories1";
            this.addExistingCategories1.Size = new System.Drawing.Size(557, 190);
            this.addExistingCategories1.TabIndex = 8;
            // 
            // showExistingCategories1
            // 
            this.showExistingCategories1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.showExistingCategories1.Location = new System.Drawing.Point(125, 86);
            this.showExistingCategories1.Name = "showExistingCategories1";
            this.showExistingCategories1.Size = new System.Drawing.Size(557, 314);
            this.showExistingCategories1.TabIndex = 9;
            // 
            // deleteExistingCategories1
            // 
            this.deleteExistingCategories1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.deleteExistingCategories1.Location = new System.Drawing.Point(125, 148);
            this.deleteExistingCategories1.Name = "deleteExistingCategories1";
            this.deleteExistingCategories1.Size = new System.Drawing.Size(557, 178);
            this.deleteExistingCategories1.TabIndex = 10;
            // 
            // updateExistingCategories1
            // 
            this.updateExistingCategories1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.updateExistingCategories1.Location = new System.Drawing.Point(125, 86);
            this.updateExistingCategories1.Name = "updateExistingCategories1";
            this.updateExistingCategories1.Size = new System.Drawing.Size(557, 314);
            this.updateExistingCategories1.TabIndex = 11;
            // 
            // AreaExistingCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.updateExistingCategories1);
            this.Controls.Add(this.deleteExistingCategories1);
            this.Controls.Add(this.showExistingCategories1);
            this.Controls.Add(this.addExistingCategories1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AreaExistingCategories";
            this.Text = "AreaExistingCategories";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private AddExistingCategories addExistingCategories1;
        private ShowExistingCategories showExistingCategories1;
        private DeleteExistingCategories deleteExistingCategories1;
        private UpdateExistingCategories updateExistingCategories1;
    }
}