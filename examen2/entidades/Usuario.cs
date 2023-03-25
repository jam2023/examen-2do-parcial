using System;

namespace entidades
{
    public class Usuario
    {
        public string CodigoUsuario { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Rol { get; set; }
        public bool Estaactivo { get; set; }    
     public string Contraseña { get; set; }  

        public Usuario()
        {
        }

        public Usuario(string codigoUsuario, string nombre, string correo, DateTime fechaCreacion, string rol, bool estaactivo, string contraseña)
        {
            CodigoUsuario = codigoUsuario;
            Nombre = nombre;
            Correo = correo;
            FechaCreacion = fechaCreacion;
            Rol = rol;
            Estaactivo = estaactivo;
            Contraseña = contraseña;
        }
    }
}
