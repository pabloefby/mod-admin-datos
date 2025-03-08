namespace ProyectoMADFloresBlanco
{
    partial class Consulta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.comboIdioma = new System.Windows.Forms.ComboBox();
            this.comboVersion = new System.Windows.Forms.ComboBox();
            this.comboTestamento = new System.Windows.Forms.ComboBox();
            this.comboLibro = new System.Windows.Forms.ComboBox();
            this.comboCapitulo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridVersiculos = new System.Windows.Forms.DataGridView();
            this.buttonFav = new System.Windows.Forms.Button();
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
            this.buttonAudio = new System.Windows.Forms.Button();
            this.buttonCapitulo = new System.Windows.Forms.Button();
            this.labelNomUser = new System.Windows.Forms.Label();
            this.buttonParar = new System.Windows.Forms.Button();
            this.buttonReaundar = new System.Windows.Forms.Button();
            this.buttonPausa = new System.Windows.Forms.Button();
            this.buttonCopiar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVersiculos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elija las opciones del pasaje que desee consultar";
            // 
            // comboIdioma
            // 
            this.comboIdioma.BackColor = System.Drawing.SystemColors.Control;
            this.comboIdioma.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboIdioma.FormattingEnabled = true;
            this.comboIdioma.Location = new System.Drawing.Point(135, 129);
            this.comboIdioma.Name = "comboIdioma";
            this.comboIdioma.Size = new System.Drawing.Size(107, 29);
            this.comboIdioma.TabIndex = 1;
            this.comboIdioma.SelectedIndexChanged += new System.EventHandler(this.comboIdioma_SelectedIndexChanged);
            // 
            // comboVersion
            // 
            this.comboVersion.BackColor = System.Drawing.SystemColors.Control;
            this.comboVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboVersion.Enabled = false;
            this.comboVersion.FormattingEnabled = true;
            this.comboVersion.Location = new System.Drawing.Point(255, 129);
            this.comboVersion.Name = "comboVersion";
            this.comboVersion.Size = new System.Drawing.Size(144, 29);
            this.comboVersion.TabIndex = 2;
            this.comboVersion.SelectedIndexChanged += new System.EventHandler(this.comboVersion_SelectedIndexChanged);
            // 
            // comboTestamento
            // 
            this.comboTestamento.BackColor = System.Drawing.SystemColors.Control;
            this.comboTestamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTestamento.Enabled = false;
            this.comboTestamento.FormattingEnabled = true;
            this.comboTestamento.Location = new System.Drawing.Point(409, 129);
            this.comboTestamento.Name = "comboTestamento";
            this.comboTestamento.Size = new System.Drawing.Size(170, 29);
            this.comboTestamento.TabIndex = 3;
            this.comboTestamento.SelectedIndexChanged += new System.EventHandler(this.comboTestamento_SelectedIndexChanged);
            // 
            // comboLibro
            // 
            this.comboLibro.BackColor = System.Drawing.SystemColors.Control;
            this.comboLibro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLibro.Enabled = false;
            this.comboLibro.FormattingEnabled = true;
            this.comboLibro.Location = new System.Drawing.Point(585, 129);
            this.comboLibro.Name = "comboLibro";
            this.comboLibro.Size = new System.Drawing.Size(144, 29);
            this.comboLibro.TabIndex = 4;
            this.comboLibro.SelectedIndexChanged += new System.EventHandler(this.comboLibro_SelectedIndexChanged);
            // 
            // comboCapitulo
            // 
            this.comboCapitulo.BackColor = System.Drawing.SystemColors.Control;
            this.comboCapitulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCapitulo.Enabled = false;
            this.comboCapitulo.FormattingEnabled = true;
            this.comboCapitulo.Location = new System.Drawing.Point(735, 129);
            this.comboCapitulo.Name = "comboCapitulo";
            this.comboCapitulo.Size = new System.Drawing.Size(67, 29);
            this.comboCapitulo.TabIndex = 5;
            this.comboCapitulo.SelectedIndexChanged += new System.EventHandler(this.comboCapitulo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Idioma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(251, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Versión";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(405, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Testamento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(581, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Libro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(731, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Capítulo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Versículos del capítulo:";
            // 
            // dataGridVersiculos
            // 
            this.dataGridVersiculos.AllowUserToAddRows = false;
            this.dataGridVersiculos.AllowUserToDeleteRows = false;
            this.dataGridVersiculos.AllowUserToResizeColumns = false;
            this.dataGridVersiculos.AllowUserToResizeRows = false;
            this.dataGridVersiculos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridVersiculos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.dataGridVersiculos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridVersiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVersiculos.ColumnHeadersVisible = false;
            this.dataGridVersiculos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridVersiculos.Location = new System.Drawing.Point(36, 205);
            this.dataGridVersiculos.MultiSelect = false;
            this.dataGridVersiculos.Name = "dataGridVersiculos";
            this.dataGridVersiculos.ReadOnly = true;
            this.dataGridVersiculos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridVersiculos.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridVersiculos.RowHeadersVisible = false;
            this.dataGridVersiculos.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridVersiculos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridVersiculos.RowTemplate.Height = 24;
            this.dataGridVersiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridVersiculos.ShowRowErrors = false;
            this.dataGridVersiculos.Size = new System.Drawing.Size(838, 415);
            this.dataGridVersiculos.TabIndex = 13;
            this.dataGridVersiculos.SelectionChanged += new System.EventHandler(this.dataGridVersiculos_SelectionChanged);
            // 
            // buttonFav
            // 
            this.buttonFav.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonFav.BackColor = System.Drawing.SystemColors.Control;
            this.buttonFav.Enabled = false;
            this.buttonFav.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFav.Location = new System.Drawing.Point(772, 642);
            this.buttonFav.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFav.Name = "buttonFav";
            this.buttonFav.Size = new System.Drawing.Size(102, 42);
            this.buttonFav.TabIndex = 15;
            this.buttonFav.Text = "Favorito";
            this.buttonFav.UseVisualStyleBackColor = false;
            this.buttonFav.Click += new System.EventHandler(this.buttonFav_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(932, 34);
            this.menuStrip1.TabIndex = 32;
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
            // buttonAudio
            // 
            this.buttonAudio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAudio.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAudio.Enabled = false;
            this.buttonAudio.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAudio.Location = new System.Drawing.Point(574, 642);
            this.buttonAudio.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAudio.Name = "buttonAudio";
            this.buttonAudio.Size = new System.Drawing.Size(188, 42);
            this.buttonAudio.TabIndex = 33;
            this.buttonAudio.Text = "Escuchar Versiculo";
            this.buttonAudio.UseVisualStyleBackColor = false;
            this.buttonAudio.Click += new System.EventHandler(this.buttonAudio_Click);
            // 
            // buttonCapitulo
            // 
            this.buttonCapitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCapitulo.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCapitulo.Enabled = false;
            this.buttonCapitulo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCapitulo.Location = new System.Drawing.Point(387, 642);
            this.buttonCapitulo.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCapitulo.Name = "buttonCapitulo";
            this.buttonCapitulo.Size = new System.Drawing.Size(177, 42);
            this.buttonCapitulo.TabIndex = 34;
            this.buttonCapitulo.Text = "Escuchar Capitulo";
            this.buttonCapitulo.UseVisualStyleBackColor = false;
            this.buttonCapitulo.Click += new System.EventHandler(this.buttonCapitulo_Click);
            // 
            // labelNomUser
            // 
            this.labelNomUser.AutoSize = true;
            this.labelNomUser.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomUser.Location = new System.Drawing.Point(32, 40);
            this.labelNomUser.Name = "labelNomUser";
            this.labelNomUser.Size = new System.Drawing.Size(62, 18);
            this.labelNomUser.TabIndex = 35;
            this.labelNomUser.Text = "Usuario";
            // 
            // buttonParar
            // 
            this.buttonParar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonParar.BackColor = System.Drawing.SystemColors.Control;
            this.buttonParar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonParar.ForeColor = System.Drawing.Color.Red;
            this.buttonParar.Location = new System.Drawing.Point(34, 642);
            this.buttonParar.Margin = new System.Windows.Forms.Padding(0);
            this.buttonParar.Name = "buttonParar";
            this.buttonParar.Size = new System.Drawing.Size(47, 42);
            this.buttonParar.TabIndex = 36;
            this.buttonParar.Text = "⬛";
            this.buttonParar.UseVisualStyleBackColor = false;
            this.buttonParar.Visible = false;
            this.buttonParar.Click += new System.EventHandler(this.buttonParar_Click);
            // 
            // buttonReaundar
            // 
            this.buttonReaundar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonReaundar.BackColor = System.Drawing.SystemColors.Control;
            this.buttonReaundar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReaundar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.buttonReaundar.Location = new System.Drawing.Point(81, 642);
            this.buttonReaundar.Margin = new System.Windows.Forms.Padding(0);
            this.buttonReaundar.Name = "buttonReaundar";
            this.buttonReaundar.Size = new System.Drawing.Size(47, 42);
            this.buttonReaundar.TabIndex = 37;
            this.buttonReaundar.Text = "▶";
            this.buttonReaundar.UseVisualStyleBackColor = false;
            this.buttonReaundar.Visible = false;
            this.buttonReaundar.Click += new System.EventHandler(this.buttonReaundar_Click);
            // 
            // buttonPausa
            // 
            this.buttonPausa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPausa.BackColor = System.Drawing.SystemColors.Control;
            this.buttonPausa.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPausa.ForeColor = System.Drawing.Color.RoyalBlue;
            this.buttonPausa.Location = new System.Drawing.Point(128, 642);
            this.buttonPausa.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPausa.Name = "buttonPausa";
            this.buttonPausa.Size = new System.Drawing.Size(47, 42);
            this.buttonPausa.TabIndex = 38;
            this.buttonPausa.Text = "⏸";
            this.buttonPausa.UseVisualStyleBackColor = false;
            this.buttonPausa.Visible = false;
            this.buttonPausa.Click += new System.EventHandler(this.buttonPausa_Click);
            // 
            // buttonCopiar
            // 
            this.buttonCopiar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCopiar.Location = new System.Drawing.Point(271, 642);
            this.buttonCopiar.Name = "buttonCopiar";
            this.buttonCopiar.Size = new System.Drawing.Size(106, 42);
            this.buttonCopiar.TabIndex = 39;
            this.buttonCopiar.Text = "Copiar";
            this.buttonCopiar.UseVisualStyleBackColor = true;
            this.buttonCopiar.Visible = false;
            this.buttonCopiar.Click += new System.EventHandler(this.buttonCopiar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(881, 577);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 43);
            this.button1.TabIndex = 40;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(881, 528);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 43);
            this.button2.TabIndex = 41;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(932, 705);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonCopiar);
            this.Controls.Add(this.buttonPausa);
            this.Controls.Add(this.buttonReaundar);
            this.Controls.Add(this.buttonParar);
            this.Controls.Add(this.labelNomUser);
            this.Controls.Add(this.buttonCapitulo);
            this.Controls.Add(this.buttonAudio);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonFav);
            this.Controls.Add(this.dataGridVersiculos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboCapitulo);
            this.Controls.Add(this.comboLibro);
            this.Controls.Add(this.comboTestamento);
            this.Controls.Add(this.comboVersion);
            this.Controls.Add(this.comboIdioma);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Consulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta - PalabraViva";
            this.Load += new System.EventHandler(this.Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVersiculos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboIdioma;
        private System.Windows.Forms.ComboBox comboVersion;
        private System.Windows.Forms.ComboBox comboTestamento;
        private System.Windows.Forms.ComboBox comboLibro;
        private System.Windows.Forms.ComboBox comboCapitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridVersiculos;
        private System.Windows.Forms.Button buttonFav;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favoritosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListaToolStripMenuItem;
        private System.Windows.Forms.Button buttonAudio;
        private System.Windows.Forms.Button buttonCapitulo;
        private System.Windows.Forms.Label labelNomUser;
        private System.Windows.Forms.Button buttonParar;
        private System.Windows.Forms.Button buttonReaundar;
        private System.Windows.Forms.Button buttonPausa;
        private System.Windows.Forms.ToolStripMenuItem sesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarDatosToolStripMenuItem;
        private System.Windows.Forms.Button buttonCopiar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}