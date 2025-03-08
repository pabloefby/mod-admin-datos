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
    public partial class Historial : Form
    {
        EnlaceDB enlace = new EnlaceDB();
        UsuarioLogeado usuario;
        DataTable historial = new DataTable();
        int idEliminar;

        public Historial(UsuarioLogeado usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }
        private void Historial_Load(object sender, EventArgs e)
        {
            labelNomUser.Text = usuario.NombreCompleto;
            dateTimeFecha.Format = DateTimePickerFormat.Custom;
            dateTimeFecha.CustomFormat = "MMM/yyyy";

            comboFiltro.SelectedItem = null;
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
            UsuariosLista usuariosLista = new UsuariosLista(usuario);
            usuariosLista.Show();
            this.Close();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarDatosUsuario editarUsuario = new EditarDatosUsuario(usuario);
            editarUsuario.Show();
            this.Close();
        }

        private void editarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InicioSesion iniciosesion = new InicioSesion();
            iniciosesion.Show();
            this.Close();
        }
        ////MENU////

        private void comboFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {

            historial.Rows.Clear();
         
            if (comboFiltro.SelectedIndex == 1)
            {
                dateTimeFecha.Visible = true;
            }
            else
            {
                dateTimeFecha.Visible = false;
                historial = enlace.get_Funcionamientos("H", usuario.emailUsuario, "", DateTime.Now, "");
                dataGridHistorial.DataSource = historial;
            }

            buttonBorrarVersi.Visible = false;

        }

        private void dateTimeFecha_ValueChanged(object sender, EventArgs e)
        {
            historial = enlace.get_Funcionamientos("Z", usuario.emailUsuario, "", dateTimeFecha.Value.Date, "");
            dataGridHistorial.DataSource = historial;
        }



        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("¿Desea eliminar todo su historial?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                enlace.Busquedas("T", "", "", 0, "", "", "", usuario.emailUsuario);

                MessageBox.Show("Historial eliminado correctamente", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                historial.Rows.Clear();
                dateTimeFecha.Visible = false;
                comboFiltro.SelectedItem = null;
            }
        }

        private void dataGridHistorial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridHistorial_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridHistorial.SelectedRows)
            {
                idEliminar = int.Parse(row.Cells[0].Value.ToString());
            }

            buttonBorrarVersi.Visible = true;
        }

        private void buttonBorrarVersi_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("¿Desea eliminar la busqueda seleccionada?", "Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                enlace.Busquedas("S", "", "", idEliminar, "", "", "", usuario.emailUsuario);

                MessageBox.Show("Busqueda eliminada correctamente", "Eliminado!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dateTimeFecha.Visible = false;
                comboFiltro.SelectedItem = null;
                buttonBorrarVersi.Visible = false;
                historial.Rows.Clear();

            }

            buttonBorrarVersi.Visible = false;
        }
    }
}
