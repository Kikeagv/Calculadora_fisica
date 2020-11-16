namespace CalcFis
{
    partial class Registro
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
            this.registrar = new System.Windows.Forms.Button();
            this.cajarecar = new System.Windows.Forms.TextBox();
            this.cajaregcont = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
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
            this.registrar.Location = new System.Drawing.Point(448, 268);
            this.registrar.Name = "registrar";
            this.registrar.Size = new System.Drawing.Size(92, 27);
            this.registrar.TabIndex = 0;
            this.registrar.UseVisualStyleBackColor = false;
            this.registrar.Click += new System.EventHandler(this.registrar_Click);
            // 
            // cajarecar
            // 
            this.cajarecar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cajarecar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajarecar.Location = new System.Drawing.Point(401, 126);
            this.cajarecar.Name = "cajarecar";
            this.cajarecar.Size = new System.Drawing.Size(182, 19);
            this.cajarecar.TabIndex = 1;
            // 
            // cajaregcont
            // 
            this.cajaregcont.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cajaregcont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajaregcont.Location = new System.Drawing.Point(401, 209);
            this.cajaregcont.Name = "cajaregcont";
            this.cajaregcont.PasswordChar = '*';
            this.cajaregcont.Size = new System.Drawing.Size(182, 19);
            this.cajaregcont.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(600, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(569, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CalcFis.Properties.Resources.Registro_alumno;
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cajaregcont);
            this.Controls.Add(this.cajarecar);
            this.Controls.Add(this.registrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registrar;
        private System.Windows.Forms.TextBox cajarecar;
        private System.Windows.Forms.TextBox cajaregcont;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}