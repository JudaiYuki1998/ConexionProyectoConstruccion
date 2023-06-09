namespace CapaPresentacion
{
    partial class Roles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Roles));
            this.label1 = new System.Windows.Forms.Label();
            this.DgvRoles = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSalirRolessss = new System.Windows.Forms.Button();
            this.comboBoxEstadoRoles = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBoxRol = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxIdRol = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonEliminarRol = new System.Windows.Forms.Button();
            this.buttonEditarRoles = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(625, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 108);
            this.label1.TabIndex = 0;
            this.label1.Text = "ROLES";
            // 
            // DgvRoles
            // 
            this.DgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRoles.Location = new System.Drawing.Point(313, 381);
            this.DgvRoles.Name = "DgvRoles";
            this.DgvRoles.RowHeadersWidth = 62;
            this.DgvRoles.RowTemplate.Height = 28;
            this.DgvRoles.Size = new System.Drawing.Size(857, 284);
            this.DgvRoles.TabIndex = 1;
            this.DgvRoles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvRoles_CellClick);
            this.DgvRoles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvRoles_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(587, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "LISTA DE ROLES";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // BtnSalirRolessss
            // 
            this.BtnSalirRolessss.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalirRolessss.Location = new System.Drawing.Point(1144, 243);
            this.BtnSalirRolessss.Name = "BtnSalirRolessss";
            this.BtnSalirRolessss.Size = new System.Drawing.Size(167, 43);
            this.BtnSalirRolessss.TabIndex = 3;
            this.BtnSalirRolessss.Text = "SALIR";
            this.BtnSalirRolessss.UseVisualStyleBackColor = true;
            this.BtnSalirRolessss.Click += new System.EventHandler(this.BtnSalirRolessss_Click);
            // 
            // comboBoxEstadoRoles
            // 
            this.comboBoxEstadoRoles.AutoCompleteCustomSource.AddRange(new string[] {
            "A",
            "I"});
            this.comboBoxEstadoRoles.FormattingEnabled = true;
            this.comboBoxEstadoRoles.Items.AddRange(new object[] {
            "A",
            "I"});
            this.comboBoxEstadoRoles.Location = new System.Drawing.Point(304, 290);
            this.comboBoxEstadoRoles.Name = "comboBoxEstadoRoles";
            this.comboBoxEstadoRoles.Size = new System.Drawing.Size(123, 28);
            this.comboBoxEstadoRoles.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(183, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 26);
            this.label6.TabIndex = 20;
            this.label6.Text = "ESTADO:";
            // 
            // TextBoxRol
            // 
            this.TextBoxRol.Location = new System.Drawing.Point(304, 229);
            this.TextBoxRol.Multiline = true;
            this.TextBoxRol.Name = "TextBoxRol";
            this.TextBoxRol.Size = new System.Drawing.Size(715, 35);
            this.TextBoxRol.TabIndex = 17;
            this.TextBoxRol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxRol_KeyPress);
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(183, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 26);
            this.label4.TabIndex = 16;
            this.label4.Text = "ROL:";
            // 
            // TextBoxIdRol
            // 
            this.TextBoxIdRol.Location = new System.Drawing.Point(304, 162);
            this.TextBoxIdRol.Multiline = true;
            this.TextBoxIdRol.Name = "TextBoxIdRol";
            this.TextBoxIdRol.Size = new System.Drawing.Size(715, 37);
            this.TextBoxIdRol.TabIndex = 15;
            this.TextBoxIdRol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxIdRol_KeyPress);
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(183, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 26);
            this.label3.TabIndex = 14;
            this.label3.Text = "ID ROL:";
            // 
            // buttonEliminarRol
            // 
            this.buttonEliminarRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarRol.Location = new System.Drawing.Point(1144, 335);
            this.buttonEliminarRol.Name = "buttonEliminarRol";
            this.buttonEliminarRol.Size = new System.Drawing.Size(167, 40);
            this.buttonEliminarRol.TabIndex = 23;
            this.buttonEliminarRol.Text = "ELIMINAR";
            this.buttonEliminarRol.UseVisualStyleBackColor = true;
            this.buttonEliminarRol.Click += new System.EventHandler(this.buttonEliminarRol_Click);
            // 
            // buttonEditarRoles
            // 
            this.buttonEditarRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditarRoles.Location = new System.Drawing.Point(1144, 142);
            this.buttonEditarRoles.Name = "buttonEditarRoles";
            this.buttonEditarRoles.Size = new System.Drawing.Size(167, 40);
            this.buttonEditarRoles.TabIndex = 22;
            this.buttonEditarRoles.Text = "MODIFICAR";
            this.buttonEditarRoles.UseVisualStyleBackColor = true;
            this.buttonEditarRoles.Click += new System.EventHandler(this.buttonEditarRoles_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1406, 686);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonEliminarRol);
            this.Controls.Add(this.buttonEditarRoles);
            this.Controls.Add(this.comboBoxEstadoRoles);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TextBoxRol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBoxIdRol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnSalirRolessss);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DgvRoles);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Roles";
            this.Text = "Roles";
            this.Load += new System.EventHandler(this.Roles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvRoles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSalirRolessss;
        private System.Windows.Forms.ComboBox comboBoxEstadoRoles;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBoxRol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxIdRol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonEliminarRol;
        private System.Windows.Forms.Button buttonEditarRoles;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}