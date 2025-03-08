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
    public partial class ReactivarCuenta : Form
    {
        EnlaceDB enlace = new EnlaceDB();
        string email;
        DataTable metodo = new DataTable();
        DataTable Usuario = new DataTable();
        public ReactivarCuenta(string correo)
        {
            InitializeComponent();
            email = correo;
        }

        private void ReactivarCuenta_Load(object sender, EventArgs e)
        {
            metodo = enlace.get_MetodoRecuperacion("M", "", "", email);
            textPregunta.Text = metodo.Rows[0][0].ToString();

        }



        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            InicioSesion iniciosesion = new InicioSesion();
            iniciosesion.Show();
            this.Close();
        }

        private void buttonRecuperar_Click(object sender, EventArgs e)
        {
            if (textRespuesta.Text == metodo.Rows[0][1].ToString())
            {
                enlace.Funcionamientos("F", email, "", DateTime.Now, "");
                MessageBox.Show("Su cuenta ha sido reactivada, a continuación ingrese una contraseña temporal para continuar", "Reactivado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Usuario = enlace.get_Funcionamientos("I", email, "", DateTime.Now, "");

                UsuarioLogeado usuario = new UsuarioLogeado();
                usuario.emailUsuario = email;
                usuario.NombreCompleto = Usuario.Rows[0][1].ToString()+" "+ Usuario.Rows[0][2].ToString()+" "+ Usuario.Rows[0][3].ToString();
                usuario.fuente = int.Parse(Usuario.Rows[0][7].ToString());
              
                ContraseñaTemporal VenConTemporal = new ContraseñaTemporal(usuario);
                VenConTemporal.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("No ha respondido correctamente", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
