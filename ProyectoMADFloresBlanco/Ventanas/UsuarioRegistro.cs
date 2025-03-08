using ProyectoMADFloresBlanco.Ventanas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMADFloresBlanco
{
    public partial class UsuarioRegistro : Form
    {

        EnlaceDB enlace = new EnlaceDB();
        UsuarioLogeado usuario;
        public UsuarioRegistro(UsuarioLogeado usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.Font = new Font("Century Gothic", usuario.fuente);
        }

        private void UsuarioRegistro_Load(object sender, EventArgs e)
        {
            labelNomUser.Text = usuario.NombreCompleto;
            fechaNacimiento.Format = DateTimePickerFormat.Custom;
            fechaNacimiento.CustomFormat = "dd/MMM/yyyy";
        }
        private bool ValidarContraseña(string contraseña){
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

        ////MENU////
        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta VenConsulta = new Consulta(usuario);
            VenConsulta.Show();
            this.Close();
        }

        private void busquedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Busqueda VenBusqueda = new Busqueda(usuario);
            VenBusqueda.Show();
            this.Close();
        }

        private void favoritosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Favoritos VenFavoritos = new Favoritos(usuario);
            VenFavoritos.Show();
            this.Close();
        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Historial VenHistorial = new Historial(usuario);
            VenHistorial.Show();
            this.Close();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuarioRegistro VenUsuRegistro = new UsuarioRegistro(usuario);
            VenUsuRegistro.Show();
            this.Close();
        }

        private void ListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuariosLista VenUsuLista = new UsuariosLista(usuario);
            VenUsuLista.Show();
            this.Close();
        }
        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InicioSesion iniciosesion = new InicioSesion();
            iniciosesion.Show();
            this.Close();
        }

        private void editarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarDatosUsuario editarUsuario = new EditarDatosUsuario(usuario);
            editarUsuario.Show();
            this.Close();
        }
        ////MENU////

        private void registrarButton_Click(object sender, EventArgs e)
        {
            bool ResgistroCorrecto = true;

            string email, nombre, contraseña,paterno,materno;
            string genero;
            DateTime fecha;
            string pregunta, respuesta;

            email = emailText.Text;
            nombre = nombreText.Text;
            contraseña = contraseñaText.Text;
            paterno = textPaterno.Text;
            materno = textMaterno.Text;

            if(comboGenero.Text == "Hombre")
            {
                genero = "H";
            }else
            {
                genero = "M";
            }

            fecha = fechaNacimiento.Value.Date; 

            pregunta = preguntaText.Text;
            respuesta = recuperacionText.Text;

            if (email.Length == 0 || nombre.Length == 0 || pregunta.Length==0 || respuesta.Length==0 || comboGenero.Text.Length==0)
            {
                ResgistroCorrecto = false;
                MessageBox.Show("Llene todos los espacios que se le piden.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            if (!ValidarContraseña(contraseña))
            {
                ResgistroCorrecto = false;
                MessageBox.Show("La contraseña debe contener al menos 8 caracteres, y contener al menos una mayúscula, una minúscula y un caracter especial.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (ResgistroCorrecto)
            {
                bool Ingresocorrecto;
                Ingresocorrecto = enlace.Usuarios("A", email, nombre, fecha, genero, 11, paterno, materno);

                if (Ingresocorrecto)
                {
                    MessageBox.Show("Usuario Registrado", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
                    enlace.Contraseñas("A", contraseña, email);
                    enlace.MetRecuperacion("A", pregunta, respuesta, email);

                    emailText.Text = "";
                    nombreText.Text = "";
                    textPaterno.Text = "";
                    textMaterno.Text = "";
                    contraseñaText.Text = "";
                    comboGenero.Text = "";
                    preguntaText.Text = "";
                    recuperacionText.Text = "";
                    fechaNacimiento.Text = "";
                }
                
               

            }

        }

        private void nombreText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Unicamente se permiten letras en este campo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void textPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Unicamente se permiten letras en este campo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void textMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Unicamente se permiten letras en este campo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }
    }
}
