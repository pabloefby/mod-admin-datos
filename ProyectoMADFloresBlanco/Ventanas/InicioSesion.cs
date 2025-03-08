using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Speech.Synthesis;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoMADFloresBlanco.Ventanas;

namespace ProyectoMADFloresBlanco
{
    public partial class InicioSesion : Form
    {
        public EnlaceDB enlace = new EnlaceDB();
        public UsuarioLogeado usuario;
        int intentos=0;
        string correoAntBus;
        public InicioSesion()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable usuariosRecordados = new DataTable();
            usuariosRecordados = enlace.get_Usuarios("R", "", "", DateTime.Now, "",11,"","");

            comboEmail.DataSource = usuariosRecordados;
            comboEmail.DisplayMember = "Email";
            comboEmail.SelectedItem = null;

            checkRecordar.Checked = false;

            usuario = new UsuarioLogeado();
            intentos = 0;

        }

        private void BotonAcceder_Click(object sender, EventArgs e)
        {

            DataTable UsuarioInicio = new DataTable();
            UsuarioInicio = enlace.get_Funcionamientos("I", comboEmail.Text, "", DateTime.Now,"");

            if(UsuarioInicio.Rows.Count == 0)
            {
                MessageBox.Show("Usuario no encontrado, intentelo nuevamente", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
              
                DataRow fila = UsuarioInicio.Rows[0];

                if (fila["EstadoUser"].ToString() == "0")
                {

                    var resultado=MessageBox.Show("Usuario inactivo. ¿Desea reactivar su cuenta con su método de recuperacion?", "Error!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (resultado == DialogResult.Yes)
                    {
                        //MessageBox.Show("oki", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ReactivarCuenta reactivaCuenta = new ReactivarCuenta(comboEmail.Text);
                        reactivaCuenta.Show();
                        this.Close();
                    }

                }
                else
                {

                    if(fila["EstatusContra"].ToString() == "0" || fila["Contraseña"].ToString() != textContra.Text)
                    {
                        //if (intentos != 0)
                        //{
                        //    if (correoAntBus != textContra.Text)
                        //    {
                        //        intentos = 1;
                        //    }
                        //}
                        
                        intentos++;
                        MessageBox.Show("Contraseña incorrecta", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        correoAntBus = textContra.Text;

                        if (intentos == 3)
                        {
                            MessageBox.Show("Demasiados intentos. Su cuenta ha sido desactivada", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            intentos = 0;
                            enlace.Funcionamientos("D", comboEmail.Text, "", DateTime.Now, "");
                        }

                    }
                    else
                    {
                        usuario.emailUsuario = fila["Email"].ToString();
                        usuario.NombreCompleto = fila["NombreCompleto"].ToString()+" "+ fila["ApPaterno"].ToString()+" "+fila["ApMaterno"].ToString();
                        usuario.fuente = int.Parse(fila["Fuente"].ToString());  
                        usuario.contraseña = fila["Contraseña"].ToString();
                        usuario.tipoContraseña = int.Parse(fila["EstatusContra"].ToString());

                        if (checkRecordar.Checked == true)
                        {
                            enlace.Funcionamientos("R", comboEmail.Text, "", DateTime.Now,""); //que recuerde
                        }
                        else
                        {
                            enlace.Funcionamientos("O", comboEmail.Text, "", DateTime.Now,""); // que olvide
                        }
                        if(fila["EstatusContra"].ToString() == "1")
                        {
                            Consulta VenConsulta = new Consulta(usuario);
                            VenConsulta.Show();
                        }
                        if(fila["EstatusContra"].ToString() == "2")
                        {
                            MessageBox.Show("Su contraseña es temporal, a continuacion debe cambiarla", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CambioContraseña cambiocontra = new CambioContraseña(usuario);
                            cambiocontra.Show();
                        }

                        

                        this.Close();
                    }
                    



                }


            }

            

        }

        private void comboEmail_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkRecordar.Checked = true;
        }
    }
}
