namespace AppLayer.Components.comUser
{
    partial class AreaUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AreaUser));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addUser1 = new AppLayer.Components.comUser.AddUser();
            this.updateUser2 = new AppLayer.Components.comUser.UpdateUser();
            this.deleteUser1 = new AppLayer.Components.comUser.DeleteUser();
            this.showUser1 = new AppLayer.Components.comUser.ShowSearchUser();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Wheat;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(334, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "User area";
            // 
            // addUser1
            // 
            this.addUser1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.addUser1.Location = new System.Drawing.Point(155, 62);
            this.addUser1.Name = "addUser1";
            this.addUser1.Size = new System.Drawing.Size(557, 366);
            this.addUser1.TabIndex = 10;
            // 
            // updateUser2
            // 
            this.updateUser2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.updateUser2.Location = new System.Drawing.Point(155, 62);
            this.updateUser2.Name = "updateUser2";
            this.updateUser2.Size = new System.Drawing.Size(557, 437);
            this.updateUser2.TabIndex = 13;
            // 
            // deleteUser1
            // 
            this.deleteUser1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.deleteUser1.Location = new System.Drawing.Point(155, 163);
            this.deleteUser1.Name = "deleteUser1";
            this.deleteUser1.Size = new System.Drawing.Size(557, 150);
            this.deleteUser1.TabIndex = 14;
            // 
            // showUser1
            // 
            this.showUser1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.showUser1.Location = new System.Drawing.Point(155, 62);
            this.showUser1.Name = "showUser1";
            this.showUser1.Size = new System.Drawing.Size(557, 437);
            this.showUser1.TabIndex = 15;
            // 
            // AreaUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.showUser1);
            this.Controls.Add(this.deleteUser1);
            this.Controls.Add(this.updateUser2);
            this.Controls.Add(this.addUser1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AreaUser";
            this.Text = "AreaUser";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private AddUser addUser1;
        private UpdateUser updateUser2;
        private DeleteUser deleteUser1;
        private ShowSearchUser showUser1;
    }
}