namespace CalcFis
{
    partial class RegistroDoc
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cajarecardo = new System.Windows.Forms.TextBox();
            this.cajarecondo = new System.Windows.Forms.TextBox();
            this.registrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(601, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(570, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // cajarecardo
            // 
            this.cajarecardo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cajarecardo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajarecardo.Location = new System.Drawing.Point(401, 125);
            this.cajarecardo.Name = "cajarecardo";
            this.cajarecardo.Size = new System.Drawing.Size(182, 19);
            this.cajarecardo.TabIndex = 8;
            // 
            // cajarecondo
            // 
            this.cajarecondo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cajarecondo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajarecondo.Location = new System.Drawing.Point(401, 209);
            this.cajarecondo.Name = "cajarecondo";
            this.cajarecondo.Size = new System.Drawing.Size(182, 19);
            this.cajarecondo.TabIndex = 9;
            // 
            // registrar
            // 
            this.registrar.BackColor = System.Drawing.Color.Transparent;
            this.registrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.registrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrar.FlatAppearance.BorderSize = 0;
            this.registrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.registrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrar.Location = new System.Drawing.Point(446, 264);
            this.registrar.Name = "registrar";
            this.registrar.Size = new System.Drawing.Size(92, 27);
            this.registrar.TabIndex = 10;
            this.registrar.UseVisualStyleBackColor = false;
            this.registrar.Click += new System.EventHandler(this.registrar_Click);
            // 
            // RegistroDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CalcFis.Properties.Resources.Registro_docente;
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.registrar);
            this.Controls.Add(this.cajarecondo);
            this.Controls.Add(this.cajarecardo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroDoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox cajarecardo;
        private System.Windows.Forms.TextBox cajarecondo;
        private System.Windows.Forms.Button registrar;
    }
}