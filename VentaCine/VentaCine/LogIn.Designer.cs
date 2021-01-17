namespace VentaCine
{
    partial class LogIn
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textvisiblecontra = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btncontranovisible = new System.Windows.Forms.Button();
            this.btncontravisible = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gifentrada = new System.Windows.Forms.PictureBox();
            this.contraseñadar = new System.Windows.Forms.LinkLabel();
            this.cboNivel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gifentrada)).BeginInit();
            this.SuspendLayout();
            // 
            // textvisiblecontra
            // 
            this.textvisiblecontra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textvisiblecontra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textvisiblecontra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textvisiblecontra.ForeColor = System.Drawing.Color.DimGray;
            this.textvisiblecontra.Location = new System.Drawing.Point(228, 160);
            this.textvisiblecontra.Name = "textvisiblecontra";
            this.textvisiblecontra.Size = new System.Drawing.Size(312, 26);
            this.textvisiblecontra.TabIndex = 20;
            this.textvisiblecontra.Text = "CONTRASEÑA";
            this.textvisiblecontra.Visible = false;
            this.textvisiblecontra.TextChanged += new System.EventHandler(this.textvisiblecontra_TextChanged);
            this.textvisiblecontra.Enter += new System.EventHandler(this.textvisiblecontra_Enter);
            this.textvisiblecontra.Leave += new System.EventHandler(this.textvisiblecontra_Leave);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.LightGray;
            this.btnCancelar.Location = new System.Drawing.Point(440, 228);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 30);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "SALIR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.LightGray;
            this.btnIngresar.Location = new System.Drawing.Point(262, 228);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(120, 30);
            this.btnIngresar.TabIndex = 18;
            this.btnIngresar.Text = "ACCEDER";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContraseña.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.Color.DimGray;
            this.txtContraseña.Location = new System.Drawing.Point(228, 159);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(313, 26);
            this.txtContraseña.TabIndex = 16;
            this.txtContraseña.Text = "CONTRASEÑA";
            this.txtContraseña.Enter += new System.EventHandler(this.txtContraseña_Enter);
            this.txtContraseña.Leave += new System.EventHandler(this.txtContraseña_Leave);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.txtUsuario.Location = new System.Drawing.Point(228, 109);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(313, 26);
            this.txtUsuario.TabIndex = 15;
            this.txtUsuario.Text = "USUARIO";
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(259, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 40);
            this.label1.TabIndex = 12;
            this.label1.Text = "Acceso al Sistema";
            // 
            // btncontranovisible
            // 
            this.btncontranovisible.Image = global::VentaCine.Properties.Resources.ojito_pequeñonormal;
            this.btncontranovisible.Location = new System.Drawing.Point(558, 162);
            this.btncontranovisible.Name = "btncontranovisible";
            this.btncontranovisible.Size = new System.Drawing.Size(47, 24);
            this.btncontranovisible.TabIndex = 22;
            this.btncontranovisible.UseVisualStyleBackColor = true;
            this.btncontranovisible.Click += new System.EventHandler(this.btncontranovisible_Click_1);
            // 
            // btncontravisible
            // 
            this.btncontravisible.Image = global::VentaCine.Properties.Resources.ojitopequeño;
            this.btncontravisible.Location = new System.Drawing.Point(558, 160);
            this.btncontravisible.Name = "btncontravisible";
            this.btncontravisible.Size = new System.Drawing.Size(47, 24);
            this.btncontravisible.TabIndex = 21;
            this.btncontravisible.UseVisualStyleBackColor = true;
            this.btncontravisible.Visible = false;
            this.btncontravisible.Click += new System.EventHandler(this.btncontravisible_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.gifentrada);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 309);
            this.panel1.TabIndex = 23;
            // 
            // gifentrada
            // 
            this.gifentrada.Location = new System.Drawing.Point(6, 3);
            this.gifentrada.Name = "gifentrada";
            this.gifentrada.Size = new System.Drawing.Size(194, 303);
            this.gifentrada.TabIndex = 0;
            this.gifentrada.TabStop = false;
            this.gifentrada.Click += new System.EventHandler(this.gifentrada_Click);
            // 
            // contraseñadar
            // 
            this.contraseñadar.AutoSize = true;
            this.contraseñadar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseñadar.LinkColor = System.Drawing.Color.Gray;
            this.contraseñadar.Location = new System.Drawing.Point(326, 269);
            this.contraseñadar.Name = "contraseñadar";
            this.contraseñadar.Size = new System.Drawing.Size(182, 16);
            this.contraseñadar.TabIndex = 24;
            this.contraseñadar.TabStop = true;
            this.contraseñadar.Text = "¿Ha olvidado la Contraseña?";
            this.contraseñadar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.contraseñadar_LinkClicked);
            // 
            // cboNivel
            // 
            this.cboNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNivel.FormattingEnabled = true;
            this.cboNivel.Items.AddRange(new object[] {
            "Empleado",
            "Administrador"});
            this.cboNivel.Location = new System.Drawing.Point(374, 67);
            this.cboNivel.Name = "cboNivel";
            this.cboNivel.Size = new System.Drawing.Size(167, 21);
            this.cboNivel.TabIndex = 25;
            this.cboNivel.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(225, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tipo de Usuario:";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(642, 309);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboNivel);
            this.Controls.Add(this.contraseñadar);
            this.Controls.Add(this.btncontranovisible);
            this.Controls.Add(this.btncontravisible);
            this.Controls.Add(this.textvisiblecontra);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "LogIn";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log Sistema";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gifentrada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btncontranovisible;
        public System.Windows.Forms.Button btncontravisible;
        public System.Windows.Forms.TextBox textvisiblecontra;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnIngresar;
        public System.Windows.Forms.TextBox txtContraseña;
        public System.Windows.Forms.TextBox txtUsuario;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel contraseñadar;
        private System.Windows.Forms.PictureBox gifentrada;
        private System.Windows.Forms.ComboBox cboNivel;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

