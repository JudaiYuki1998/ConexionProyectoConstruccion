namespace CapaPresentacion
{
    partial class Modulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modulos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DgvModulos = new System.Windows.Forms.DataGridView();
            this.BtnSalirmodulosss = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxIDModulo = new System.Windows.Forms.TextBox();
            this.TextBoxModulo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxObjeto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxEstadoModulo = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvModulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(408, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(537, 108);
            this.label1.TabIndex = 0;
            this.label1.Text = "MODULOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(528, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(345, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "LISTA DE MODULOS";
            // 
            // DgvModulos
            // 
            this.DgvModulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvModulos.Location = new System.Drawing.Point(24, 453);
            this.DgvModulos.Name = "DgvModulos";
            this.DgvModulos.RowHeadersWidth = 62;
            this.DgvModulos.RowTemplate.Height = 28;
            this.DgvModulos.Size = new System.Drawing.Size(1360, 228);
            this.DgvModulos.TabIndex = 2;
            this.DgvModulos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvModulos_CellClick);
            // 
            // BtnSalirmodulosss
            // 
            this.BtnSalirmodulosss.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalirmodulosss.Location = new System.Drawing.Point(1134, 366);
            this.BtnSalirmodulosss.Name = "BtnSalirmodulosss";
            this.BtnSalirmodulosss.Size = new System.Drawing.Size(167, 40);
            this.BtnSalirmodulosss.TabIndex = 3;
            this.BtnSalirmodulosss.Text = "SALIR";
            this.BtnSalirmodulosss.UseVisualStyleBackColor = true;
            this.BtnSalirmodulosss.Click += new System.EventHandler(this.BtnSalirmodulosss_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditar.Location = new System.Drawing.Point(1134, 147);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(167, 40);
            this.buttonEditar.TabIndex = 4;
            this.buttonEditar.Text = "MODIFICAR";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Location = new System.Drawing.Point(1134, 261);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(167, 40);
            this.buttonEliminar.TabIndex = 5;
            this.buttonEliminar.Text = "ELIMINAR";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(160, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID MODULO:";
            // 
            // TextBoxIDModulo
            // 
            this.TextBoxIDModulo.Location = new System.Drawing.Point(321, 150);
            this.TextBoxIDModulo.Multiline = true;
            this.TextBoxIDModulo.Name = "TextBoxIDModulo";
            this.TextBoxIDModulo.Size = new System.Drawing.Size(715, 37);
            this.TextBoxIDModulo.TabIndex = 7;
            this.TextBoxIDModulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxIDModulo_KeyPress);
            // 
            // TextBoxModulo
            // 
            this.TextBoxModulo.Location = new System.Drawing.Point(321, 217);
            this.TextBoxModulo.Multiline = true;
            this.TextBoxModulo.Name = "TextBoxModulo";
            this.TextBoxModulo.Size = new System.Drawing.Size(715, 37);
            this.TextBoxModulo.TabIndex = 9;
            this.TextBoxModulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxModulo_KeyPress);
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(160, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "MODULO:";
            // 
            // TextBoxObjeto
            // 
            this.TextBoxObjeto.Location = new System.Drawing.Point(321, 277);
            this.TextBoxObjeto.Multiline = true;
            this.TextBoxObjeto.Name = "TextBoxObjeto";
            this.TextBoxObjeto.Size = new System.Drawing.Size(715, 37);
            this.TextBoxObjeto.TabIndex = 11;
            this.TextBoxObjeto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxObjeto_KeyPress);
            // 
            // label5
            // 
            this.label5.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(160, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "OBJETO:";
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(160, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 26);
            this.label6.TabIndex = 12;
            this.label6.Text = "ESTADO:";
            // 
            // comboBoxEstadoModulo
            // 
            this.comboBoxEstadoModulo.AutoCompleteCustomSource.AddRange(new string[] {
            "A",
            "I"});
            this.comboBoxEstadoModulo.FormattingEnabled = true;
            this.comboBoxEstadoModulo.Items.AddRange(new object[] {
            "A",
            "I"});
            this.comboBoxEstadoModulo.Location = new System.Drawing.Point(321, 333);
            this.comboBoxEstadoModulo.Name = "comboBoxEstadoModulo";
            this.comboBoxEstadoModulo.Size = new System.Drawing.Size(123, 28);
            this.comboBoxEstadoModulo.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Modulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1396, 706);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxEstadoModulo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TextBoxObjeto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextBoxModulo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBoxIDModulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.BtnSalirmodulosss);
            this.Controls.Add(this.DgvModulos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Modulos";
            this.Text = "Modulos";
            this.Load += new System.EventHandler(this.Modulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvModulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DgvModulos;
        private System.Windows.Forms.Button BtnSalirmodulosss;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxIDModulo;
        private System.Windows.Forms.TextBox TextBoxModulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxObjeto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxEstadoModulo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}