namespace CapaPresentacion
{
    partial class Opmodulosver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Opmodulosver));
            this.BtnSalirOpModulos = new System.Windows.Forms.Button();
            this.DgvOpModulos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnModificarOpModulo = new System.Windows.Forms.Button();
            this.bTN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtIpOpMo = new System.Windows.Forms.TextBox();
            this.CmbEstado = new System.Windows.Forms.ComboBox();
            this.TxtNombreOp = new System.Windows.Forms.TextBox();
            this.TxtNombreObjeto = new System.Windows.Forms.TextBox();
            this.TxtIdModulo = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOpModulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSalirOpModulos
            // 
            this.BtnSalirOpModulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalirOpModulos.Location = new System.Drawing.Point(1240, 290);
            this.BtnSalirOpModulos.Name = "BtnSalirOpModulos";
            this.BtnSalirOpModulos.Size = new System.Drawing.Size(194, 44);
            this.BtnSalirOpModulos.TabIndex = 8;
            this.BtnSalirOpModulos.Text = "SALIR";
            this.BtnSalirOpModulos.UseVisualStyleBackColor = true;
            this.BtnSalirOpModulos.Click += new System.EventHandler(this.BtnSalirOpModulos_Click);
            // 
            // DgvOpModulos
            // 
            this.DgvOpModulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOpModulos.Location = new System.Drawing.Point(12, 425);
            this.DgvOpModulos.Name = "DgvOpModulos";
            this.DgvOpModulos.RowHeadersWidth = 62;
            this.DgvOpModulos.RowTemplate.Height = 28;
            this.DgvOpModulos.Size = new System.Drawing.Size(1479, 213);
            this.DgvOpModulos.TabIndex = 7;
            this.DgvOpModulos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvOpModulos_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(673, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "LISTA DE OPCIONES";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(393, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(944, 82);
            this.label1.TabIndex = 5;
            this.label1.Text = "OPCIONES POR MODULO";
            // 
            // BtnModificarOpModulo
            // 
            this.BtnModificarOpModulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificarOpModulo.Location = new System.Drawing.Point(1240, 126);
            this.BtnModificarOpModulo.Name = "BtnModificarOpModulo";
            this.BtnModificarOpModulo.Size = new System.Drawing.Size(194, 44);
            this.BtnModificarOpModulo.TabIndex = 9;
            this.BtnModificarOpModulo.Text = "MODIFICAR";
            this.BtnModificarOpModulo.UseVisualStyleBackColor = true;
            this.BtnModificarOpModulo.Click += new System.EventHandler(this.BtnModificarOpModulo_Click);
            // 
            // bTN
            // 
            this.bTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTN.Location = new System.Drawing.Point(1240, 203);
            this.bTN.Name = "bTN";
            this.bTN.Size = new System.Drawing.Size(194, 44);
            this.bTN.TabIndex = 10;
            this.bTN.Text = "ELIMINAR";
            this.bTN.UseVisualStyleBackColor = true;
            this.bTN.Click += new System.EventHandler(this.bTN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(178, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "ID/OP/MODULO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(173, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "ESTADO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(173, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "ID MODULO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(173, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(243, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "NOMBRE OBJETO:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(173, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(274, 29);
            this.label7.TabIndex = 15;
            this.label7.Text = "NOMBRE OPCIONES:";
            // 
            // TxtIpOpMo
            // 
            this.TxtIpOpMo.Location = new System.Drawing.Point(455, 104);
            this.TxtIpOpMo.Multiline = true;
            this.TxtIpOpMo.Name = "TxtIpOpMo";
            this.TxtIpOpMo.Size = new System.Drawing.Size(705, 32);
            this.TxtIpOpMo.TabIndex = 16;
            // 
            // CmbEstado
            // 
            this.CmbEstado.FormattingEnabled = true;
            this.CmbEstado.Items.AddRange(new object[] {
            "A",
            "I"});
            this.CmbEstado.Location = new System.Drawing.Point(455, 351);
            this.CmbEstado.Name = "CmbEstado";
            this.CmbEstado.Size = new System.Drawing.Size(121, 28);
            this.CmbEstado.TabIndex = 17;
            // 
            // TxtNombreOp
            // 
            this.TxtNombreOp.Location = new System.Drawing.Point(453, 172);
            this.TxtNombreOp.Multiline = true;
            this.TxtNombreOp.Name = "TxtNombreOp";
            this.TxtNombreOp.Size = new System.Drawing.Size(705, 32);
            this.TxtNombreOp.TabIndex = 18;
            // 
            // TxtNombreObjeto
            // 
            this.TxtNombreObjeto.Location = new System.Drawing.Point(455, 231);
            this.TxtNombreObjeto.Multiline = true;
            this.TxtNombreObjeto.Name = "TxtNombreObjeto";
            this.TxtNombreObjeto.Size = new System.Drawing.Size(705, 32);
            this.TxtNombreObjeto.TabIndex = 19;
            // 
            // TxtIdModulo
            // 
            this.TxtIdModulo.Location = new System.Drawing.Point(455, 290);
            this.TxtIdModulo.Multiline = true;
            this.TxtIdModulo.Name = "TxtIdModulo";
            this.TxtIdModulo.Size = new System.Drawing.Size(705, 32);
            this.TxtIdModulo.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // Opmodulosver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1503, 696);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TxtIdModulo);
            this.Controls.Add(this.TxtNombreObjeto);
            this.Controls.Add(this.TxtNombreOp);
            this.Controls.Add(this.CmbEstado);
            this.Controls.Add(this.TxtIpOpMo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bTN);
            this.Controls.Add(this.BtnModificarOpModulo);
            this.Controls.Add(this.BtnSalirOpModulos);
            this.Controls.Add(this.DgvOpModulos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Opmodulosver";
            this.Text = "Opmodulosver";
            this.Load += new System.EventHandler(this.Opmodulosver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvOpModulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSalirOpModulos;
        private System.Windows.Forms.DataGridView DgvOpModulos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnModificarOpModulo;
        private System.Windows.Forms.Button bTN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtIpOpMo;
        private System.Windows.Forms.ComboBox CmbEstado;
        private System.Windows.Forms.TextBox TxtNombreOp;
        private System.Windows.Forms.TextBox TxtNombreObjeto;
        private System.Windows.Forms.TextBox TxtIdModulo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}