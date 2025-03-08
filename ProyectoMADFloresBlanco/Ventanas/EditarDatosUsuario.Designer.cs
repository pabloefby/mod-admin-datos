namespace ProyectoMADFloresBlanco.Ventanas
{
    partial class EditarDatosUsuario
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favoritosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textNomComp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateFechaNac = new System.Windows.Forms.DateTimePicker();
            this.comboGenero = new System.Windows.Forms.ComboBox();
            this.comboFuente = new System.Windows.Forms.ComboBox();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonContraseña = new System.Windows.Forms.Button();
            this.labelNomUser = new System.Windows.Forms.Label();
            this.textPaterno = new System.Windows.Forms.TextBox();
            this.textMaterno = new System.Windows.Forms.TextBox();
            this.buttonBaja = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaToolStripMenuItem,
            this.busquedaToolStripMenuItem,
            this.favoritosToolStripMenuItem,
            this.historialToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.sesionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(29, 7, 0, 7);
            this.menuStrip1.Size = new System.Drawing.Size(792, 38);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Info;
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.consultaToolStripMenuItem.Text = "Consulta";
            this.consultaToolStripMenuItem.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
            // 
            // busquedaToolStripMenuItem
            // 
            this.busquedaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busquedaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Info;
            this.busquedaToolStripMenuItem.Name = "busquedaToolStripMenuItem";
            this.busquedaToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.busquedaToolStripMenuItem.Text = "Busqueda";
            this.busquedaToolStripMenuItem.Click += new System.EventHandler(this.busquedaToolStripMenuItem_Click);
            // 
            // favoritosToolStripMenuItem
            // 
            this.favoritosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.favoritosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Info;
            this.favoritosToolStripMenuItem.Name = "favoritosToolStripMenuItem";
            this.favoritosToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.favoritosToolStripMenuItem.Text = "Favoritos";
            this.favoritosToolStripMenuItem.Click += new System.EventHandler(this.favoritosToolStripMenuItem_Click);
            // 
            // historialToolStripMenuItem
            // 
            this.historialToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historialToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Info;
            this.historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            this.historialToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.historialToolStripMenuItem.Text = "Historial";
            this.historialToolStripMenuItem.Click += new System.EventHandler(this.historialToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem,
            this.ListaToolStripMenuItem});
            this.usuariosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuariosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Info;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.registrarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Info;
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.registrarToolStripMenuItem.Text = "Registrar";
            this.registrarToolStripMenuItem.Click += new System.EventHandler(this.registrarToolStripMenuItem_Click);
            // 
            // ListaToolStripMenuItem
            // 
            this.ListaToolStripMenuItem.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ListaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Info;
            this.ListaToolStripMenuItem.Name = "ListaToolStripMenuItem";
            this.ListaToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.ListaToolStripMenuItem.Text = "Lista";
            this.ListaToolStripMenuItem.Click += new System.EventHandler(this.ListaToolStripMenuItem_Click);
            // 
            // sesionToolStripMenuItem
            // 
            this.sesionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuItem,
            this.editarDatosToolStripMenuItem});
            this.sesionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sesionToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Info;
            this.sesionToolStripMenuItem.Name = "sesionToolStripMenuItem";
            this.sesionToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.sesionToolStripMenuItem.Text = "Sesión";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.cerrarSesiónToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Info;
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // editarDatosToolStripMenuItem
            // 
            this.editarDatosToolStripMenuItem.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.editarDatosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Info;
            this.editarDatosToolStripMenuItem.Name = "editarDatosToolStripMenuItem";
            this.editarDatosToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.editarDatosToolStripMenuItem.Text = "Editar datos";
            this.editarDatosToolStripMenuItem.Click += new System.EventHandler(this.editarDatosToolStripMenuItem_Click);
            // 
            // textNomComp
            // 
            this.textNomComp.Location = new System.Drawing.Point(394, 134);
            this.textNomComp.Name = "textNomComp";
            this.textNomComp.ShortcutsEnabled = false;
            this.textNomComp.Size = new System.Drawing.Size(221, 30);
            this.textNomComp.TabIndex = 35;
            this.textNomComp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNomComp_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 21);
            this.label4.TabIndex = 40;
            this.label4.Text = "Cambie los datos que desee:";
            // 
            // dateFechaNac
            // 
            this.dateFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechaNac.Location = new System.Drawing.Point(394, 296);
            this.dateFechaNac.MaxDate = new System.DateTime(2024, 5, 9, 0, 0, 0, 0);
            this.dateFechaNac.Name = "dateFechaNac";
            this.dateFechaNac.Size = new System.Drawing.Size(184, 30);
            this.dateFechaNac.TabIndex = 41;
            this.dateFechaNac.Value = new System.DateTime(2024, 5, 9, 0, 0, 0, 0);
            // 
            // comboGenero
            // 
            this.comboGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGenero.FormattingEnabled = true;
            this.comboGenero.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.comboGenero.Location = new System.Drawing.Point(394, 343);
            this.comboGenero.Name = "comboGenero";
            this.comboGenero.Size = new System.Drawing.Size(142, 29);
            this.comboGenero.TabIndex = 42;
            // 
            // comboFuente
            // 
            this.comboFuente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFuente.FormattingEnabled = true;
            this.comboFuente.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "13"});
            this.comboFuente.Location = new System.Drawing.Point(394, 394);
            this.comboFuente.Name = "comboFuente";
            this.comboFuente.Size = new System.Drawing.Size(101, 29);
            this.comboFuente.TabIndex = 44;
            this.comboFuente.SelectedIndexChanged += new System.EventHandler(this.comboFuente_SelectedIndexChanged);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificar.Location = new System.Drawing.Point(89, 503);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(198, 38);
            this.buttonModificar.TabIndex = 45;
            this.buttonModificar.Text = "Modificar datos";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonContraseña
            // 
            this.buttonContraseña.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContraseña.Location = new System.Drawing.Point(314, 503);
            this.buttonContraseña.Name = "buttonContraseña";
            this.buttonContraseña.Size = new System.Drawing.Size(198, 38);
            this.buttonContraseña.TabIndex = 46;
            this.buttonContraseña.Text = "Cambiar contraseña";
            this.buttonContraseña.UseVisualStyleBackColor = true;
            this.buttonContraseña.Click += new System.EventHandler(this.buttonContraseña_Click);
            // 
            // labelNomUser
            // 
            this.labelNomUser.AutoSize = true;
            this.labelNomUser.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomUser.Location = new System.Drawing.Point(43, 49);
            this.labelNomUser.Name = "labelNomUser";
            this.labelNomUser.Size = new System.Drawing.Size(62, 18);
            this.labelNomUser.TabIndex = 47;
            this.labelNomUser.Text = "Usuario";
            // 
            // textPaterno
            // 
            this.textPaterno.Location = new System.Drawing.Point(394, 186);
            this.textPaterno.Name = "textPaterno";
            this.textPaterno.ShortcutsEnabled = false;
            this.textPaterno.Size = new System.Drawing.Size(221, 30);
            this.textPaterno.TabIndex = 49;
            this.textPaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPaterno_KeyPress);
            // 
            // textMaterno
            // 
            this.textMaterno.Location = new System.Drawing.Point(394, 238);
            this.textMaterno.Name = "textMaterno";
            this.textMaterno.ShortcutsEnabled = false;
            this.textMaterno.Size = new System.Drawing.Size(221, 30);
            this.textMaterno.TabIndex = 51;
            this.textMaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textMaterno_KeyPress);
            // 
            // buttonBaja
            // 
            this.buttonBaja.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBaja.ForeColor = System.Drawing.Color.Red;
            this.buttonBaja.Location = new System.Drawing.Point(539, 503);
            this.buttonBaja.Name = "buttonBaja";
            this.buttonBaja.Size = new System.Drawing.Size(153, 38);
            this.buttonBaja.TabIndex = 52;
            this.buttonBaja.Text = "Darse de baja";
            this.buttonBaja.UseVisualStyleBackColor = true;
            this.buttonBaja.Click += new System.EventHandler(this.buttonBaja_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 53;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 21);
            this.label2.TabIndex = 54;
            this.label2.Text = "Apellido Paterno:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 21);
            this.label3.TabIndex = 55;
            this.label3.Text = "Apellido Materno:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 21);
            this.label5.TabIndex = 56;
            this.label5.Text = "Fecha de nacimiento:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(178, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 21);
            this.label6.TabIndex = 57;
            this.label6.Text = "Género:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(178, 402);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 21);
            this.label7.TabIndex = 58;
            this.label7.Text = "Tamaño de fuente:";
            // 
            // EditarDatosUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(792, 589);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNomComp);
            this.Controls.Add(this.textMaterno);
            this.Controls.Add(this.textPaterno);
            this.Controls.Add(this.comboFuente);
            this.Controls.Add(this.comboGenero);
            this.Controls.Add(this.dateFechaNac);
            this.Controls.Add(this.buttonBaja);
            this.Controls.Add(this.labelNomUser);
            this.Controls.Add(this.buttonContraseña);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditarDatosUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar datos - PalabraViva";
            this.Load += new System.EventHandler(this.EditarDatosUsuario_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favoritosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarDatosToolStripMenuItem;
        private System.Windows.Forms.TextBox textNomComp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateFechaNac;
        private System.Windows.Forms.ComboBox comboGenero;
        private System.Windows.Forms.ComboBox comboFuente;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonContraseña;
        private System.Windows.Forms.Label labelNomUser;
        private System.Windows.Forms.TextBox textPaterno;
        private System.Windows.Forms.TextBox textMaterno;
        private System.Windows.Forms.Button buttonBaja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}