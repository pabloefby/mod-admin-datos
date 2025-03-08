namespace ProyectoMADFloresBlanco
{
    partial class Favoritos
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
            this.dataGridFavs = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
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
            this.comboFavs = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNomUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFavs)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Favoritos guardados";
            // 
            // dataGridFavs
            // 
            this.dataGridFavs.AllowUserToAddRows = false;
            this.dataGridFavs.AllowUserToDeleteRows = false;
            this.dataGridFavs.AllowUserToResizeColumns = false;
            this.dataGridFavs.AllowUserToResizeRows = false;
            this.dataGridFavs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.dataGridFavs.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridFavs.ColumnHeadersHeight = 29;
            this.dataGridFavs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridFavs.Location = new System.Drawing.Point(62, 174);
            this.dataGridFavs.MultiSelect = false;
            this.dataGridFavs.Name = "dataGridFavs";
            this.dataGridFavs.ReadOnly = true;
            this.dataGridFavs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridFavs.RowHeadersVisible = false;
            this.dataGridFavs.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridFavs.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridFavs.RowTemplate.Height = 24;
            this.dataGridFavs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridFavs.Size = new System.Drawing.Size(753, 366);
            this.dataGridFavs.TabIndex = 15;
            this.dataGridFavs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridFavs_CellContentClick);
            this.dataGridFavs.SelectionChanged += new System.EventHandler(this.dataGridFavs_SelectionChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(699, 546);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 45);
            this.button1.TabIndex = 16;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(872, 34);
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
            this.consultaToolStripMenuItem.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click_1);
            // 
            // busquedaToolStripMenuItem
            // 
            this.busquedaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busquedaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Info;
            this.busquedaToolStripMenuItem.Name = "busquedaToolStripMenuItem";
            this.busquedaToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.busquedaToolStripMenuItem.Text = "Busqueda";
            this.busquedaToolStripMenuItem.Click += new System.EventHandler(this.busquedaToolStripMenuItem_Click_1);
            // 
            // favoritosToolStripMenuItem
            // 
            this.favoritosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.favoritosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Info;
            this.favoritosToolStripMenuItem.Name = "favoritosToolStripMenuItem";
            this.favoritosToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.favoritosToolStripMenuItem.Text = "Favoritos";
            this.favoritosToolStripMenuItem.Click += new System.EventHandler(this.favoritosToolStripMenuItem_Click_1);
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
            this.registrarToolStripMenuItem.Click += new System.EventHandler(this.registrarToolStripMenuItem_Click_1);
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
            // comboFavs
            // 
            this.comboFavs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFavs.FormattingEnabled = true;
            this.comboFavs.Items.AddRange(new object[] {
            "Versículos",
            "Capitulos"});
            this.comboFavs.Location = new System.Drawing.Point(62, 135);
            this.comboFavs.Name = "comboFavs";
            this.comboFavs.Size = new System.Drawing.Size(142, 29);
            this.comboFavs.TabIndex = 34;
            this.comboFavs.SelectedIndexChanged += new System.EventHandler(this.comboFavs_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(486, 21);
            this.label2.TabIndex = 35;
            this.label2.Text = "Seleccione que tipo de favoritos que desee consultar:";
            // 
            // labelNomUser
            // 
            this.labelNomUser.AutoSize = true;
            this.labelNomUser.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomUser.Location = new System.Drawing.Point(58, 43);
            this.labelNomUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNomUser.Name = "labelNomUser";
            this.labelNomUser.Size = new System.Drawing.Size(62, 18);
            this.labelNomUser.TabIndex = 36;
            this.labelNomUser.Text = "Usuario";
            // 
            // Favoritos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(872, 624);
            this.Controls.Add(this.labelNomUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboFavs);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridFavs);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Favoritos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Favoritos - PalabraViva";
            this.Load += new System.EventHandler(this.Favoritos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFavs)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridFavs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favoritosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListaToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboFavs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelNomUser;
        private System.Windows.Forms.ToolStripMenuItem sesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarDatosToolStripMenuItem;
    }
}