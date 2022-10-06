namespace AppLayer
{
    partial class programForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(programForm));
            this.ucLogin1 = new AppLayer.UCLogin();
            this.SuspendLayout();
            // 
            // ucLogin1
            // 
            this.ucLogin1.AutoSize = true;
            this.ucLogin1.BackColor = System.Drawing.Color.Transparent;
            this.ucLogin1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucLogin1.BackgroundImage")));
            this.ucLogin1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucLogin1.Location = new System.Drawing.Point(0, 1);
            this.ucLogin1.Name = "ucLogin1";
            this.ucLogin1.Size = new System.Drawing.Size(924, 459);
            this.ucLogin1.TabIndex = 1;
            // 
            // programForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 457);
            this.Controls.Add(this.ucLogin1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "programForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AEDLibrary";
            this.Load += new System.EventHandler(this.programForm_Load);
            this.Resize += new System.EventHandler(this.ProgramForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UCLogin ucLogin1;
    }
}