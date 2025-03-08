namespace ProyectoMADFloresBlanco
{
    partial class UsuarioRegistro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emailText = new System.Windows.Forms.TextBox();
            this.contraseñaText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nombreText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.comboGenero = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.recuperacionText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.preguntaText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.registrarButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favoritosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelNomUser = new System.Windows.Forms.Label();
            this.textPaterno = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textMaterno = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ingrese los datos personales requeridos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Email:";
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(106, 144);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(337, 30);
            this.emailText.TabIndex = 16;
            // 
            // contraseñaText
            // 
            this.contraseñaText.Location = new System.Drawing.Point(470, 144);
            this.contraseñaText.Name = "contraseñaText";
            this.contraseñaText.Size = new System.Drawing.Size(337, 30);
            this.contraseñaText.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(466, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Contraseña:";
            // 
            // nombreText
            // 
            this.nombreText.Location = new System.Drawing.Point(106, 214);
            this.nombreText.Name = "nombreText";
            this.nombreText.ShortcutsEnabled = false;
            this.nombreText.Size = new System.Drawing.Size(337, 30);
            this.nombreText.TabIndex = 20;
            this.nombreText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombreText_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(102, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(466, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 21);
            this.label5.TabIndex = 21;
            this.label5.Text = "Fecha de nacimiento:";
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaNacimiento.Location = new System.Drawing.Point(470, 352);
            this.fechaNacimiento.Name = "fechaNacimiento";
            this.fechaNacimiento.Size = new System.Drawing.Size(337, 30);
            this.fechaNacimiento.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(102, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 21);
            this.label6.TabIndex = 23;
            this.label6.Text = "Género:";
            // 
            // comboGenero
            // 
            this.comboGenero.FormattingEnabled = true;
            this.comboGenero.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.comboGenero.Location = new System.Drawing.Point(106, 354);
            this.comboGenero.Name = "comboGenero";
            this.comboGenero.Size = new System.Drawing.Size(209, 29);
            this.comboGenero.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 412);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(481, 21);
            this.label7.TabIndex = 25;
            this.label7.Text = "Ingrese una pregunta y respuesta para recuperación:";
            // 
            // recuperacionText
            // 
            this.recuperacionText.Location = new System.Drawing.Point(104, 543);
            this.recuperacionText.Name = "recuperacionText";
            this.recuperacionText.Size = new System.Drawing.Size(337, 30);
            this.recuperacionText.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(100, 520);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 21);
            this.label8.TabIndex = 28;
            this.label8.Text = "Respuesta:";
            // 
            // preguntaText
            // 
            this.preguntaText.Location = new System.Drawing.Point(104, 473);
            this.preguntaText.Name = "preguntaText";
            this.preguntaText.Size = new System.Drawing.Size(337, 30);
            this.preguntaText.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(100, 450);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 21);
            this.label9.TabIndex = 26;
            this.label9.Text = "Pregunta:";
            // 
            // registrarButton
            // 
            this.registrarButton.BackColor = System.Drawing.SystemColors.Control;
            this.registrarButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarButton.Location = new System.Drawing.Point(684, 570);
            this.registrarButton.Name = "registrarButton";
            this.registrarButton.Size = new System.Drawing.Size(123, 44);
            this.registrarButton.TabIndex = 30;
            this.registrarButton.Text = "Registrar";
            this.registrarButton.UseVisualStyleBackColor = false;
            this.registrarButton.Click += new System.EventHandler(this.registrarButton_Click);
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
            this.sesiónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(21, 5, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(893, 34);
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
            // sesiónToolStripMenuItem
            // 
            this.sesiónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuItem,
            this.editarDatosToolStripMenuItem});
            this.sesiónToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sesiónToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Info;
            this.sesiónToolStripMenuItem.Name = "sesiónToolStripMenuItem";
            this.sesiónToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.sesiónToolStripMenuItem.Text = "Sesión";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.cerrarSesiónToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrarSesiónToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Info;
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // editarDatosToolStripMenuItem
            // 
            this.editarDatosToolStripMenuItem.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.editarDatosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarDatosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Info;
            this.editarDatosToolStripMenuItem.Name = "editarDatosToolStripMenuItem";
            this.editarDatosToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.editarDatosToolStripMenuItem.Text = "Editar datos";
            this.editarDatosToolStripMenuItem.Click += new System.EventHandler(this.editarDatosToolStripMenuItem_Click);
            // 
            // labelNomUser
            // 
            this.labelNomUser.AutoSize = true;
            this.labelNomUser.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomUser.Location = new System.Drawing.Point(37, 45);
            this.labelNomUser.Name = "labelNomUser";
            this.labelNomUser.Size = new System.Drawing.Size(62, 18);
            this.labelNomUser.TabIndex = 36;
            this.labelNomUser.Text = "Usuario";
            // 
            // textPaterno
            // 
            this.textPaterno.Location = new System.Drawing.Point(470, 214);
            this.textPaterno.Name = "textPaterno";
            this.textPaterno.ShortcutsEnabled = false;
            this.textPaterno.Size = new System.Drawing.Size(337, 30);
            this.textPaterno.TabIndex = 38;
            this.textPaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPaterno_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(466, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 21);
            this.label10.TabIndex = 37;
            this.label10.Text = "Apellido Paterno:";
            // 
            // textMaterno
            // 
            this.textMaterno.Location = new System.Drawing.Point(106, 284);
            this.textMaterno.Name = "textMaterno";
            this.textMaterno.ShortcutsEnabled = false;
            this.textMaterno.Size = new System.Drawing.Size(337, 30);
            this.textMaterno.TabIndex = 40;
            this.textMaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textMaterno_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(102, 261);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 21);
            this.label11.TabIndex = 39;
            this.label11.Text = "Apellido Materno:";
            // 
            // UsuarioRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(893, 670);
            this.Controls.Add(this.textMaterno);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textPaterno);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelNomUser);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.registrarButton);
            this.Controls.Add(this.recuperacionText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.preguntaText);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboGenero);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fechaNacimiento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nombreText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.contraseñaText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UsuarioRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de usuario - PalabraViva";
            this.Load += new System.EventHandler(this.UsuarioRegistro_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.TextBox contraseñaText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nombreText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker fechaNacimiento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboGenero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox recuperacionText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox preguntaText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button registrarButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favoritosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListaToolStripMenuItem;
        private System.Windows.Forms.Label labelNomUser;
        private System.Windows.Forms.ToolStripMenuItem sesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarDatosToolStripMenuItem;
        private System.Windows.Forms.TextBox textPaterno;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textMaterno;
        private System.Windows.Forms.Label label11;
    }
}