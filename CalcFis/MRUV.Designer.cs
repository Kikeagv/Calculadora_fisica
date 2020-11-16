namespace CalcFis
{
    partial class MRUV
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cajatiempo = new System.Windows.Forms.TextBox();
            this.cajadist = new System.Windows.Forms.TextBox();
            this.cajavi = new System.Windows.Forms.TextBox();
            this.cajavf = new System.Windows.Forms.TextBox();
            this.cajaacel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(457, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 24);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(481, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 34);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(307, 85);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(185, 329);
            this.richTextBox1.TabIndex = 23;
            this.richTextBox1.Text = "";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Distancia",
            "Tiempo",
            "Velocidad inicial",
            "Velocidad final",
            "Aceleración"});
            this.comboBox1.Location = new System.Drawing.Point(51, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(112, 21);
            this.comboBox1.TabIndex = 24;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(61, 474);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 35);
            this.button2.TabIndex = 26;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.button1.Location = new System.Drawing.Point(61, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 22);
            this.button1.TabIndex = 25;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cajatiempo
            // 
            this.cajatiempo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cajatiempo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajatiempo.Location = new System.Drawing.Point(51, 210);
            this.cajatiempo.Name = "cajatiempo";
            this.cajatiempo.Size = new System.Drawing.Size(177, 19);
            this.cajatiempo.TabIndex = 27;
            this.cajatiempo.Text = "0";
            // 
            // cajadist
            // 
            this.cajadist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cajadist.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajadist.Location = new System.Drawing.Point(51, 148);
            this.cajadist.Name = "cajadist";
            this.cajadist.Size = new System.Drawing.Size(177, 19);
            this.cajadist.TabIndex = 28;
            this.cajadist.Text = "0";
            // 
            // cajavi
            // 
            this.cajavi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cajavi.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajavi.Location = new System.Drawing.Point(51, 273);
            this.cajavi.Name = "cajavi";
            this.cajavi.Size = new System.Drawing.Size(177, 19);
            this.cajavi.TabIndex = 29;
            this.cajavi.Text = "0";
            // 
            // cajavf
            // 
            this.cajavf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cajavf.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajavf.Location = new System.Drawing.Point(51, 335);
            this.cajavf.Name = "cajavf";
            this.cajavf.Size = new System.Drawing.Size(177, 19);
            this.cajavf.TabIndex = 30;
            this.cajavf.Text = "0";
            // 
            // cajaacel
            // 
            this.cajaacel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cajaacel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajaacel.Location = new System.Drawing.Point(51, 395);
            this.cajaacel.Name = "cajaacel";
            this.cajaacel.Size = new System.Drawing.Size(177, 19);
            this.cajaacel.TabIndex = 31;
            this.cajaacel.Text = "0";
            // 
            // MRUV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CalcFis.Properties.Resources.MRUV;
            this.ClientSize = new System.Drawing.Size(527, 530);
            this.Controls.Add(this.cajaacel);
            this.Controls.Add(this.cajavf);
            this.Controls.Add(this.cajavi);
            this.Controls.Add(this.cajadist);
            this.Controls.Add(this.cajatiempo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MRUV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MRUV";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox cajatiempo;
        private System.Windows.Forms.TextBox cajadist;
        private System.Windows.Forms.TextBox cajavi;
        private System.Windows.Forms.TextBox cajavf;
        private System.Windows.Forms.TextBox cajaacel;
    }
}