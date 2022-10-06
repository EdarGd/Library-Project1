namespace AppLayer.Components.comBorrow
{
    partial class ShowSearchBorrow
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelId = new System.Windows.Forms.Panel();
            this.id = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.panelCode = new System.Windows.Forms.Panel();
            this.code = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelAction = new System.Windows.Forms.Panel();
            this.specialButton1 = new AppLayer.SpecialComponents.SpecialButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.checkComboBox1 = new AppLayer.SpecialComponents.CheckComboBox();
            this.panelId.SuspendLayout();
            this.panelCode.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelAction.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Guttman Stam", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(110, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search by :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(121, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 21);
            this.label2.TabIndex = 74;
            this.label2.Text = "Display of borrows by choice:";
            // 
            // panelId
            // 
            this.panelId.Controls.Add(this.id);
            this.panelId.Controls.Add(this.textBox1);
            this.panelId.Controls.Add(this.label3);
            this.panelId.Controls.Add(this.textBox5);
            this.panelId.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelId.Location = new System.Drawing.Point(0, 52);
            this.panelId.Name = "panelId";
            this.panelId.Size = new System.Drawing.Size(381, 43);
            this.panelId.TabIndex = 82;
            // 
            // id
            // 
            this.id.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.id.Location = new System.Drawing.Point(224, 11);
            this.id.MaxLength = 9;
            this.id.Name = "id";
            this.id.PlaceholderText = "Enter id user ...";
            this.id.Size = new System.Drawing.Size(153, 23);
            this.id.TabIndex = 89;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(405, 10);
            this.textBox1.MaxLength = 20;
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Enter book title ...";
            this.textBox1.Size = new System.Drawing.Size(153, 23);
            this.textBox1.TabIndex = 89;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Guttman Stam", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Id ( 9 digits) :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.Location = new System.Drawing.Point(587, 6);
            this.textBox5.MaxLength = 20;
            this.textBox5.Name = "textBox5";
            this.textBox5.PlaceholderText = "Enter book title ...";
            this.textBox5.Size = new System.Drawing.Size(153, 23);
            this.textBox5.TabIndex = 5;
            // 
            // panelCode
            // 
            this.panelCode.Controls.Add(this.code);
            this.panelCode.Controls.Add(this.label17);
            this.panelCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCode.Location = new System.Drawing.Point(0, 95);
            this.panelCode.Name = "panelCode";
            this.panelCode.Size = new System.Drawing.Size(381, 43);
            this.panelCode.TabIndex = 81;
            // 
            // code
            // 
            this.code.Location = new System.Drawing.Point(224, 11);
            this.code.MaxLength = 13;
            this.code.Name = "code";
            this.code.PlaceholderText = "Enter book code ...";
            this.code.Size = new System.Drawing.Size(153, 23);
            this.code.TabIndex = 78;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Guttman Stam", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(3, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(160, 24);
            this.label17.TabIndex = 77;
            this.label17.Text = "Code  ( 13 digits ) :";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.panelAction);
            this.panel1.Controls.Add(this.panelCode);
            this.panel1.Controls.Add(this.panelId);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(88, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 192);
            this.panel1.TabIndex = 87;
            // 
            // panelAction
            // 
            this.panelAction.Controls.Add(this.specialButton1);
            this.panelAction.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAction.Location = new System.Drawing.Point(0, 138);
            this.panelAction.Name = "panelAction";
            this.panelAction.Size = new System.Drawing.Size(381, 49);
            this.panelAction.TabIndex = 88;
            // 
            // specialButton1
            // 
            this.specialButton1.BackColor = System.Drawing.Color.Transparent;
            this.specialButton1.BackgroundColor = System.Drawing.Color.Transparent;
            this.specialButton1.BackgroundImage = global::AppLayer.Properties.Resources.searchButton;
            this.specialButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.specialButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.specialButton1.BorderRadius = 20;
            this.specialButton1.BorderSize = 0;
            this.specialButton1.FlatAppearance.BorderSize = 0;
            this.specialButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.specialButton1.ForeColor = System.Drawing.Color.White;
            this.specialButton1.Location = new System.Drawing.Point(131, 6);
            this.specialButton1.Name = "specialButton1";
            this.specialButton1.Size = new System.Drawing.Size(108, 37);
            this.specialButton1.TabIndex = 89;
            this.specialButton1.TextColor = System.Drawing.Color.White;
            this.specialButton1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label15);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(381, 52);
            this.panel2.TabIndex = 88;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(8, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(368, 21);
            this.label15.TabIndex = 54;
            this.label15.Text = "Fill in the search borrow fields:";
            // 
            // checkComboBox1
            // 
            this.checkComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.checkComboBox1.Font = new System.Drawing.Font("Guttman Mantova-Decor", 9.749998F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkComboBox1.FormattingEnabled = true;
            this.checkComboBox1.Location = new System.Drawing.Point(239, 67);
            this.checkComboBox1.Name = "checkComboBox1";
            this.checkComboBox1.Size = new System.Drawing.Size(196, 26);
            this.checkComboBox1.TabIndex = 79;
            this.checkComboBox1.Text = "Select Search Options";
            // 
            // ShowBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkComboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ShowBorrow";
            this.Size = new System.Drawing.Size(557, 310);
            this.Load += new System.EventHandler(this.ShowBorrow_Load);
            this.panelId.ResumeLayout(false);
            this.panelId.PerformLayout();
            this.panelCode.ResumeLayout(false);
            this.panelCode.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelAction.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panelId;
        private TextBox id;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox5;
        private Panel panelCode;
        private TextBox code;
        private Label label17;
        private Panel panel1;
        private SpecialComponents.CheckComboBox checkComboBox1;
        private Panel panelAction;
        private SpecialComponents.SpecialButton specialButton1;
        private Panel panel2;
        private Label label15;
    }
}
