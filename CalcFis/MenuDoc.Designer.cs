namespace CalcFis
{
    partial class MenuDoc
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addalu = new System.Windows.Forms.Button();
            this.adddoc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(595, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 40);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // addalu
            // 
            this.addalu.BackColor = System.Drawing.Color.Transparent;
            this.addalu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addalu.FlatAppearance.BorderSize = 0;
            this.addalu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.addalu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.addalu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addalu.ForeColor = System.Drawing.Color.Transparent;
            this.addalu.Location = new System.Drawing.Point(399, 178);
            this.addalu.Name = "addalu";
            this.addalu.Size = new System.Drawing.Size(184, 31);
            this.addalu.TabIndex = 5;
            this.addalu.UseVisualStyleBackColor = false;
            this.addalu.Click += new System.EventHandler(this.addalu_Click);
            // 
            // adddoc
            // 
            this.adddoc.BackColor = System.Drawing.Color.Transparent;
            this.adddoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adddoc.FlatAppearance.BorderSize = 0;
            this.adddoc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.adddoc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.adddoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adddoc.ForeColor = System.Drawing.Color.Transparent;
            this.adddoc.Location = new System.Drawing.Point(399, 227);
            this.adddoc.Name = "adddoc";
            this.adddoc.Size = new System.Drawing.Size(184, 31);
            this.adddoc.TabIndex = 6;
            this.adddoc.UseVisualStyleBackColor = false;
            this.adddoc.Click += new System.EventHandler(this.adddoc_Click);
            // 
            // MenuDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CalcFis.Properties.Resources.Menu_docentes;
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.adddoc);
            this.Controls.Add(this.addalu);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuDoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuDoc";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addalu;
        private System.Windows.Forms.Button adddoc;
    }
}