namespace CalcFis
{
    partial class logdoc
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
            this.EntrarDoc = new System.Windows.Forms.Button();
            this.CajaCarnetDoc = new System.Windows.Forms.TextBox();
            this.CajaContraDoc = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(600, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // EntrarDoc
            // 
            this.EntrarDoc.BackColor = System.Drawing.Color.Transparent;
            this.EntrarDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EntrarDoc.FlatAppearance.BorderSize = 0;
            this.EntrarDoc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.EntrarDoc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.EntrarDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EntrarDoc.ForeColor = System.Drawing.Color.Transparent;
            this.EntrarDoc.Location = new System.Drawing.Point(440, 261);
            this.EntrarDoc.Name = "EntrarDoc";
            this.EntrarDoc.Size = new System.Drawing.Size(103, 31);
            this.EntrarDoc.TabIndex = 5;
            this.EntrarDoc.UseVisualStyleBackColor = false;
            this.EntrarDoc.Click += new System.EventHandler(this.EntrarDoc_Click);
            // 
            // CajaCarnetDoc
            // 
            this.CajaCarnetDoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CajaCarnetDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CajaCarnetDoc.Location = new System.Drawing.Point(404, 125);
            this.CajaCarnetDoc.Name = "CajaCarnetDoc";
            this.CajaCarnetDoc.Size = new System.Drawing.Size(179, 19);
            this.CajaCarnetDoc.TabIndex = 6;
            // 
            // CajaContraDoc
            // 
            this.CajaContraDoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CajaContraDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CajaContraDoc.Location = new System.Drawing.Point(404, 209);
            this.CajaContraDoc.Name = "CajaContraDoc";
            this.CajaContraDoc.PasswordChar = '*';
            this.CajaContraDoc.Size = new System.Drawing.Size(179, 19);
            this.CajaContraDoc.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(571, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // logdoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CalcFis.Properties.Resources.Login_docentes;
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CajaContraDoc);
            this.Controls.Add(this.CajaCarnetDoc);
            this.Controls.Add(this.EntrarDoc);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "logdoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "logdoc";
            this.Load += new System.EventHandler(this.logdoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button EntrarDoc;
        private System.Windows.Forms.TextBox CajaCarnetDoc;
        private System.Windows.Forms.TextBox CajaContraDoc;
        private System.Windows.Forms.Button button1;
    }
}