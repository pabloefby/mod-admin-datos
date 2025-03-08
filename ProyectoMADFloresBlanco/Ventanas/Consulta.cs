using ProyectoMADFloresBlanco.Ventanas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoMADFloresBlanco
{
    public partial class Consulta : Form
    {

        EnlaceDB enlace = new EnlaceDB();
        DataTable versiculos = new DataTable();
        string versAudio;
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        int numVersiculo;
        string txtVersiculo;

        private UsuarioLogeado usuario;
        public Consulta(UsuarioLogeado usuarioE)
        {
            InitializeComponent();
            synthesizer.SetOutputToDefaultAudioDevice();
            this.usuario = usuarioE;
            this.Font = new Font("Century Gothic", usuario.fuente);

        }

        private void Consulta_Load(object sender, EventArgs e)
        {
            labelNomUser.Text = usuario.NombreCompleto;

            DataTable Idiomas = new DataTable();
            Idiomas = enlace.ConsultasBiblia("I", "", "", "", "", 0, 0);

            comboIdioma.DataSource = Idiomas;
            comboIdioma.DisplayMember = "Nombre";
            comboIdioma.SelectedItem = null;
            
            comboVersion.SelectedItem = null;
            comboVersion.Enabled = false;

            comboTestamento.SelectedItem = null;
            comboTestamento.Enabled = false;

            comboLibro.SelectedItem = null;
            comboLibro.Enabled = false;

            comboCapitulo.SelectedItem = null;
            comboCapitulo.Enabled = false;


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
        ////MENU////

        private void comboIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboVersion.Enabled = true;
           
            DataTable version = new DataTable();
       
            version = enlace.ConsultasBiblia("V", comboIdioma.Text, "", "", "", 0, 0);
           
            comboVersion.DataSource = version;
            comboVersion.DisplayMember = "NombreVersion";

            comboVersion.SelectedItem = null;

            comboTestamento.SelectedItem = null;
            comboTestamento.Enabled = false;

            comboLibro.SelectedItem = null;
            comboLibro.Enabled = false;

            comboCapitulo.SelectedItem = null;
            comboCapitulo.Enabled = false;

            buttonAudio.Enabled = false;
            buttonCapitulo.Enabled = false;

            buttonFav.Enabled = false;

            versiculos.Rows.Clear();


        }

        private void comboVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboTestamento.Enabled = true;

            DataTable testamento = new DataTable();

            testamento = enlace.ConsultasBiblia("T", comboIdioma.Text, "", "", "", 0, 0);

            comboTestamento.DataSource = testamento;
            comboTestamento.DisplayMember = "Nombre";

            comboTestamento.SelectedItem = null;

            comboLibro.SelectedItem = null;
            comboLibro.Enabled = false;

            comboCapitulo.SelectedItem = null;
            comboCapitulo.Enabled = false;

            buttonAudio.Enabled = false;
            buttonCapitulo.Enabled = false;

            buttonFav.Enabled = false;

            versiculos.Rows.Clear();

        }

        private void comboTestamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboLibro.Enabled = true;

            DataTable libros = new DataTable(); 

            libros = enlace.ConsultasBiblia("L"," ","", comboTestamento.Text, "", 0, 0);
            comboLibro.DataSource = libros;
            comboLibro.DisplayMember = "Nombre";


            comboLibro.SelectedItem = null;

            comboCapitulo.SelectedItem = null;
            comboCapitulo.Enabled = false;

            buttonAudio.Enabled = false;
            buttonCapitulo.Enabled = false;

            buttonFav.Enabled = false;

            versiculos.Rows.Clear();

        }

        private void comboLibro_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboCapitulo.Enabled = true;
            comboCapitulo.Items.Clear();
            DataTable Caps = new DataTable();
            Caps = enlace.ConsultasBiblia("N", " ", "", "", comboLibro.Text, 0, 0);

            if (Caps.Rows.Count > 0 && comboLibro.Text != "")
            {
                int numeroCaps = Convert.ToInt32(Caps.Rows[0][0]);

                for (int i = 1; i <= numeroCaps; i++)
                {
                    comboCapitulo.Items.Add(i);
                }
            }

            comboCapitulo.SelectedItem = null;

            buttonAudio.Enabled = false;
            buttonCapitulo.Enabled = false;

            buttonFav.Enabled = false;

            versiculos.Rows.Clear();
        }

        private void comboCapitulo_SelectedIndexChanged(object sender, EventArgs e)
        {

            int numcap = Convert.ToInt32(comboCapitulo.Text);

            versiculos = enlace.ConsultasBiblia("B", "", comboVersion.Text, "", comboLibro.Text, numcap, 0);

            dataGridVersiculos.DataSource = versiculos;

            buttonCapitulo.Enabled = false;
            buttonAudio.Enabled = false;
            buttonCapitulo.Enabled = true;
            buttonFav.Enabled = true;

            buttonFav.Enabled = false;
        }

  

        private void buttonAudio_Click(object sender, EventArgs e)
        {
            buttonParar.Visible = true;
            buttonReaundar.Visible = true;
            buttonPausa.Visible = true;
            buttonAudio.Enabled = false;
            buttonCapitulo.Enabled = false;
            synthesizer.SpeakAsync(versAudio);


        }

      
        private void dataGridVersiculos_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridVersiculos.SelectedRows)
            {
                versAudio = row.Cells[0].Value.ToString() +".."+ row.Cells[1].Value.ToString();
                numVersiculo = dataGridVersiculos.Rows.IndexOf(row)+1;
                txtVersiculo = row.Cells[1].Value.ToString();
            }

            buttonAudio.Enabled = true;
            buttonFav.Enabled = true;
            buttonCopiar.Visible= true;
        }

        private void buttonCapitulo_Click(object sender, EventArgs e)
        {
            buttonParar.Visible = true;
            buttonReaundar.Visible = true;
            buttonPausa.Visible= true;

            synthesizer.Speak(comboLibro.Text + comboCapitulo.Text);

            foreach (DataGridViewRow row in dataGridVersiculos.Rows)
            {
                synthesizer.SpeakAsync(row.Cells[1].Value.ToString());
                
            }

            buttonAudio.Enabled = false;
            buttonCapitulo.Enabled = false;
        }

        private void buttonParar_Click(object sender, EventArgs e)
        {
            synthesizer.SpeakAsyncCancelAll();
            buttonParar.Visible=false;
            buttonReaundar.Visible = false;
            buttonPausa.Visible = false;

            buttonAudio.Enabled = true;
            buttonCapitulo.Enabled = true;
        }

        private void buttonReaundar_Click(object sender, EventArgs e)
        {
            synthesizer.Resume();
        }

        private void buttonPausa_Click(object sender, EventArgs e)
        {
            synthesizer.Pause();
        }

        private void buttonFav_Click(object sender, EventArgs e)
        {

            synthesizer.SpeakAsyncCancelAll();

            Favorito favorito = new Favorito();

            favorito.Version=comboVersion.Text;
            favorito.Testamento=comboTestamento.Text;
            favorito.Libro=comboLibro.Text;
            favorito.Capitulo = int.Parse(comboCapitulo.Text);
            favorito.Versiculo = numVersiculo;
            favorito.Texto = txtVersiculo;

            AddFavorito agregarFavorito = new AddFavorito(usuario,favorito);
            agregarFavorito.ShowDialog();


        }

        private void buttonCopiar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridVersiculos.SelectedRows)
            {
                Clipboard.SetDataObject(row.Cells[0].Value.ToString()+ " "+ row.Cells[1].Value.ToString());
                MessageBox.Show("Cita copiada al portapapeles", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float tamaño = dataGridVersiculos.Font.Size;
            dataGridVersiculos.Font = new Font(dataGridVersiculos.Font.FontFamily, tamaño + 2);
        }
    }
}
