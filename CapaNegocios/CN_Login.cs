using System.Data.SqlClient;
using CapaDatos;


namespace CapaNegocios
{
    public class CN_Login
    {
        public static bool ValidarLogin(string usuario, string clave)
        {
            bool valido = false;

            using (SqlConnection con = ConexionDatos.Conexion())
            {
                con.Open();
                string query = "SELECT COUNT(*) FROM Usuario where NombreUsuario = @usuario AND clave = @clave";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@clave", clave);

                int count = (int)cmd.ExecuteScalar();
                if (count > 0) 
                {
                    valido = true;
                }

            }
            return valido;
            
        
        }
        
    }
}
