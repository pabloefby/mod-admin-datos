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
    public partial class AddFavorito : Form
    {
        private UsuarioLogeado usuario;
        private Favorito favorito;
        private EnlaceDB enlace =new EnlaceDB();

        public AddFavorito(UsuarioLogeado usuario, Favorito FavAgregado)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.favorito = FavAgregado;

        }

        private void AddFavorito_Load(object sender, EventArgs e)
        {

            labelVersion.Text = labelVersion.Text + " " + favorito.Version;
            labelTestamento.Text = labelTestamento.Text + " " + favorito.Testamento;
            labelLibro.Text = labelLibro.Text + " " + favorito.Libro;
            labelCapitulo.Text = labelCapitulo.Text + " " + favorito.Capitulo.ToString();
            labelVersiculo.Text = labelVersiculo.Text + " " + favorito.Versiculo.ToString();
            labelTexto.Text = labelTexto.Text +" "+ favorito.Texto.ToString();

            checkGuardaCap.Checked = false;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            if (textNombre.Text.Length == 0)
            {
                MessageBox.Show("Ingresa un nombre para tu favorito!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (checkGuardaCap.Checked == false)
                {
                    enlace.Favoritos("A", textNombre.Text, favorito.Version, favorito.Testamento, favorito.Libro, favorito.Capitulo, 0, favorito.Versiculo, favorito.Texto, usuario.emailUsuario, DateTime.Now);
                   
                }
                else
                {
                    enlace.Favoritos("A", textNombre.Text, favorito.Version, favorito.Testamento, favorito.Libro, favorito.Capitulo, 1, 0, "", usuario.emailUsuario, DateTime.Now);
                }

                MessageBox.Show("Favorito agregado exitosamente!", "Agregado!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }

            
        }

        private void checkGuardaCap_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkGuardaCap.Checked==false)
            {
                labelVersiculo.Visible = true;
                labelTexto.Visible = true;

            }
            else
            {
                labelVersiculo.Visible = false;
                labelTexto.Visible = false;
            }
        }
    }
}
