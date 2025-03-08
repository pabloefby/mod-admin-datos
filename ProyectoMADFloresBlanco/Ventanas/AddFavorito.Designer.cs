namespace ProyectoMADFloresBlanco.Ventanas
{
    partial class AddFavorito
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
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.checkGuardaCap = new System.Windows.Forms.CheckBox();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelLibro = new System.Windows.Forms.Label();
            this.labelCapitulo = new System.Windows.Forms.Label();
            this.labelVersiculo = new System.Windows.Forms.Label();
            this.labelTexto = new System.Windows.Forms.Label();
            this.labelTestamento = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el nombre con el cual desea guardar en favoritos:";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.SystemColors.Control;
            this.buttonGuardar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.Location = new System.Drawing.Point(172, 528);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(116, 41);
            this.buttonGuardar.TabIndex = 1;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCancelar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(487, 528);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(116, 41);
            this.buttonCancelar.TabIndex = 2;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(234, 93);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(329, 30);
            this.textNombre.TabIndex = 3;
            // 
            // checkGuardaCap
            // 
            this.checkGuardaCap.AutoSize = true;
            this.checkGuardaCap.Location = new System.Drawing.Point(261, 129);
            this.checkGuardaCap.Name = "checkGuardaCap";
            this.checkGuardaCap.Size = new System.Drawing.Size(274, 25);
            this.checkGuardaCap.TabIndex = 4;
            this.checkGuardaCap.Text = "Guardar capítulo completo";
            this.checkGuardaCap.UseVisualStyleBackColor = true;
            this.checkGuardaCap.CheckStateChanged += new System.EventHandler(this.checkGuardaCap_CheckStateChanged);
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(114, 178);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(85, 21);
            this.labelVersion.TabIndex = 5;
            this.labelVersion.Text = "Version: ";
            // 
            // labelLibro
            // 
            this.labelLibro.AutoSize = true;
            this.labelLibro.Location = new System.Drawing.Point(114, 276);
            this.labelLibro.Name = "labelLibro";
            this.labelLibro.Size = new System.Drawing.Size(60, 21);
            this.labelLibro.TabIndex = 6;
            this.labelLibro.Text = "Libro: ";
            // 
            // labelCapitulo
            // 
            this.labelCapitulo.AutoSize = true;
            this.labelCapitulo.Location = new System.Drawing.Point(114, 325);
            this.labelCapitulo.Name = "labelCapitulo";
            this.labelCapitulo.Size = new System.Drawing.Size(95, 21);
            this.labelCapitulo.TabIndex = 7;
            this.labelCapitulo.Text = "Capítulo: ";
            // 
            // labelVersiculo
            // 
            this.labelVersiculo.AutoSize = true;
            this.labelVersiculo.Location = new System.Drawing.Point(114, 374);
            this.labelVersiculo.Name = "labelVersiculo";
            this.labelVersiculo.Size = new System.Drawing.Size(95, 21);
            this.labelVersiculo.TabIndex = 9;
            this.labelVersiculo.Text = "Versiculo:";
            // 
            // labelTexto
            // 
            this.labelTexto.AutoSize = true;
            this.labelTexto.Location = new System.Drawing.Point(114, 423);
            this.labelTexto.MaximumSize = new System.Drawing.Size(600, 200);
            this.labelTexto.Name = "labelTexto";
            this.labelTexto.Size = new System.Drawing.Size(68, 21);
            this.labelTexto.TabIndex = 10;
            this.labelTexto.Text = "Texto: ";
            // 
            // labelTestamento
            // 
            this.labelTestamento.AutoSize = true;
            this.labelTestamento.Location = new System.Drawing.Point(114, 227);
            this.labelTestamento.Name = "labelTestamento";
            this.labelTestamento.Size = new System.Drawing.Size(120, 21);
            this.labelTestamento.TabIndex = 11;
            this.labelTestamento.Text = "Testamento:";
            // 
            // AddFavorito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(796, 610);
            this.ControlBox = false;
            this.Controls.Add(this.labelTestamento);
            this.Controls.Add(this.labelTexto);
            this.Controls.Add(this.labelVersiculo);
            this.Controls.Add(this.labelCapitulo);
            this.Controls.Add(this.labelLibro);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.checkGuardaCap);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddFavorito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AddFavorito_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.CheckBox checkGuardaCap;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelLibro;
        private System.Windows.Forms.Label labelCapitulo;
        private System.Windows.Forms.Label labelVersiculo;
        private System.Windows.Forms.Label labelTexto;
        private System.Windows.Forms.Label labelTestamento;
    }
}