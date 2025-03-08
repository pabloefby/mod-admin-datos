namespace ProyectoMADFloresBlanco
{
    partial class Busqueda
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboFiltros = new System.Windows.Forms.ComboBox();
            this.labellibro = new System.Windows.Forms.Label();
            this.labeltesta = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboLibro = new System.Windows.Forms.ComboBox();
            this.comboTesta = new System.Windows.Forms.ComboBox();
            this.comboVers = new System.Windows.Forms.ComboBox();
            this.comboIdioma = new System.Windows.Forms.ComboBox();
            this.textPalabras = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.dataGridResult = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
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
            this.buttonFav = new System.Windows.Forms.Button();
            this.buttonAudio = new System.Windows.Forms.Button();
            this.buttonCopiar = new System.Windows.Forms.Button();
            this.buttonPausa = new System.Windows.Forms.Button();
            this.buttonReaundar = new System.Windows.Forms.Button();
            this.buttonParar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResult)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Selecciona el filtro que desee usar para su búsqueda:";
            // 
            // comboFiltros
            // 
            this.comboFiltros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFiltros.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboFiltros.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboFiltros.FormattingEnabled = true;
            this.comboFiltros.Location = new System.Drawing.Point(76, 101);
            this.comboFiltros.Name = "comboFiltros";
            this.comboFiltros.Size = new System.Drawing.Size(320, 30);
            this.comboFiltros.TabIndex = 14;
            this.comboFiltros.SelectedIndexChanged += new System.EventHandler(this.comboFiltros_SelectedIndexChanged);
            // 
            // labellibro
            // 
            this.labellibro.AutoSize = true;
            this.labellibro.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellibro.Location = new System.Drawing.Point(703, 140);
            this.labellibro.Name = "labellibro";
            this.labellibro.Size = new System.Drawing.Size(49, 21);
            this.labellibro.TabIndex = 22;
            this.labellibro.Text = "Libro";
            this.labellibro.Visible = false;
            // 
            // labeltesta
            // 
            this.labeltesta.AutoSize = true;
            this.labeltesta.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltesta.Location = new System.Drawing.Point(494, 140);
            this.labeltesta.Name = "labeltesta";
            this.labeltesta.Size = new System.Drawing.Size(109, 21);
            this.labeltesta.TabIndex = 21;
            this.labeltesta.Text = "Testamento";
            this.labeltesta.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(285, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "Versión";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Idioma";
            // 
            // comboLibro
            // 
            this.comboLibro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLibro.Enabled = false;
            this.comboLibro.FormattingEnabled = true;
            this.comboLibro.Location = new System.Drawing.Point(703, 163);
            this.comboLibro.Name = "comboLibro";
            this.comboLibro.Size = new System.Drawing.Size(144, 29);
            this.comboLibro.TabIndex = 18;
            this.comboLibro.Visible = false;
            this.comboLibro.SelectedIndexChanged += new System.EventHandler(this.comboLibro_SelectedIndexChanged);
            // 
            // comboTesta
            // 
            this.comboTesta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTesta.Enabled = false;
            this.comboTesta.FormattingEnabled = true;
            this.comboTesta.Location = new System.Drawing.Point(494, 163);
            this.comboTesta.Name = "comboTesta";
            this.comboTesta.Size = new System.Drawing.Size(144, 29);
            this.comboTesta.TabIndex = 17;
            this.comboTesta.Visible = false;
            this.comboTesta.SelectedIndexChanged += new System.EventHandler(this.comboTesta_SelectedIndexChanged);
            // 
            // comboVers
            // 
            this.comboVers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboVers.Enabled = false;
            this.comboVers.FormattingEnabled = true;
            this.comboVers.Location = new System.Drawing.Point(285, 163);
            this.comboVers.Name = "comboVers";
            this.comboVers.Size = new System.Drawing.Size(144, 29);
            this.comboVers.TabIndex = 16;
            this.comboVers.SelectedIndexChanged += new System.EventHandler(this.comboVers_SelectedIndexChanged);
            // 
            // comboIdioma
            // 
            this.comboIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboIdioma.Enabled = false;
            this.comboIdioma.FormattingEnabled = true;
            this.comboIdioma.Location = new System.Drawing.Point(76, 163);
            this.comboIdioma.Name = "comboIdioma";
            this.comboIdioma.Size = new System.Drawing.Size(144, 29);
            this.comboIdioma.TabIndex = 15;
            this.comboIdioma.SelectedIndexChanged += new System.EventHandler(this.comboIdioma_SelectedIndexChanged);
            // 
            // textPalabras
            // 
            this.textPalabras.Location = new System.Drawing.Point(76, 235);
            this.textPalabras.Name = "textPalabras";
            this.textPalabras.Size = new System.Drawing.Size(620, 30);
            this.textPalabras.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(73, 211);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(339, 21);
            this.label6.TabIndex = 24;
            this.label6.Text = "Ingrese las palabras que desee buscar:";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Enabled = false;
            this.buttonBuscar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.Location = new System.Drawing.Point(717, 227);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(130, 42);
            this.buttonBuscar.TabIndex = 25;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // dataGridResult
            // 
            this.dataGridResult.AllowUserToAddRows = false;
            this.dataGridResult.AllowUserToDeleteRows = false;
            this.dataGridResult.AllowUserToResizeColumns = false;
            this.dataGridResult.AllowUserToResizeRows = false;
            this.dataGridResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.dataGridResult.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridResult.ColumnHeadersVisible = false;
            this.dataGridResult.Location = new System.Drawing.Point(76, 325);
            this.dataGridResult.MultiSelect = false;
            this.dataGridResult.Name = "dataGridResult";
            this.dataGridResult.ReadOnly = true;
            this.dataGridResult.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridResult.RowHeadersVisible = false;
            this.dataGridResult.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridResult.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridResult.RowTemplate.Height = 24;
            this.dataGridResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridResult.ShowRowErrors = false;
            this.dataGridResult.Size = new System.Drawing.Size(771, 231);
            this.dataGridResult.TabIndex = 27;
            this.dataGridResult.SelectionChanged += new System.EventHandler(this.dataGridResult_SelectionChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(72, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 21);
            this.label7.TabIndex = 26;
            this.label7.Text = "Resultados:";
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
            this.menuStrip1.Size = new System.Drawing.Size(919, 34);
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
            this.labelNomUser.Location = new System.Drawing.Point(37, 43);
            this.labelNomUser.Name = "labelNomUser";
            this.labelNomUser.Size = new System.Drawing.Size(62, 18);
            this.labelNomUser.TabIndex = 36;
            this.labelNomUser.Text = "Usuario";
            // 
            // buttonFav
            // 
            this.buttonFav.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonFav.BackColor = System.Drawing.SystemColors.Control;
            this.buttonFav.Enabled = false;
            this.buttonFav.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFav.Location = new System.Drawing.Point(745, 571);
            this.buttonFav.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFav.Name = "buttonFav";
            this.buttonFav.Size = new System.Drawing.Size(102, 42);
            this.buttonFav.TabIndex = 37;
            this.buttonFav.Text = "Favorito";
            this.buttonFav.UseVisualStyleBackColor = false;
            this.buttonFav.Click += new System.EventHandler(this.buttonFav_Click);
            // 
            // buttonAudio
            // 
            this.buttonAudio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAudio.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAudio.Enabled = false;
            this.buttonAudio.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAudio.Location = new System.Drawing.Point(545, 571);
            this.buttonAudio.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAudio.Name = "buttonAudio";
            this.buttonAudio.Size = new System.Drawing.Size(188, 42);
            this.buttonAudio.TabIndex = 38;
            this.buttonAudio.Text = "Escuchar Versiculo";
            this.buttonAudio.UseVisualStyleBackColor = false;
            this.buttonAudio.Click += new System.EventHandler(this.buttonAudio_Click);
            // 
            // buttonCopiar
            // 
            this.buttonCopiar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCopiar.Location = new System.Drawing.Point(427, 571);
            this.buttonCopiar.Name = "buttonCopiar";
            this.buttonCopiar.Size = new System.Drawing.Size(106, 42);
            this.buttonCopiar.TabIndex = 40;
            this.buttonCopiar.Text = "Copiar";
            this.buttonCopiar.UseVisualStyleBackColor = true;
            this.buttonCopiar.Click += new System.EventHandler(this.buttonCopiar_Click);
            // 
            // buttonPausa
            // 
            this.buttonPausa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPausa.BackColor = System.Drawing.SystemColors.Control;
            this.buttonPausa.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPausa.ForeColor = System.Drawing.Color.RoyalBlue;
            this.buttonPausa.Location = new System.Drawing.Point(170, 571);
            this.buttonPausa.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPausa.Name = "buttonPausa";
            this.buttonPausa.Size = new System.Drawing.Size(47, 42);
            this.buttonPausa.TabIndex = 43;
            this.buttonPausa.Text = "⏸";
            this.buttonPausa.UseVisualStyleBackColor = false;
            this.buttonPausa.Visible = false;
            this.buttonPausa.Click += new System.EventHandler(this.buttonPausa_Click);
            // 
            // buttonReaundar
            // 
            this.buttonReaundar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonReaundar.BackColor = System.Drawing.SystemColors.Control;
            this.buttonReaundar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReaundar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.buttonReaundar.Location = new System.Drawing.Point(123, 571);
            this.buttonReaundar.Margin = new System.Windows.Forms.Padding(0);
            this.buttonReaundar.Name = "buttonReaundar";
            this.buttonReaundar.Size = new System.Drawing.Size(47, 42);
            this.buttonReaundar.TabIndex = 42;
            this.buttonReaundar.Text = "▶";
            this.buttonReaundar.UseVisualStyleBackColor = false;
            this.buttonReaundar.Visible = false;
            this.buttonReaundar.Click += new System.EventHandler(this.buttonReaundar_Click);
            // 
            // buttonParar
            // 
            this.buttonParar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonParar.BackColor = System.Drawing.SystemColors.Control;
            this.buttonParar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonParar.ForeColor = System.Drawing.Color.Red;
            this.buttonParar.Location = new System.Drawing.Point(76, 571);
            this.buttonParar.Margin = new System.Windows.Forms.Padding(0);
            this.buttonParar.Name = "buttonParar";
            this.buttonParar.Size = new System.Drawing.Size(47, 42);
            this.buttonParar.TabIndex = 41;
            this.buttonParar.Text = "⬛";
            this.buttonParar.UseVisualStyleBackColor = false;
            this.buttonParar.Visible = false;
            this.buttonParar.Click += new System.EventHandler(this.buttonParar_Click);
            // 
            // Busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(919, 647);
            this.Controls.Add(this.buttonPausa);
            this.Controls.Add(this.buttonReaundar);
            this.Controls.Add(this.buttonParar);
            this.Controls.Add(this.buttonCopiar);
            this.Controls.Add(this.buttonAudio);
            this.Controls.Add(this.buttonFav);
            this.Controls.Add(this.labelNomUser);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridResult);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textPalabras);
            this.Controls.Add(this.labellibro);
            this.Controls.Add(this.labeltesta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboLibro);
            this.Controls.Add(this.comboTesta);
            this.Controls.Add(this.comboVers);
            this.Controls.Add(this.comboIdioma);
            this.Controls.Add(this.comboFiltros);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Busqueda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda - PalabraViva";
            this.Load += new System.EventHandler(this.Busqueda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResult)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboFiltros;
        private System.Windows.Forms.Label labellibro;
        private System.Windows.Forms.Label labeltesta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboLibro;
        private System.Windows.Forms.ComboBox comboTesta;
        private System.Windows.Forms.ComboBox comboVers;
        private System.Windows.Forms.ComboBox comboIdioma;
        private System.Windows.Forms.TextBox textPalabras;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.DataGridView dataGridResult;
        private System.Windows.Forms.Label label7;
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
        private System.Windows.Forms.Button buttonFav;
        private System.Windows.Forms.Button buttonAudio;
        private System.Windows.Forms.Button buttonCopiar;
        private System.Windows.Forms.Button buttonPausa;
        private System.Windows.Forms.Button buttonReaundar;
        private System.Windows.Forms.Button buttonParar;
    }
}