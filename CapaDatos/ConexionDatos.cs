using System.Data.SqlClient;

namespace CapaDatos
{
    public class ConexionDatos
    {
        //TODO esta es la cadena de conexion que utilizaremos para conectarnos a SQL 
        public static SqlConnection Conexion()
        {
            string Conexion = "Data Source=.;Initial Catalog = UCE; integrated Security=true";
            SqlConnection conexion = new SqlConnection(Conexion);
            return conexion;    
        }

    }
}
