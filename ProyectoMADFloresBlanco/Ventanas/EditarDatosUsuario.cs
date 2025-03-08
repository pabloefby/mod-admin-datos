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
    public partial class EditarDatosUsuario : Form
    {
        UsuarioLogeado usuario;
        EnlaceDB enlace = new EnlaceDB();
        DataTable tablaUsuario = new DataTable();
        public EditarDatosUsuario(UsuarioLogeado usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.Font = new Font("Century Gothic", usuario.fuente);

            dateFechaNac.Format = DateTimePickerFormat.Custom;
            dateFechaNac.CustomFormat = "dd/MMM/yyyy";
        }

        private void EditarDatosUsuario_Load(object sender, EventArgs e)
        {
            labelNomUser.Text = usuario.NombreCompleto;
            tablaUsuario = enlace.get_Usuarios("U", usuario.emailUsuario, "", DateTime.Now, "", 11, "", "");

            textNomComp.Text = tablaUsuario.Rows[0][0].ToString();
            textPaterno.Text = tablaUsuario.Rows[0][1].ToString();
            textMaterno.Text = tablaUsuario.Rows[0][2].ToString();
            dateFechaNac.Text = tablaUsuario.Rows[0][3].ToString();
            if (tablaUsuario.Rows[0][4].ToString() == "H")
            {
                comboGenero.Text = "Hombre";
            }
            if (tablaUsuario.Rows[0][4].ToString() == "M")
            {
                comboGenero.Text = "Mujer";
            }

            comboFuente.SelectedText = null;
            comboFuente.Text = tablaUsuario.Rows[0][5].ToString();



        }
        //MENU
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
            UsuariosLista usuariosLista = new UsuariosLista(usuario);
            usuariosLista.Show();
            this.Close();
        }

        private void editarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarDatosUsuario editarUsuario = new EditarDatosUsuario(usuario);
            editarUsuario.Show();
            this.Close();
        }
        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InicioSesion iniciosesion = new InicioSesion();
            iniciosesion.Show();
            this.Close();
        }

        //MENU

        private void comboFuente_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Font = new Font("Century Gothic", int.Parse(comboFuente.Text));

        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            DateTime fecha;
            string nombre, genero, paterno, materno;
            int fuente;

            nombre = textNomComp.Text;
            paterno = textPaterno.Text;
            materno = textMaterno.Text;
            fecha = dateFechaNac.Value.Date;
            genero = comboGenero.Text;
            fuente = int.Parse(comboFuente.Text);

            if(enlace.Usuarios("M", usuario.emailUsuario, nombre, fecha, genero, fuente, paterno, materno))
            {
                MessageBox.Show("Datos modificados correctamente", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                usuario.NombreCompleto = nombre + " " + paterno + " " + materno;
                usuario.fuente = fuente;

            }
            
        }

        private void buttonContraseña_Click(object sender, EventArgs e)
        {
            CambioContraseña cambiocontra = new CambioContraseña(usuario);
            cambiocontra.Show();
            this.Close();
        }

        private void buttonBaja_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Esta a punto de desactivar su cuenta, unicamente podra reactivarla con su método de recuperacion ¿Está seguro?", "Error!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                enlace.Funcionamientos("D", usuario.emailUsuario, "",DateTime.Now,"");

                MessageBox.Show("Cuenta desactivada exitosamente, se cerrará sesion", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InicioSesion iniciosesion = new InicioSesion();
                iniciosesion.Show();
                this.Close();

            }
        }

        private void textNomComp_KeyPress(object sender, KeyPressEventArgs e)
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
