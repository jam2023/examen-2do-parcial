using entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace datos
{
   public class UsuarioDB
    {
        string cadena = "server =localhost; user=root; database=ticket; password=123456";

        public Usuario Autenticar(login login)
        {
            Usuario user = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT* FROM usuario WHERE CodigoUsuario = @CodigoUsuario   AND Contraseña= @Contraseña;");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using(MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 50).Value = login.CodigoUsuario;
                        comando.Parameters.Add("@Contraseña", MySqlDbType.VarChar, 80).Value = login.Contraseña;

                        MySqlDataReader dr = comando.ExecuteReader();
                        if (dr.Read())
                        {
                            user = new Usuario();  
                            user.CodigoUsuario = dr["CodigoUsuario"].ToString();
                            user.Nombre = dr["Nombre"].ToString();
                            user.Contraseña = dr["CodigoUsuario"].ToString();
                            user.Correo = dr["Correo"].ToString();
                            user.FechaCreacion =Convert.ToDateTime (dr["FechaCreacion"]);
                            user.Rol = dr["Rol"].ToString();
                            user.Estaactivo = Convert.ToBoolean(dr["Estaactivo"]);

                        }
                    }
                }   
            }
            catch (System.Exception ex)
            {
            }
            return user;
        }
    }
}
