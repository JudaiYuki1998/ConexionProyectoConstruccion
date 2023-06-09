namespace CapaPresentacion
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            this.label1 = new System.Windows.Forms.Label();
            this.DgvUsuarios = new System.Windows.Forms.DataGridView();
            this.BtnSalirUsuariosssss = new System.Windows.Forms.Button();
            this.buttonEliminarUsuarios = new System.Windows.Forms.Button();
            this.buttonEditarUsuarios = new System.Windows.Forms.Button();
            this.TxtIdRol = new System.Windows.Forms.TextBox();
            this.TxtClave = new System.Windows.Forms.TextBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtIdUsuario = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.CmbEstado = new System.Windows.Forms.ComboBox();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.Txttelefono = new System.Windows.Forms.TextBox();
            this.TxtNombreUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(380, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "VENDEDOR";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DgvUsuarios
            // 
            this.DgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsuarios.Location = new System.Drawing.Point(8, 299);
            this.DgvUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.DgvUsuarios.Name = "DgvUsuarios";
            this.DgvUsuarios.RowHeadersWidth = 62;
            this.DgvUsuarios.RowTemplate.Height = 28;
            this.DgvUsuarios.Size = new System.Drawing.Size(999, 119);
            this.DgvUsuarios.TabIndex = 3;
            this.DgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUsuarios_CellClick);
            // 
            // BtnSalirUsuariosssss
            // 
            this.BtnSalirUsuariosssss.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalirUsuariosssss.Location = new System.Drawing.Point(507, 422);
            this.BtnSalirUsuariosssss.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSalirUsuariosssss.Name = "BtnSalirUsuariosssss";
            this.BtnSalirUsuariosssss.Size = new System.Drawing.Size(111, 26);
            this.BtnSalirUsuariosssss.TabIndex = 4;
            this.BtnSalirUsuariosssss.Text = "SALIR";
            this.BtnSalirUsuariosssss.UseVisualStyleBackColor = true;
            this.BtnSalirUsuariosssss.Click += new System.EventHandler(this.BtnSalirUsuariosssss_Click);
            // 
            // buttonEliminarUsuarios
            // 
            this.buttonEliminarUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarUsuarios.Location = new System.Drawing.Point(392, 422);
            this.buttonEliminarUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEliminarUsuarios.Name = "buttonEliminarUsuarios";
            this.buttonEliminarUsuarios.Size = new System.Drawing.Size(111, 26);
            this.buttonEliminarUsuarios.TabIndex = 31;
            this.buttonEliminarUsuarios.Text = "ELIMINAR";
            this.buttonEliminarUsuarios.UseVisualStyleBackColor = true;
            this.buttonEliminarUsuarios.Click += new System.EventHandler(this.buttonEliminarUsuarios_Click);
            // 
            // buttonEditarUsuarios
            // 
            this.buttonEditarUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditarUsuarios.Location = new System.Drawing.Point(277, 422);
            this.buttonEditarUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEditarUsuarios.Name = "buttonEditarUsuarios";
            this.buttonEditarUsuarios.Size = new System.Drawing.Size(111, 26);
            this.buttonEditarUsuarios.TabIndex = 30;
            this.buttonEditarUsuarios.Text = "MODIFICAR";
            this.buttonEditarUsuarios.UseVisualStyleBackColor = true;
            this.buttonEditarUsuarios.Click += new System.EventHandler(this.buttonEditarUsuarios_Click);
            // 
            // TxtIdRol
            // 
            this.TxtIdRol.Location = new System.Drawing.Point(159, 213);
            this.TxtIdRol.Margin = new System.Windows.Forms.Padding(2);
            this.TxtIdRol.Name = "TxtIdRol";
            this.TxtIdRol.Size = new System.Drawing.Size(247, 20);
            this.TxtIdRol.TabIndex = 61;
            // 
            // TxtClave
            // 
            this.TxtClave.Location = new System.Drawing.Point(160, 169);
            this.TxtClave.Margin = new System.Windows.Forms.Padding(2);
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.Size = new System.Drawing.Size(247, 20);
            this.TxtClave.TabIndex = 51;
            this.TxtClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtClave_KeyPress);
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(162, 130);
            this.TxtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(247, 20);
            this.TxtUsuario.TabIndex = 50;
            this.TxtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUsuario_KeyPress);
            // 
            // TxtIdUsuario
            // 
            this.TxtIdUsuario.Location = new System.Drawing.Point(163, 90);
            this.TxtIdUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.TxtIdUsuario.Name = "TxtIdUsuario";
            this.TxtIdUsuario.Size = new System.Drawing.Size(247, 20);
            this.TxtIdUsuario.TabIndex = 49;
            this.TxtIdUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIdUsuario_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label10.Font = new System.Drawing.Font("Wide Latin", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 174);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 14);
            this.label10.TabIndex = 48;
            this.label10.Text = "CLAVE:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label8.Font = new System.Drawing.Font("Wide Latin", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 214);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 14);
            this.label8.TabIndex = 47;
            this.label8.Text = "ID_ROL:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label9.Font = new System.Drawing.Font("Wide Latin", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 133);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 14);
            this.label9.TabIndex = 46;
            this.label9.Text = "USERNAME:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label11.Font = new System.Drawing.Font("Wide Latin", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 93);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 14);
            this.label11.TabIndex = 45;
            this.label11.Text = "ID USUARIO:";
            // 
            // CmbEstado
            // 
            this.CmbEstado.FormattingEnabled = true;
            this.CmbEstado.Items.AddRange(new object[] {
            "A",
            "I"});
            this.CmbEstado.Location = new System.Drawing.Point(564, 237);
            this.CmbEstado.Margin = new System.Windows.Forms.Padding(2);
            this.CmbEstado.Name = "CmbEstado";
            this.CmbEstado.Size = new System.Drawing.Size(82, 21);
            this.CmbEstado.TabIndex = 82;
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(564, 198);
            this.TxtMail.Margin = new System.Windows.Forms.Padding(2);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(421, 20);
            this.TxtMail.TabIndex = 81;
            this.TxtMail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMail_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label6.Font = new System.Drawing.Font("Wide Latin", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(412, 213);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 14);
            this.label6.TabIndex = 80;
            this.label6.Text = "MAIL:";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(564, 166);
            this.TxtDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(421, 20);
            this.TxtDireccion.TabIndex = 79;
            this.TxtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDireccion_KeyPress);
            // 
            // Txttelefono
            // 
            this.Txttelefono.Location = new System.Drawing.Point(564, 127);
            this.Txttelefono.Margin = new System.Windows.Forms.Padding(2);
            this.Txttelefono.Name = "Txttelefono";
            this.Txttelefono.Size = new System.Drawing.Size(443, 20);
            this.Txttelefono.TabIndex = 78;
            this.Txttelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txttelefono_KeyPress);
            // 
            // TxtNombreUsuario
            // 
            this.TxtNombreUsuario.Location = new System.Drawing.Point(661, 87);
            this.TxtNombreUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNombreUsuario.Name = "TxtNombreUsuario";
            this.TxtNombreUsuario.Size = new System.Drawing.Size(346, 20);
            this.TxtNombreUsuario.TabIndex = 77;
            this.TxtNombreUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreUsuario_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Wide Latin", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(412, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 14);
            this.label3.TabIndex = 76;
            this.label3.Text = "DIRECCION:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label4.Font = new System.Drawing.Font("Wide Latin", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(412, 243);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 14);
            this.label4.TabIndex = 75;
            this.label4.Text = "ESTADO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label5.Font = new System.Drawing.Font("Wide Latin", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(412, 130);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 14);
            this.label5.TabIndex = 74;
            this.label5.Text = "TELEFONO:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label7.Font = new System.Drawing.Font("Wide Latin", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(412, 92);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(245, 14);
            this.label7.TabIndex = 73;
            this.label7.Text = "NOMBRE VENDEDOR";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 83;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(377, 271);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "LISTA DE VENDEDORES";
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1045, 456);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CmbEstado);
            this.Controls.Add(this.TxtMail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.Txttelefono);
            this.Controls.Add(this.TxtNombreUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtIdRol);
            this.Controls.Add(this.TxtClave);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.TxtIdUsuario);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.buttonEliminarUsuarios);
            this.Controls.Add(this.buttonEditarUsuarios);
            this.Controls.Add(this.BtnSalirUsuariosssss);
            this.Controls.Add(this.DgvUsuarios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvUsuarios;
        private System.Windows.Forms.Button BtnSalirUsuariosssss;
        private System.Windows.Forms.Button buttonEliminarUsuarios;
        private System.Windows.Forms.Button buttonEditarUsuarios;
        private System.Windows.Forms.TextBox TxtIdRol;
        private System.Windows.Forms.TextBox TxtClave;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtIdUsuario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CmbEstado;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.TextBox Txttelefono;
        private System.Windows.Forms.TextBox TxtNombreUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}