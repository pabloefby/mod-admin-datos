namespace ProyectoMADFloresBlanco.Ventanas
{
    partial class ContraseñaTemporal
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
            this.textContra = new System.Windows.Forms.TextBox();
            this.labelNomUser = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese una contraseña temporal para continuar:";
            // 
            // textContra
            // 
            this.textContra.Location = new System.Drawing.Point(170, 144);
            this.textContra.Name = "textContra";
            this.textContra.Size = new System.Drawing.Size(279, 30);
            this.textContra.TabIndex = 1;
            // 
            // labelNomUser
            // 
            this.labelNomUser.AutoSize = true;
            this.labelNomUser.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomUser.Location = new System.Drawing.Point(37, 43);
            this.labelNomUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNomUser.Name = "labelNomUser";
            this.labelNomUser.Size = new System.Drawing.Size(62, 18);
            this.labelNomUser.TabIndex = 49;
            this.labelNomUser.Text = "Usuario";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.Location = new System.Drawing.Point(254, 254);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(110, 43);
            this.buttonGuardar.TabIndex = 50;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // ContraseñaTemporal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(619, 371);
            this.ControlBox = false;
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.labelNomUser);
            this.Controls.Add(this.textContra);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ContraseñaTemporal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ContraseñaTemporal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textContra;
        private System.Windows.Forms.Label labelNomUser;
        private System.Windows.Forms.Button buttonGuardar;
    }
}