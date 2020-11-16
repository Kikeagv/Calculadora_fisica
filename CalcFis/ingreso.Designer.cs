namespace CalcFis
{
    partial class Form1
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
            this.CajaCarnet = new System.Windows.Forms.TextBox();
            this.CajaContra = new System.Windows.Forms.TextBox();
            this.Entrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.regis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CajaCarnet
            // 
            this.CajaCarnet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CajaCarnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CajaCarnet.Location = new System.Drawing.Point(403, 125);
            this.CajaCarnet.Name = "CajaCarnet";
            this.CajaCarnet.Size = new System.Drawing.Size(179, 19);
            this.CajaCarnet.TabIndex = 0;
            // 
            // CajaContra
            // 
            this.CajaContra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CajaContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CajaContra.Location = new System.Drawing.Point(403, 209);
            this.CajaContra.Name = "CajaContra";
            this.CajaContra.PasswordChar = '*';
            this.CajaContra.Size = new System.Drawing.Size(179, 19);
            this.CajaContra.TabIndex = 1;
            // 
            // Entrar
            // 
            this.Entrar.BackColor = System.Drawing.Color.Transparent;
            this.Entrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Entrar.FlatAppearance.BorderSize = 0;
            this.Entrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Entrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Entrar.ForeColor = System.Drawing.Color.Transparent;
            this.Entrar.Location = new System.Drawing.Point(368, 261);
            this.Entrar.Name = "Entrar";
            this.Entrar.Size = new System.Drawing.Size(103, 31);
            this.Entrar.TabIndex = 2;
            this.Entrar.UseVisualStyleBackColor = false;
            this.Entrar.Click += new System.EventHandler(this.Entrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(597, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 40);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // regis
            // 
            this.regis.BackColor = System.Drawing.Color.Transparent;
            this.regis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regis.FlatAppearance.BorderSize = 0;
            this.regis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.regis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.regis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regis.Location = new System.Drawing.Point(491, 263);
            this.regis.Name = "regis";
            this.regis.Size = new System.Drawing.Size(102, 26);
            this.regis.TabIndex = 4;
            this.regis.UseVisualStyleBackColor = false;
            this.regis.Click += new System.EventHandler(this.regis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImage = global::CalcFis.Properties.Resources.Login;
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.regis);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Entrar);
            this.Controls.Add(this.CajaContra);
            this.Controls.Add(this.CajaCarnet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log in";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CajaCarnet;
        private System.Windows.Forms.TextBox CajaContra;
        private System.Windows.Forms.Button Entrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button regis;
    }
}

