using ProyectoMADFloresBlanco.Ventanas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace ProyectoMADFloresBlanco
{
    public partial class Busqueda : Form
    {
        private UsuarioLogeado usuario;
        private EnlaceDB enlace=new EnlaceDB();
        private string textoVersiculo;
        private DataTable favoritos = new DataTable();
        private Favorito nuevoFav = new Favorito();
        private string verAudio;
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        public Busqueda(UsuarioLogeado usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.Font = new Font("Century Gothic", usuario.fuente);
            synthesizer.SetOutputToDefaultAudioDevice();
        }
 

        private void Busqueda_Load(object sender, EventArgs e)
        {
            labelNomUser.Text = usuario.NombreCompleto;
            DataTable filtros = new DataTable();
            filtros = enlace.get_Funcionamientos("G", "", "", DateTime.Now, "");

            comboFiltros.DataSource = filtros;
            comboFiltros.DisplayMember = "Nombre";
            comboFiltros.SelectedItem = null;

            comboIdioma.DataSource = enlace.ConsultasBiblia("I", "", "", "", "", 0, 0);
            comboIdioma.DisplayMember= "Nombre";
            comboIdioma.SelectedItem = null;

            comboVers.Enabled = false;
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
        private void comboFiltros_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboIdioma.Enabled = true;

            if(comboFiltros.Text=="Toda la biblia")
            {
                comboIdioma.SelectedItem = null;
                comboVers.SelectedItem = null;

                labeltesta.Visible = false;
                comboTesta.Visible = false;
                labellibro.Visible = false;
                comboLibro.Visible = false;
            }

            if (comboFiltros.Text == "Un solo testamento")
            {
                comboIdioma.SelectedItem = null;
                comboVers.SelectedItem = null;
                comboTesta.SelectedItem = null;


                labeltesta.Visible = true;
                comboTesta.Visible = true;
                labellibro.Visible = false;
                comboLibro.Visible = false;
            }

            if(comboFiltros.Text == "Un solo libro")
            {
                comboIdioma.SelectedItem = null;
                comboVers.SelectedItem = null;
                comboTesta.SelectedItem = null;
                comboLibro.SelectedItem = null;

                labeltesta.Visible = true;
                comboTesta.Visible = true;
                labellibro.Visible = true;
                comboLibro.Visible = true;
            }

            comboVers.Enabled = false;
            comboTesta.Enabled = false;
            comboLibro.Enabled = false;
            buttonBuscar.Enabled = true;

            buttonFav.Enabled = false;
            buttonAudio.Enabled = false;
            buttonCopiar.Enabled = false;
            buttonParar.Visible = false;
            buttonReaundar.Visible = false;
            buttonPausa.Visible = false;

        }

        private void comboIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboVers.Enabled = true;
            comboVers.DataSource= enlace.ConsultasBiblia("V", comboIdioma.Text, "", "", "", 0, 0);
            comboVers.DisplayMember = "NombreVersion";
            comboVers.SelectedItem = null;

            comboTesta.Enabled=false;
            comboLibro.Enabled=false;

            buttonFav.Enabled = false;
            buttonAudio.Enabled = false;
            buttonCopiar.Enabled = false;
            buttonParar.Visible = false;
            buttonReaundar.Visible = false;
            buttonPausa.Visible = false;

        }

        private void comboVers_SelectedIndexChanged(object sender, EventArgs e)
        {
                comboTesta.Enabled = true;
                comboTesta.DataSource= enlace.ConsultasBiblia("T", comboIdioma.Text, "", "", "", 0, 0);
                comboTesta.DisplayMember = "Nombre";
                comboTesta.SelectedItem = null;

                comboLibro.Enabled = false;

            buttonFav.Enabled = false;
            buttonAudio.Enabled = false;
            buttonCopiar.Enabled = false;
            buttonParar.Visible = false;
            buttonReaundar.Visible = false;
            buttonPausa.Visible = false;

        }

        private void comboTesta_SelectedIndexChanged(object sender, EventArgs e)
        {
          
                comboLibro.Enabled = true;
                comboLibro.DataSource = enlace.ConsultasBiblia("L", " ", "", comboTesta.Text, "", 0, 0);
                comboLibro.DisplayMember = "Nombre";
                comboLibro.SelectedItem = null;

            buttonFav.Enabled = false;
            buttonAudio.Enabled = false;
            buttonCopiar.Enabled = false;
            buttonParar.Visible = false;
            buttonReaundar.Visible = false;
            buttonPausa.Visible = false;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            int NumFiltro = comboFiltros.SelectedIndex+1;

            if (textPalabras.Text.Length == 0) {

                MessageBox.Show("Ingrese por favor palabras por favor.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                DataTable resultados = new DataTable();
                bool busquedaCorrecta = true;

                if (NumFiltro == 1)//TODA LA BIBLIA
                {
                    if(comboIdioma.Text.Length == 0 || comboVers.Text.Length==0) {

                        MessageBox.Show("Seleccione los filtros por favor. A", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        busquedaCorrecta = false;
                    }
                    else
                    {
                        resultados = enlace.get_Busqueda("B", textPalabras.Text, comboIdioma.Text, NumFiltro, comboVers.Text, "", "", usuario.emailUsuario);
                    }
               
                }

                if(NumFiltro == 2)//UN SOLO TESTAMENTO
                {
                    if (comboIdioma.Text.Length == 0 || comboVers.Text.Length == 0 || comboTesta.Text.Length==0)
                    {
                        MessageBox.Show("Seleccione los filtros por favor B", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        busquedaCorrecta = false;

                    }
                    else
                    {
                        resultados = enlace.get_Busqueda("C", textPalabras.Text, comboIdioma.Text, NumFiltro, comboVers.Text, comboTesta.Text, "", usuario.emailUsuario);
                    }
             
                }

                if(NumFiltro == 3) 
                {
                    if(comboIdioma.Text.Length == 0 || comboVers.Text.Length == 0 || comboTesta.Text.Length == 0 || comboLibro.Text.Length == 0)
                    {
                        MessageBox.Show("Seleccione los filtros por favor C", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        busquedaCorrecta = false;
                    }
                    else
                    {
                        resultados = enlace.get_Busqueda("D", textPalabras.Text, comboIdioma.Text, NumFiltro, comboVers.Text, comboTesta.Text, comboLibro.Text, usuario.emailUsuario);
                    }

                }

                if (busquedaCorrecta)
                {
                    dataGridResult.DataSource = resultados;
                    enlace.Busquedas("I", textPalabras.Text, comboIdioma.Text, NumFiltro, comboVers.Text, comboTesta.Text, comboLibro.Text, usuario.emailUsuario);

                }

            }

            buttonFav.Enabled = false;
            buttonAudio.Enabled = false;
            buttonCopiar.Enabled = false;
            buttonParar.Visible = false;
            buttonReaundar.Visible = false;
            buttonPausa.Visible = false;

        }

        private void dataGridResult_SelectionChanged(object sender, EventArgs e)
        {

            buttonFav.Enabled = true;
            buttonAudio.Enabled = true;
            buttonCopiar.Enabled = true;

            foreach (DataGridViewRow row in dataGridResult.SelectedRows)
            {
                textoVersiculo = row.Cells[1].Value.ToString();
                verAudio = row.Cells[0].Value.ToString() + "."+ row.Cells[1].Value.ToString(); ; 

            }



        }
        private void buttonFav_Click(object sender, EventArgs e)
        {

            favoritos = enlace.get_Funcionamientos("P","","",DateTime.Now,textoVersiculo);

            DataRow fav = favoritos.Rows[0];
            nuevoFav.Version = fav["VersionN"].ToString();
            nuevoFav.Testamento = fav["Testamento"].ToString();
            nuevoFav.Libro = fav["Libro"].ToString();
            nuevoFav.Capitulo = int.Parse(fav["Capitulo"].ToString());
            nuevoFav.Versiculo = int.Parse(fav["NumVer"].ToString());
            nuevoFav.Texto = textoVersiculo;

            AddFavorito agregarFavorito = new AddFavorito(usuario, nuevoFav);
            agregarFavorito.ShowDialog();

        }

        private void comboLibro_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonFav.Enabled = false;
            buttonAudio.Enabled = false;
            buttonCopiar.Enabled = false;
            buttonParar.Visible = false;
            buttonReaundar.Visible = false;
            buttonPausa.Visible = false;
        }

        private void buttonCopiar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridResult.SelectedRows)
            {
                Clipboard.SetDataObject(row.Cells[0].Value.ToString() + " " + row.Cells[1].Value.ToString());
                MessageBox.Show("Cita copiada al portapapeles", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonAudio_Click(object sender, EventArgs e)
        {
            buttonParar.Visible = true;
            buttonReaundar.Visible = true;
            buttonPausa.Visible = true;
            buttonAudio.Enabled = false;
            synthesizer.SpeakAsync(verAudio);
        }

        private void buttonParar_Click(object sender, EventArgs e)
        {
            synthesizer.SpeakAsyncCancelAll();
            buttonParar.Visible = false;
            buttonReaundar.Visible = false;
            buttonPausa.Visible = false;

            buttonAudio.Enabled = true;
        }

        private void buttonReaundar_Click(object sender, EventArgs e)
        {
            synthesizer.Resume();
        }

        private void buttonPausa_Click(object sender, EventArgs e)
        {
            synthesizer.Pause();
        }
    }
}
