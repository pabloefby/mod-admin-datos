using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMADFloresBlanco.Ventanas
{
    public partial class CambioContraseña : Form
    {
        EnlaceDB enlace = new EnlaceDB();
        UsuarioLogeado Usuario;
        DataTable ultimos3 = new DataTable();
        public CambioContraseña(UsuarioLogeado usuario)
        {
            InitializeComponent();
            this.Usuario = usuario;
            this.Font = new Font("Century Gothic", usuario.fuente);
        }
        private bool ValidarContraseña(string contraseña)
        {
            // Verificar la longitud de la contraseña
            if (contraseña.Length < 8)
            {
                return false;
            }

            // Verificar si contiene al menos una mayúscula, una minúscula y un carácter especial
            bool tieneMayuscula = false;
            bool tieneMinuscula = false;
            bool tieneCaracterEspecial = false;

            foreach (char caracter in contraseña)
            {
                if (char.IsUpper(caracter))
                {
                    tieneMayuscula = true;
                }
                else if (char.IsLower(caracter))
                {
                    tieneMinuscula = true;
                }
                else if (!char.IsLetterOrDigit(caracter)) // Verifica si es un carácter especial
                {
                    tieneCaracterEspecial = true;
                }
            }

            return tieneMayuscula && tieneMinuscula && tieneCaracterEspecial;
        }

        private void CambioContraseña_Load(object sender, EventArgs e)
        {
            labelNomUser.Text = Usuario.NombreCompleto;

            if (Usuario.tipoContraseña == 2)
            {
                button2.Visible = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditarDatosUsuario editarUsuario = new EditarDatosUsuario(Usuario);
            editarUsuario.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textAntContra.Text != Usuario.contraseña)
            {
                MessageBox.Show("La contraseña actual no es correcta", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ultimos3 = enlace.get_Contraseñas("3", "", Usuario.emailUsuario);

                bool noExisteContraseña = true;

                foreach(DataRow row in ultimos3.Rows) {

                    if (row[0].ToString() == textNuevaCont.Text)
                    {
                        row[0].ToString();
                        noExisteContraseña = false;
                    }
                
                }

                if (noExisteContraseña==false)
                {
                    MessageBox.Show("Su contraseña no puede ser igual a sus ultimas 3 contraseñas, intente nuevamente", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (!ValidarContraseña(textNuevaCont.Text))
                    {
                        MessageBox.Show("La contraseña debe contener al menos 8 caracteres, y contener al menos una mayúscula, una minúscula y un caracter especial.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        enlace.Contraseñas("E","",Usuario.emailUsuario);
                        enlace.Contraseñas("A", textNuevaCont.Text, Usuario.emailUsuario);

                        Usuario.contraseña = textNuevaCont.Text;

                        MessageBox.Show("Contraseña cambiada correctamente.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (Usuario.tipoContraseña == 1)
                        {
                            EditarDatosUsuario editarUsuario = new EditarDatosUsuario(Usuario);
                            editarUsuario.Show();
                        }
                        if(Usuario.tipoContraseña == 2)
                        {
                            Usuario.tipoContraseña = 1;
                            Consulta VenConsulta = new Consulta(Usuario);
                            VenConsulta.Show();
                        }
                       
                        this.Close();
                    }
                }

                
            }
        }
    }
}
