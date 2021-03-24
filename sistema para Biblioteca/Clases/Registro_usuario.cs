using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_para_Biblioteca.Clases
{
    class Registro_usuario
    {
       private string nombre;
       private string apellido;
       private string telefono;
       private string id_usuario;
       private string direccion;
       private string tipo_usuario;


       public string Telefono
       {
           get { return telefono; }
           set { telefono = value; }
       }
      

       public string Id_usuario
       {
           get { return id_usuario; }
           set { id_usuario = value; }
       }
      

       public string Direccion
       {
           get { return direccion; }
           set { direccion = value; }
       }
       

       public string Tipo_usuario
       {
           get { return tipo_usuario; }
           set { tipo_usuario = value; }
       }

       public string Nombre
       {
           get { return nombre; }
           set { nombre = value; }
       }

       public string Apellido
       {
           get { return apellido; }
           set { apellido = value; }
       }

      

       public Registro_usuario(string nombre, string apellido, string telefono, string id_usuario, string direccion, string tipo_usuario)
       {
           this.nombre = nombre;
           this.apellido = apellido;
           this.telefono = telefono;
           this.id_usuario = id_usuario;
           this.direccion = direccion;
           this.tipo_usuario = tipo_usuario;

       }

       public Registro_usuario()
       {

       }
      
    }
}
