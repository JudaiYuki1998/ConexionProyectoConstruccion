namespace CapaPresentacion
{
    partial class CrearProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearProducto));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CmbEstadoModulos = new System.Windows.Forms.ComboBox();
            this.BtnSalirModulo = new System.Windows.Forms.Button();
            this.BtnGuardarModulo = new System.Windows.Forms.Button();
            this.TxtObjeto = new System.Windows.Forms.TextBox();
            this.TxtModulo = new System.Windows.Forms.TextBox();
            this.TxtIdModulo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // CmbEstadoModulos
            // 
            this.CmbEstadoModulos.FormattingEnabled = true;
            this.CmbEstadoModulos.Items.AddRange(new object[] {
            "A",
            "I"});
            this.CmbEstadoModulos.Location = new System.Drawing.Point(249, 295);
            this.CmbEstadoModulos.Margin = new System.Windows.Forms.Padding(2);
            this.CmbEstadoModulos.Name = "CmbEstadoModulos";
            this.CmbEstadoModulos.Size = new System.Drawing.Size(82, 21);
            this.CmbEstadoModulos.TabIndex = 46;
            this.CmbEstadoModulos.SelectedIndexChanged += new System.EventHandler(this.CmbEstadoModulos_SelectedIndexChanged);
            // 
            // BtnSalirModulo
            // 
            this.BtnSalirModulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalirModulo.Location = new System.Drawing.Point(488, 325);
            this.BtnSalirModulo.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSalirModulo.Name = "BtnSalirModulo";
            this.BtnSalirModulo.Size = new System.Drawing.Size(105, 29);
            this.BtnSalirModulo.TabIndex = 45;
            this.BtnSalirModulo.Text = "SALIR";
            this.BtnSalirModulo.UseVisualStyleBackColor = true;
            this.BtnSalirModulo.Click += new System.EventHandler(this.BtnSalirModulo_Click);
            // 
            // BtnGuardarModulo
            // 
            this.BtnGuardarModulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarModulo.Location = new System.Drawing.Point(357, 325);
            this.BtnGuardarModulo.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuardarModulo.Name = "BtnGuardarModulo";
            this.BtnGuardarModulo.Size = new System.Drawing.Size(101, 29);
            this.BtnGuardarModulo.TabIndex = 44;
            this.BtnGuardarModulo.Text = "GUARDAR MODULO";
            this.BtnGuardarModulo.UseVisualStyleBackColor = true;
            // 
            // TxtObjeto
            // 
            this.TxtObjeto.Location = new System.Drawing.Point(249, 215);
            this.TxtObjeto.Margin = new System.Windows.Forms.Padding(2);
            this.TxtObjeto.Name = "TxtObjeto";
            this.TxtObjeto.Size = new System.Drawing.Size(421, 20);
            this.TxtObjeto.TabIndex = 43;
            // 
            // TxtModulo
            // 
            this.TxtModulo.Location = new System.Drawing.Point(249, 176);
            this.TxtModulo.Margin = new System.Windows.Forms.Padding(2);
            this.TxtModulo.Name = "TxtModulo";
            this.TxtModulo.Size = new System.Drawing.Size(421, 20);
            this.TxtModulo.TabIndex = 42;
            // 
            // TxtIdModulo
            // 
            this.TxtIdModulo.Location = new System.Drawing.Point(249, 136);
            this.TxtIdModulo.Margin = new System.Windows.Forms.Padding(2);
            this.TxtIdModulo.Name = "TxtIdModulo";
            this.TxtIdModulo.Size = new System.Drawing.Size(421, 20);
            this.TxtIdModulo.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label10.Font = new System.Drawing.Font("Wide Latin", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(72, 218);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 14);
            this.label10.TabIndex = 40;
            this.label10.Text = "VALOR:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label7.Font = new System.Drawing.Font("Wide Latin", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(72, 303);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 14);
            this.label7.TabIndex = 39;
            this.label7.Text = "ESTADO:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label8.Font = new System.Drawing.Font("Wide Latin", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(72, 179);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 14);
            this.label8.TabIndex = 38;
            this.label8.Text = "PRODUCTO:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label9.Font = new System.Drawing.Font("Wide Latin", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(72, 136);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 14);
            this.label9.TabIndex = 37;
            this.label9.Text = "ID PRODUCTO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(407, 37);
            this.label2.TabIndex = 36;
            this.label2.Text = "INSERTAR PRODUCTOS";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(249, 257);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(421, 20);
            this.textBox1.TabIndex = 49;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Wide Latin", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 260);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 14);
            this.label1.TabIndex = 48;
            this.label1.Text = "CANTIDAD:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CrearProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CmbEstadoModulos);
            this.Controls.Add(this.BtnSalirModulo);
            this.Controls.Add(this.BtnGuardarModulo);
            this.Controls.Add(this.TxtObjeto);
            this.Controls.Add(this.TxtModulo);
            this.Controls.Add(this.TxtIdModulo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Name = "CrearProducto";
            this.Text = "CrearProducto";
            this.Load += new System.EventHandler(this.CrearProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox CmbEstadoModulos;
        private System.Windows.Forms.Button BtnSalirModulo;
        private System.Windows.Forms.Button BtnGuardarModulo;
        private System.Windows.Forms.TextBox TxtObjeto;
        private System.Windows.Forms.TextBox TxtModulo;
        private System.Windows.Forms.TextBox TxtIdModulo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}