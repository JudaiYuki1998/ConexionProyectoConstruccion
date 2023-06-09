namespace CapaPresentacion
{
    partial class OpcioModuloRol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpcioModuloRol));
            this.buttonEliminarRol = new System.Windows.Forms.Button();
            this.buttonEditarRoles = new System.Windows.Forms.Button();
            this.CmbEstado = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtIdOpMoRol = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtOpMoRol = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSalirRolessss = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DgvOpMoRol = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtIdRol = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOpMoRol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEliminarRol
            // 
            this.buttonEliminarRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarRol.Location = new System.Drawing.Point(1201, 330);
            this.buttonEliminarRol.Name = "buttonEliminarRol";
            this.buttonEliminarRol.Size = new System.Drawing.Size(167, 40);
            this.buttonEliminarRol.TabIndex = 35;
            this.buttonEliminarRol.Text = "ELIMINAR";
            this.buttonEliminarRol.UseVisualStyleBackColor = true;
            this.buttonEliminarRol.Click += new System.EventHandler(this.buttonEliminarRol_Click);
            // 
            // buttonEditarRoles
            // 
            this.buttonEditarRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditarRoles.Location = new System.Drawing.Point(1201, 137);
            this.buttonEditarRoles.Name = "buttonEditarRoles";
            this.buttonEditarRoles.Size = new System.Drawing.Size(167, 40);
            this.buttonEditarRoles.TabIndex = 34;
            this.buttonEditarRoles.Text = "MODIFICAR";
            this.buttonEditarRoles.UseVisualStyleBackColor = true;
            this.buttonEditarRoles.Click += new System.EventHandler(this.buttonEditarRoles_Click);
            // 
            // CmbEstado
            // 
            this.CmbEstado.AutoCompleteCustomSource.AddRange(new string[] {
            "A",
            "I"});
            this.CmbEstado.FormattingEnabled = true;
            this.CmbEstado.Items.AddRange(new object[] {
            "A",
            "I"});
            this.CmbEstado.Location = new System.Drawing.Point(527, 355);
            this.CmbEstado.Name = "CmbEstado";
            this.CmbEstado.Size = new System.Drawing.Size(123, 28);
            this.CmbEstado.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(164, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 26);
            this.label6.TabIndex = 32;
            this.label6.Text = "ESTADO:";
            // 
            // TxtIdOpMoRol
            // 
            this.TxtIdOpMoRol.Location = new System.Drawing.Point(527, 229);
            this.TxtIdOpMoRol.Multiline = true;
            this.TxtIdOpMoRol.Name = "TxtIdOpMoRol";
            this.TxtIdOpMoRol.Size = new System.Drawing.Size(598, 35);
            this.TxtIdOpMoRol.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(164, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 26);
            this.label4.TabIndex = 30;
            this.label4.Text = "ID_OPC_MODULO:";
            // 
            // TxtOpMoRol
            // 
            this.TxtOpMoRol.Location = new System.Drawing.Point(527, 160);
            this.TxtOpMoRol.Multiline = true;
            this.TxtOpMoRol.Name = "TxtOpMoRol";
            this.TxtOpMoRol.Size = new System.Drawing.Size(598, 37);
            this.TxtOpMoRol.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(164, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(357, 26);
            this.label3.TabIndex = 28;
            this.label3.Text = "ID_OPCIONES_MODULO_ROL:";
            // 
            // BtnSalirRolessss
            // 
            this.BtnSalirRolessss.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalirRolessss.Location = new System.Drawing.Point(1201, 238);
            this.BtnSalirRolessss.Name = "BtnSalirRolessss";
            this.BtnSalirRolessss.Size = new System.Drawing.Size(167, 43);
            this.BtnSalirRolessss.TabIndex = 27;
            this.BtnSalirRolessss.Text = "SALIR";
            this.BtnSalirRolessss.UseVisualStyleBackColor = true;
            this.BtnSalirRolessss.Click += new System.EventHandler(this.BtnSalirRolessss_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(686, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 37);
            this.label2.TabIndex = 26;
            this.label2.Text = "LISTA DE ROLES";
            // 
            // DgvOpMoRol
            // 
            this.DgvOpMoRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOpMoRol.Location = new System.Drawing.Point(12, 405);
            this.DgvOpMoRol.Name = "DgvOpMoRol";
            this.DgvOpMoRol.RowHeadersWidth = 62;
            this.DgvOpMoRol.RowTemplate.Height = 28;
            this.DgvOpMoRol.Size = new System.Drawing.Size(1451, 284);
            this.DgvOpMoRol.TabIndex = 25;
            this.DgvOpMoRol.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvOpMoRol_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(407, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(813, 59);
            this.label1.TabIndex = 24;
            this.label1.Text = "OPCIONES MODULO POR ROL";
            // 
            // TxtIdRol
            // 
            this.TxtIdRol.Location = new System.Drawing.Point(527, 292);
            this.TxtIdRol.Multiline = true;
            this.TxtIdRol.Name = "TxtIdRol";
            this.TxtIdRol.Size = new System.Drawing.Size(598, 35);
            this.TxtIdRol.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(164, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 26);
            this.label5.TabIndex = 36;
            this.label5.Text = "ID_ROL:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // OpcioModuloRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1475, 701);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TxtIdRol);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonEliminarRol);
            this.Controls.Add(this.buttonEditarRoles);
            this.Controls.Add(this.CmbEstado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtIdOpMoRol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtOpMoRol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnSalirRolessss);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DgvOpMoRol);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OpcioModuloRol";
            this.Text = "OpcioModuloRol";
            this.Load += new System.EventHandler(this.OpcioModuloRol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvOpMoRol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEliminarRol;
        private System.Windows.Forms.Button buttonEditarRoles;
        private System.Windows.Forms.ComboBox CmbEstado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtIdOpMoRol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtOpMoRol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnSalirRolessss;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DgvOpMoRol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtIdRol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}