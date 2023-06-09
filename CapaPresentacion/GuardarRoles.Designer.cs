namespace CapaPresentacion
{
    partial class GuardarRoles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuardarRoles));
            this.TxtNombreRol = new System.Windows.Forms.TextBox();
            this.TxtIdRol = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnGuardarRol = new System.Windows.Forms.Button();
            this.BtnSalirRol = new System.Windows.Forms.Button();
            this.CmbEstadoRoles = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNombreRol
            // 
            this.TxtNombreRol.Location = new System.Drawing.Point(493, 326);
            this.TxtNombreRol.Name = "TxtNombreRol";
            this.TxtNombreRol.Size = new System.Drawing.Size(508, 26);
            this.TxtNombreRol.TabIndex = 14;
            this.TxtNombreRol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreRol_KeyPress);
            // 
            // TxtIdRol
            // 
            this.TxtIdRol.Location = new System.Drawing.Point(493, 264);
            this.TxtIdRol.Name = "TxtIdRol";
            this.TxtIdRol.Size = new System.Drawing.Size(508, 26);
            this.TxtIdRol.TabIndex = 13;
            this.TxtIdRol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIdRol_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(368, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "ESTADO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(368, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "ROL:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "ID ROL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(575, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 55);
            this.label3.TabIndex = 9;
            this.label3.Text = "ROLES";
            // 
            // BtnGuardarRol
            // 
            this.BtnGuardarRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarRol.Location = new System.Drawing.Point(585, 519);
            this.BtnGuardarRol.Name = "BtnGuardarRol";
            this.BtnGuardarRol.Size = new System.Drawing.Size(163, 42);
            this.BtnGuardarRol.TabIndex = 16;
            this.BtnGuardarRol.Text = "GUARDAR ROL";
            this.BtnGuardarRol.UseVisualStyleBackColor = true;
            this.BtnGuardarRol.Click += new System.EventHandler(this.BtnGuardarRol_Click);
            // 
            // BtnSalirRol
            // 
            this.BtnSalirRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalirRol.Location = new System.Drawing.Point(800, 519);
            this.BtnSalirRol.Name = "BtnSalirRol";
            this.BtnSalirRol.Size = new System.Drawing.Size(157, 42);
            this.BtnSalirRol.TabIndex = 17;
            this.BtnSalirRol.Text = "SALIR";
            this.BtnSalirRol.UseVisualStyleBackColor = true;
            this.BtnSalirRol.Click += new System.EventHandler(this.BtnSalirRol_Click);
            // 
            // CmbEstadoRoles
            // 
            this.CmbEstadoRoles.FormattingEnabled = true;
            this.CmbEstadoRoles.Items.AddRange(new object[] {
            "A",
            "I"});
            this.CmbEstadoRoles.Location = new System.Drawing.Point(493, 388);
            this.CmbEstadoRoles.Name = "CmbEstadoRoles";
            this.CmbEstadoRoles.Size = new System.Drawing.Size(121, 28);
            this.CmbEstadoRoles.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(116, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // GuardarRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1427, 683);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CmbEstadoRoles);
            this.Controls.Add(this.BtnSalirRol);
            this.Controls.Add(this.BtnGuardarRol);
            this.Controls.Add(this.TxtNombreRol);
            this.Controls.Add(this.TxtIdRol);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GuardarRoles";
            this.Text = "INSERTAR ROLES";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtNombreRol;
        private System.Windows.Forms.TextBox TxtIdRol;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnGuardarRol;
        private System.Windows.Forms.Button BtnSalirRol;
        private System.Windows.Forms.ComboBox CmbEstadoRoles;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}