using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMADFloresBlanco
{
    public class UsuarioLogeado
    {
       public string NombreCompleto { get; set; }
       public string emailUsuario { get; set; }
       public string contraseña {  get; set; } 

       public int tipoContraseña { get; set; }
       public int fuente {  get; set; }    


    }
}
