using System.Data.SqlClient;
using cositas.Models;
using Dapper;

namespace cositas.DAL
{
    public class UsuarioRespository
    {
        public void Insert(Usuario usuario)
        {
            var connStr = @"Server=.\SQLEPRESS;Database=ApiTesting;Integrated Security=true";
            var sql = "insert into Usuario(Nombre,Email,Edad,Password) value (@Nombre,@Email,@Edad,@Password)";
            
            using(var conn = new SqlConnection(connStr))
            {
                conn.Open();
                conn.Execute(sql, usuario);
                conn.Close();
            }
        
        }
    }
}