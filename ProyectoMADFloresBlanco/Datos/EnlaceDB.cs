/*
Autor: Alejandro Villarreal

LMAD

PARA EL PROYECTO ES OBLIGATORIO EL USO DE ESTA CLASE, 
EN EL SENTIDO DE QUE LOS DATOS DE CONEXION AL SERVIDOR ESTAN DEFINIDOS EN EL App.Config
Y NO TENER ESOS DATOS EN CODIGO DURO DEL PROYECTO.

NO SE PERMITE HARDCODE.

LOS MÉTODOS QUE SE DEFINEN EN ESTA CLASE SON EJEMPLOS, PARA QUE SE BASEN Y USTEDES HAGAN LOS SUYOS PROPIOS
Y DEFINAN Y PROGRAMEN TODOS LOS MÉTODOS QUE SEAN NECESARIOS PARA SU PROYECTO.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


/*
Se tiene que cambiar el namespace para el que usen en su proyecto
*/
namespace ProyectoMADFloresBlanco
{
    public class EnlaceDB
    {
        static private string _aux { set; get; }
        static private SqlConnection _conexion;
        static private SqlDataAdapter _adaptador = new SqlDataAdapter();
        static private SqlCommand _comandosql = new SqlCommand();
        static private DataTable _tabla = new DataTable();
        static private DataSet _DS = new DataSet();

        public DataTable obtenertabla
        {
            get
            {
                return _tabla;
            }
        }

        private static void conectar()
        {
          
            string cnn = ConfigurationManager.ConnectionStrings["BaseDeProyecto"].ToString(); 
            _conexion = new SqlConnection(cnn);
            _conexion.Open();
        }

             private static void desconectar()
        {
            _conexion.Close();
        }


        //PROYECTO

        //FUNCIONAMIENTO
        public DataTable get_Funcionamientos(string op, string email,string contra, DateTime fecha,string texto)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "sp_Funcionamiento";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Op", SqlDbType.Char, 1);
                parametro1.Value = op;
                var parametro2 = _comandosql.Parameters.Add("@Email", SqlDbType.VarChar, 100);
                parametro2.Value = email;
                var parametro3 = _comandosql.Parameters.Add("@Fecha", SqlDbType.DateTime, 1);
                parametro3.Value = fecha;
                var parametro4 = _comandosql.Parameters.Add("@Texto", SqlDbType.VarChar, 1000);
                parametro4.Value = texto;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);
                // la ejecución del SP espera que regrese datos en formato tabla

            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }

        public bool Funcionamientos(string op, string email, string contra,DateTime fecha, string texto)
        {
            bool isValid = false;
            try
            {
                conectar();
                string qry = "sp_Funcionamiento";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 9000;

                var parametro1 = _comandosql.Parameters.Add("@Op", SqlDbType.Char, 1);
                parametro1.Value = op;
                var parametro2 = _comandosql.Parameters.Add("@Email", SqlDbType.VarChar, 100);
                parametro2.Value = email;
                var parametro3 = _comandosql.Parameters.Add("@Fecha", SqlDbType.DateTime,1);
                parametro3.Value = fecha;
                var parametro4 = _comandosql.Parameters.Add("@Texto", SqlDbType.VarChar, 1000);
                parametro4.Value = texto;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(_tabla);

                if (_tabla.Rows.Count > 0)
                {
                    isValid = true;
                }

            }
            catch (SqlException e)
            {
                isValid = false;
            }
            finally
            {
                desconectar();
            }
            return isValid;
        }

        //USUARIOS
        public bool Usuarios(string op, string email, string nom, DateTime fecnac, string gen,int fuente, string apPaterno, string apMaterno)
        {
            bool isValid = true;
            try
            {
                conectar();
                string qry = "sp_Usuarios";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 9000;

                var parametro1 = _comandosql.Parameters.Add("@Op", SqlDbType.Char, 1);
                parametro1.Value = op;
                var parametro2 = _comandosql.Parameters.Add("@Email", SqlDbType.VarChar, 100);
                parametro2.Value = email;
                var parametro3 = _comandosql.Parameters.Add("@NomCompleto", SqlDbType.VarChar, 100);
                parametro3.Value = nom;
                var parametro4 = _comandosql.Parameters.Add("@FechaNacimiento", SqlDbType.Date,1);
                parametro4.Value = fecnac;
                var parametro5 = _comandosql.Parameters.Add("@Genero", SqlDbType.Char, 1);
                parametro5.Value = gen;
                var parametro6 = _comandosql.Parameters.Add("@Fuente", SqlDbType.Int, 1);
                parametro6.Value = fuente;
                var parametro7 = _comandosql.Parameters.Add("@ApPaterno", SqlDbType.VarChar, 50);
                parametro7.Value = apPaterno;
                var parametro8 = _comandosql.Parameters.Add("@ApMaterno", SqlDbType.VarChar, 50);
                parametro8.Value = apMaterno;


                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(_tabla);

                if (_tabla.Rows.Count > 0)
                {
                    isValid = true;
                }

            }
            catch (SqlException e)
            {
                isValid = false;
                MessageBox.Show(e.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
    
            }
            finally
            {
                desconectar();
            }
            return isValid;
        }

        public DataTable get_Usuarios(string op, string email, string nom, DateTime fecnac, string gen,int fuente, string apPaterno, string apMaterno)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "sp_Usuarios";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Op", SqlDbType.Char, 1);
                parametro1.Value = op;
                var parametro2 = _comandosql.Parameters.Add("@Email", SqlDbType.VarChar, 100);
                parametro2.Value = email;
                var parametro3 = _comandosql.Parameters.Add("@NomCompleto", SqlDbType.VarChar, 100);
                parametro3.Value = nom;
                var parametro4 = _comandosql.Parameters.Add("@FechaNacimiento", SqlDbType.Date, 1);
                parametro4.Value = fecnac;
                var parametro5 = _comandosql.Parameters.Add("@Genero", SqlDbType.Char, 1);
                parametro5.Value = gen;
                var parametro6 = _comandosql.Parameters.Add("@Fuente", SqlDbType.Int, 1);
                parametro6.Value = fuente;
                var parametro7 = _comandosql.Parameters.Add("@ApPaterno", SqlDbType.VarChar, 50);
                parametro7.Value = apPaterno;
                var parametro8 = _comandosql.Parameters.Add("@ApMaterno", SqlDbType.VarChar, 50);
                parametro8.Value = apMaterno;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);
                // la ejecución del SP espera que regrese datos en formato tabla

            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }

        //CONTRASEÑAS
        public bool Contraseñas(string op, string contraseña, string emailuser)
        {
            bool isValid = false;
            try
            {
                conectar();
                string qry = "sp_Contraseñas";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 9000;

                var parametro1 = _comandosql.Parameters.Add("@Op", SqlDbType.Char, 1);
                parametro1.Value = op;
                var parametro2 = _comandosql.Parameters.Add("@Contra", SqlDbType.VarChar, 25);
                parametro2.Value = contraseña;
                var parametro3 = _comandosql.Parameters.Add("@Usuario", SqlDbType.VarChar, 100);
                parametro3.Value = emailuser;
 

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(_tabla);

                if (_tabla.Rows.Count > 0)
                {
                    isValid = true;
                }

            }
            catch (SqlException e)
            {
                isValid = false;
            }
            finally
            {
                desconectar();
            }
            return isValid;
        }

        public DataTable get_Contraseñas(string op, string contraseña, string emailuser)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "sp_Contraseñas";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Op", SqlDbType.Char, 1);
                parametro1.Value = op;
                var parametro2 = _comandosql.Parameters.Add("@Contra", SqlDbType.VarChar, 25);
                parametro2.Value = contraseña;
                var parametro3 = _comandosql.Parameters.Add("@Usuario", SqlDbType.VarChar, 100);
                parametro3.Value = emailuser;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);
                // la ejecución del SP espera que regrese datos en formato tabla

            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }

        //METODO RECUPERACION
        public bool MetRecuperacion(string op, string pregunta, string respuesta ,string emailuser)
        {
            bool isValid = false;
            try
            {
                conectar();
                string qry = "sp_MetodoRecuperacion";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 9000;

                var parametro1 = _comandosql.Parameters.Add("@Op", SqlDbType.Char, 1);
                parametro1.Value = op;
                var parametro2 = _comandosql.Parameters.Add("@Preg", SqlDbType.VarChar, 100);
                parametro2.Value = pregunta;
                var parametro3 = _comandosql.Parameters.Add("@Resp", SqlDbType.VarChar, 30);
                parametro3.Value = respuesta;
                var parametro4 = _comandosql.Parameters.Add("@Usuario", SqlDbType.VarChar, 100);
                parametro4.Value = emailuser;


                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(_tabla);

                if (_tabla.Rows.Count > 0)
                {
                    isValid = true;
                }

            }
            catch (SqlException e)
            {
                isValid = false;
            }
            finally
            {
                desconectar();
            }
            return isValid;
        }
        public DataTable get_MetodoRecuperacion(string op, string pregunta, string respuesta, string emailuser)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "sp_MetodoRecuperacion";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Op", SqlDbType.Char, 1);
                parametro1.Value = op;
                var parametro2 = _comandosql.Parameters.Add("@Preg", SqlDbType.VarChar, 100);
                parametro2.Value = pregunta;
                var parametro3 = _comandosql.Parameters.Add("@Resp", SqlDbType.VarChar, 30);
                parametro3.Value = respuesta;
                var parametro4 = _comandosql.Parameters.Add("@Usuario", SqlDbType.VarChar, 100);
                parametro4.Value = emailuser;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);
                // la ejecución del SP espera que regrese datos en formato tabla

            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }

        //FAVORITOS
        public bool Favoritos(string op, string nomFavorito, string Version,string Testamento,string Libro,int NumCap,int EsCap,int Versiculo, string Texto, string email, DateTime fechaahora)
        {
            bool isValid = false;
            try
            {
                conectar();
                string qry = "sp_Favoritos";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 9000;

                var parametro1 = _comandosql.Parameters.Add("@Op", SqlDbType.Char, 1);
                parametro1.Value = op;
                var parametro2 = _comandosql.Parameters.Add("@NomFav", SqlDbType.VarChar, 50);
                parametro2.Value = nomFavorito;
                var parametro3 = _comandosql.Parameters.Add("@NVersion", SqlDbType.VarChar, 30);
                parametro3.Value = Version;
                var parametro4 = _comandosql.Parameters.Add("@Testamento", SqlDbType.VarChar, 20);
                parametro4.Value = Testamento;
                var parametro5 = _comandosql.Parameters.Add("@Libro", SqlDbType.VarChar, 20);
                parametro5.Value = Libro;
                var parametro6 = _comandosql.Parameters.Add("@NumeroCap", SqlDbType.TinyInt, 1);
                parametro6.Value = NumCap;
                var parametro7 = _comandosql.Parameters.Add("@EsCapitulo", SqlDbType.Int, 1);
                parametro7.Value = EsCap;
                var parametro8 = _comandosql.Parameters.Add("@Versiculo", SqlDbType.TinyInt, 1);
                parametro8.Value = Versiculo;
                var parametro9 = _comandosql.Parameters.Add("@Texto", SqlDbType.Text,500);
                parametro9.Value = Texto;
                var parametro10 = _comandosql.Parameters.Add("@Usuario", SqlDbType.VarChar, 100);
                parametro10.Value = email;
                var parametro11 = _comandosql.Parameters.Add("@FechaAgregado", SqlDbType.DateTime, 1);
                parametro11.Value = fechaahora;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(_tabla);

                if (_tabla.Rows.Count > 0)
                {
                    isValid = true;
                }

            }
            catch (SqlException e)
            {
                isValid = false;
            }
            finally
            {
                desconectar();
            }
            return isValid;
        }

        public DataTable get_Favoritos(string op, string nomFavorito, string Version, string Testamento, string Libro, int NumCap, int EsCap, int Versiculo, string Texto, string email, DateTime fechaahora)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "sp_Favoritos";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 9000;

                var parametro1 = _comandosql.Parameters.Add("@Op", SqlDbType.Char, 1);
                parametro1.Value = op;
                var parametro2 = _comandosql.Parameters.Add("@NomFav", SqlDbType.VarChar, 50);
                parametro2.Value = nomFavorito;
                var parametro3 = _comandosql.Parameters.Add("@NVersion", SqlDbType.VarChar, 30);
                parametro3.Value = Version;
                var parametro4 = _comandosql.Parameters.Add("@Testamento", SqlDbType.VarChar, 20);
                parametro4.Value = Testamento;
                var parametro5 = _comandosql.Parameters.Add("@Libro", SqlDbType.VarChar, 20);
                parametro5.Value = Libro;
                var parametro6 = _comandosql.Parameters.Add("@NumeroCap", SqlDbType.TinyInt, 1);
                parametro6.Value = NumCap;
                var parametro7 = _comandosql.Parameters.Add("@EsCapitulo", SqlDbType.Int, 1);
                parametro7.Value = EsCap;
                var parametro8 = _comandosql.Parameters.Add("@Versiculo", SqlDbType.TinyInt, 1);
                parametro8.Value = Versiculo;
                var parametro9 = _comandosql.Parameters.Add("@Texto", SqlDbType.Text, 500);
                parametro9.Value = Texto;
                var parametro10 = _comandosql.Parameters.Add("@Usuario", SqlDbType.VarChar, 100);
                parametro10.Value = email;
                var parametro11 = _comandosql.Parameters.Add("@FechaAgregado", SqlDbType.DateTime, 1);
                parametro11.Value = fechaahora;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);

            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }

        //BUSQUEDAS
        public bool Busquedas(string op, string palabras, string idioma, int filtro, string version, string testamento, string libro, string email)
        {
            bool isValid = false;
            try
            {
                conectar();
                string qry = "sp_Busquedas";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 9000;

                var parametro1 = _comandosql.Parameters.Add("@Op", SqlDbType.Char, 1);
                parametro1.Value = op;
                var parametro2 = _comandosql.Parameters.Add("@Palabras", SqlDbType.VarChar, 200);
                parametro2.Value = palabras;
                var parametro3 = _comandosql.Parameters.Add("@Idioma", SqlDbType.VarChar, 20);
                parametro3.Value = idioma;
                var parametro4 = _comandosql.Parameters.Add("@Filtro", SqlDbType.Int, 1);
                parametro4.Value = filtro;
                var parametro5 = _comandosql.Parameters.Add("@NVersion", SqlDbType.VarChar, 30);
                parametro5.Value = version;
                var parametro6 = _comandosql.Parameters.Add("@Testamento", SqlDbType.VarChar, 20);
                parametro6.Value = testamento;
                var parametro7 = _comandosql.Parameters.Add("@Libro", SqlDbType.VarChar, 20);
                parametro7.Value = libro;
                var parametro8 = _comandosql.Parameters.Add("@Usuario", SqlDbType.VarChar, 100);
                parametro8.Value = email;


                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(_tabla);

                if (_tabla.Rows.Count > 0)
                {
                    isValid = true;
                }

            }
            catch (SqlException e)
            {
                isValid = false;
            }
            finally
            {
                desconectar();
            }
            return isValid;
        }
        public DataTable get_Busqueda(string op, string palabras,string idioma, int filtro, string version,string testamento, string libro,string email)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "sp_Busquedas";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Op", SqlDbType.Char, 1);
                parametro1.Value = op;
                var parametro2 = _comandosql.Parameters.Add("@Palabras", SqlDbType.VarChar,200);
                parametro2.Value = palabras;
                var parametro3 = _comandosql.Parameters.Add("@Idioma", SqlDbType.VarChar, 20);
                parametro3.Value = idioma;
                var parametro4 = _comandosql.Parameters.Add("@Filtro", SqlDbType.Int, 1);
                parametro4.Value = filtro;
                var parametro5 = _comandosql.Parameters.Add("@NVersion", SqlDbType.VarChar, 30);
                parametro5.Value = version;
                var parametro6 = _comandosql.Parameters.Add("@Testamento", SqlDbType.VarChar, 20);
                parametro6.Value = testamento;
                var parametro7= _comandosql.Parameters.Add("@Libro", SqlDbType.VarChar, 20);
                parametro7.Value = libro;
                var parametro8 = _comandosql.Parameters.Add("@Usuario", SqlDbType.VarChar, 100);
                parametro8.Value = email;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);
                // la ejecución del SP espera que regrese datos en formato tabla

            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }


        //BIBLIA
        public DataTable ConsultasBiblia(string op, string idioma, string version, string testamento, string libro,int cap,int numver)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "SP_ConsultaBiblia";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Op", SqlDbType.Char, 1);
                parametro1.Value = op;
                var parametro2 = _comandosql.Parameters.Add("@Idioma", SqlDbType.VarChar, 20);
                parametro2.Value = idioma;
                var parametro3 = _comandosql.Parameters.Add("@Version", SqlDbType.VarChar, 30);
                parametro3.Value = version;
                var parametro4 = _comandosql.Parameters.Add("@Testamento", SqlDbType.VarChar, 20);
                parametro4.Value = testamento;
                var parametro5 = _comandosql.Parameters.Add("@Libro", SqlDbType.Char, 20);
                parametro5.Value = libro;
                var parametro6 = _comandosql.Parameters.Add("@Cap", SqlDbType.TinyInt, 1);
                parametro6.Value = cap;
                var parametro7 = _comandosql.Parameters.Add("@NumVer", SqlDbType.TinyInt, 1);
                parametro7.Value = numver;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);
                // la ejecución del SP espera que regrese datos en formato tabla

            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }


        

    }
}
