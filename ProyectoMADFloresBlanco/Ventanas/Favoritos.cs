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
    public partial class Favoritos : Form
    {
        private EnlaceDB enlace = new EnlaceDB();
        private UsuarioLogeado usuario;
        int idEliminar;
        DataTable favs = new DataTable();

        public Favoritos(UsuarioLogeado usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.Font = new Font("Century Gothic", usuario.fuente);
        }

        private void Favoritos_Load(object sender, EventArgs e)
        {
            labelNomUser.Text = usuario.NombreCompleto.ToString();
        }


        ////MENU////

        private void consultaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Consulta VenConsulta = new Consulta(usuario);
            VenConsulta.Show();
            this.Close();
        }

        private void busquedaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Busqueda VenBusqueda = new Busqueda(usuario);
            VenBusqueda.Show();
            this.Close();
        }

        private void favoritosToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        private void registrarToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        private void comboFavs_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if(comboFavs.Text == "Versículos")
            {
                favs = enlace.get_Favoritos("V", "", "", "", "", 0, 0, 0, "", usuario.emailUsuario, DateTime.Now);

            }
            else
            {
                favs = enlace.get_Favoritos("C", "", "", "", "", 0, 1, 0, "", usuario.emailUsuario, DateTime.Now);

            }

            dataGridFavs.DataSource = favs;
            button1.Enabled = false;
            
            
        }
        private void dataGridFavs_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridFavs.SelectedRows)
            {

                idEliminar = int.Parse(row.Cells[0].Value.ToString());

            }
            button1.Enabled = true;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("¿Desea eliminar el favorito seleccionado?", "Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(resultado == DialogResult.Yes)
            {
                enlace.Favoritos("E","","","","",0,idEliminar,0,"","",DateTime.Now);

                MessageBox.Show("Favorito eliminado correctamente", "Eliminado!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (comboFavs.Text == "Versículos")
                {
                    favs = enlace.get_Favoritos("V", "", "", "", "", 0, 0, 0, "", usuario.emailUsuario, DateTime.Now);

                }
                else
                {
                    favs = enlace.get_Favoritos("C", "", "", "", "", 0, 1, 0, "", usuario.emailUsuario, DateTime.Now);

                }
                dataGridFavs.DataSource = favs;

            }



        }

        private void dataGridFavs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            button1.Enabled = true;
        }
    }
}
