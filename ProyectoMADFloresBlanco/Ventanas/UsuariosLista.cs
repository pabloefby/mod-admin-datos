using ProyectoMADFloresBlanco.Ventanas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMADFloresBlanco
{
    public partial class UsuariosLista : Form
    {
        EnlaceDB enlace = new EnlaceDB();
        UsuarioLogeado usuario;
        public UsuariosLista(UsuarioLogeado usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.Font = new Font("Century Gothic", usuario.fuente);
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

        private void UsuariosLista_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            labelNomUser.Text = usuario.NombreCompleto;

            comboTipoUsuario.SelectedItem = null;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (comboTipoUsuario.SelectedIndex == 0)
            {
                tablaUsuarios.DataSource = enlace.get_Usuarios("C", "", "", DateTime.Now, "", 0, "", "");
            }

            if (comboTipoUsuario.SelectedIndex == 1)
            {
                tablaUsuarios.DataSource = enlace.get_Usuarios("D", "", "", DateTime.Now, "", 0, "", "");
            }
           
        }
    }
}
