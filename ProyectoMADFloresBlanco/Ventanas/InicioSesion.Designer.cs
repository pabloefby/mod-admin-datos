namespace ProyectoMADFloresBlanco
{
    partial class InicioSesion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textContra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkRecordar = new System.Windows.Forms.CheckBox();
            this.comboEmail = new System.Windows.Forms.ComboBox();
            this.BotonAcceder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "INICIAR SESION";
            // 
            // textContra
            // 
            this.textContra.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.textContra.Location = new System.Drawing.Point(143, 206);
            this.textContra.Name = "textContra";
            this.textContra.PasswordChar = '*';
            this.textContra.Size = new System.Drawing.Size(301, 30);
            this.textContra.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(143, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contraseña:";
            // 
            // checkRecordar
            // 
            this.checkRecordar.AutoSize = true;
            this.checkRecordar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkRecordar.Location = new System.Drawing.Point(143, 259);
            this.checkRecordar.Name = "checkRecordar";
            this.checkRecordar.Size = new System.Drawing.Size(127, 24);
            this.checkRecordar.TabIndex = 5;
            this.checkRecordar.Text = "Recuerdame";
            this.checkRecordar.UseVisualStyleBackColor = true;
            // 
            // comboEmail
            // 
            this.comboEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboEmail.FormattingEnabled = true;
            this.comboEmail.Location = new System.Drawing.Point(143, 131);
            this.comboEmail.Name = "comboEmail";
            this.comboEmail.Size = new System.Drawing.Size(301, 30);
            this.comboEmail.TabIndex = 6;
            this.comboEmail.SelectedIndexChanged += new System.EventHandler(this.comboEmail_SelectedIndexChanged);
            // 
            // BotonAcceder
            // 
            this.BotonAcceder.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonAcceder.Location = new System.Drawing.Point(230, 330);
            this.BotonAcceder.Name = "BotonAcceder";
            this.BotonAcceder.Size = new System.Drawing.Size(122, 45);
            this.BotonAcceder.TabIndex = 7;
            this.BotonAcceder.Text = "Acceder";
            this.BotonAcceder.UseVisualStyleBackColor = true;
            this.BotonAcceder.Click += new System.EventHandler(this.BotonAcceder_Click);
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(582, 432);
            this.Controls.Add(this.BotonAcceder);
            this.Controls.Add(this.comboEmail);
            this.Controls.Add(this.checkRecordar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textContra);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido a PalabraViva";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textContra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkRecordar;
        private System.Windows.Forms.ComboBox comboEmail;
        private System.Windows.Forms.Button BotonAcceder;
    }
}

