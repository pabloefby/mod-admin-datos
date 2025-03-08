namespace ProyectoMADFloresBlanco
{
    partial class Historial
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.dataGridHistorial = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboFiltro = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeFecha = new System.Windows.Forms.DateTimePicker();
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
            this.labelNomUser = new System.Windows.Forms.Label();
            this.buttonBorrarVersi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistorial)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBorrar.Location = new System.Drawing.Point(676, 585);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(182, 45);
            this.buttonBorrar.TabIndex = 19;
            this.buttonBorrar.Text = "Borrar historial";
            this.buttonBorrar.UseVisualStyleBackColor = true;
            this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
            // 
            // dataGridHistorial
            // 
            this.dataGridHistorial.AllowUserToAddRows = false;
            this.dataGridHistorial.AllowUserToDeleteRows = false;
            this.dataGridHistorial.AllowUserToResizeColumns = false;
            this.dataGridHistorial.AllowUserToResizeRows = false;
            this.dataGridHistorial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.dataGridHistorial.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridHistorial.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHistorial.Location = new System.Drawing.Point(105, 202);
            this.dataGridHistorial.MultiSelect = false;
            this.dataGridHistorial.Name = "dataGridHistorial";
            this.dataGridHistorial.ReadOnly = true;
            this.dataGridHistorial.RowHeadersVisible = false;
            this.dataGridHistorial.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridHistorial.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridHistorial.RowTemplate.Height = 24;
            this.dataGridHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridHistorial.ShowCellToolTips = false;
            this.dataGridHistorial.ShowEditingIcon = false;
            this.dataGridHistorial.Size = new System.Drawing.Size(753, 368);
            this.dataGridHistorial.TabIndex = 18;
            this.dataGridHistorial.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridHistorial_CellContentClick);
            this.dataGridHistorial.SelectionChanged += new System.EventHandler(this.dataGridHistorial_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Búsquedas que ha realizado";
            // 
            // comboFiltro
            // 
            this.comboFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFiltro.FormattingEnabled = true;
            this.comboFiltro.Items.AddRange(new object[] {
            "Toda la historia",
            "Mes / Año"});
            this.comboFiltro.Location = new System.Drawing.Point(105, 154);
            this.comboFiltro.Name = "comboFiltro";
            this.comboFiltro.Size = new System.Drawing.Size(221, 29);
            this.comboFiltro.TabIndex = 20;
            this.comboFiltro.SelectedIndexChanged += new System.EventHandler(this.comboFiltro_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Buscar por";
            // 
            // dateTimeFecha
            // 
            this.dateTimeFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeFecha.Location = new System.Drawing.Point(353, 154);
            this.dateTimeFecha.Name = "dateTimeFecha";
            this.dateTimeFecha.Size = new System.Drawing.Size(203, 30);
            this.dateTimeFecha.TabIndex = 22;
            this.dateTimeFecha.Visible = false;
            this.dateTimeFecha.ValueChanged += new System.EventHandler(this.dateTimeFecha_ValueChanged);
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(21, 5, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(951, 34);
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
            // labelNomUser
            // 
            this.labelNomUser.AutoSize = true;
            this.labelNomUser.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomUser.Location = new System.Drawing.Point(40, 47);
            this.labelNomUser.Name = "labelNomUser";
            this.labelNomUser.Size = new System.Drawing.Size(62, 18);
            this.labelNomUser.TabIndex = 36;
            this.labelNomUser.Text = "Usuario";
            // 
            // buttonBorrarVersi
            // 
            this.buttonBorrarVersi.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBorrarVersi.Location = new System.Drawing.Point(480, 585);
            this.buttonBorrarVersi.Name = "buttonBorrarVersi";
            this.buttonBorrarVersi.Size = new System.Drawing.Size(182, 45);
            this.buttonBorrarVersi.TabIndex = 37;
            this.buttonBorrarVersi.Text = "Borrar búsqueda";
            this.buttonBorrarVersi.UseVisualStyleBackColor = true;
            this.buttonBorrarVersi.Visible = false;
            this.buttonBorrarVersi.Click += new System.EventHandler(this.buttonBorrarVersi_Click);
            // 
            // Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(951, 673);
            this.Controls.Add(this.buttonBorrarVersi);
            this.Controls.Add(this.labelNomUser);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dateTimeFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboFiltro);
            this.Controls.Add(this.buttonBorrar);
            this.Controls.Add(this.dataGridHistorial);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Historial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial - PalabraViva";
            this.Load += new System.EventHandler(this.Historial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistorial)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBorrar;
        private System.Windows.Forms.DataGridView dataGridHistorial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboFiltro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeFecha;
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
        private System.Windows.Forms.Label labelNomUser;
        private System.Windows.Forms.Button buttonBorrarVersi;
    }
}