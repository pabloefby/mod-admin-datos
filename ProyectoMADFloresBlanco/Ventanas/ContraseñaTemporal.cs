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
    public partial class ContraseñaTemporal : Form
    {
        EnlaceDB enlace = new EnlaceDB();
        UsuarioLogeado usuarioE;
        DataTable ultimos3 = new DataTable();

        public ContraseñaTemporal(UsuarioLogeado usuario)
        {
            InitializeComponent();
            this.usuarioE = usuario;

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

        private void ContraseñaTemporal_Load(object sender, EventArgs e)
        {
            labelNomUser.Text = usuarioE.NombreCompleto;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            ultimos3 = enlace.get_Contraseñas("3", "", usuarioE.emailUsuario);

            bool noExisteContraseña = true;

            foreach (DataRow row in ultimos3.Rows)
            {

                if (row[0].ToString() == textContra.Text)
                {
                    row[0].ToString();
                    noExisteContraseña = false;
                }

            }

            if (noExisteContraseña == false)
            {
                MessageBox.Show("Su contraseña no puede ser igual a sus ultimas 3 contraseñas, intente nuevamente", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!ValidarContraseña(textContra.Text))
                {
                    MessageBox.Show("La contraseña debe contener al menos 8 caracteres, y contener al menos una mayúscula, una minúscula y un caracter especial.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    enlace.Contraseñas("E", "", usuarioE.emailUsuario);
                    enlace.Contraseñas("A", textContra.Text, usuarioE.emailUsuario);
                    enlace.Contraseñas("T", "", usuarioE.emailUsuario);

                    usuarioE.contraseña = textContra.Text;
                    usuarioE.tipoContraseña = 2;

                    MessageBox.Show("Contraseña temporal creada correctamente, debera cambiarla ahora o la siguiente vez que inicie sesion.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Consulta VenConsulta = new Consulta(usuarioE);
                    VenConsulta.Show();
                    this.Close();

                }
            }
        }
    }
}