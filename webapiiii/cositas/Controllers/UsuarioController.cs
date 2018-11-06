using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using cositas.Models;
using Microsoft.AspNetCore.Mvc;

namespace cositas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Usuario>> Get()
        {
            Usuario a = new Usuario()
            {
                Email = "paula@ruhl.com",
                Edad = 21,
                Nombre = "Pau",
                Id = 2,
                Password = "1234"
            };
            Usuario b = new Usuario()
            {
                Email = "julio@ruhl.com",
                Edad = 52,
                Nombre = "Julio",
                Id = 3,
                Password = "3333"
            };
            List<Usuario> usuarios = new List<Usuario>();
            usuarios.Add(a);
            usuarios.Add(b);
            return usuarios;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPost]
        [Route("/api/Usuario/")]
        public void Post([FromBody] Usuario usuario)
        {
            if (this.ModelState.IsValid)
            {
                
            }
        }
        // private IEnumerable<Usuario> GetUser()
        // {
        //     var connStr = "Server=.;Database=UserDB;Integrated Security=true;";
        //     var sql = "select * from Usuario";
        //     using (var conn = new SqlConnection(connStr))
        //     {
        //         conn.Open();
        //         var list = conn.Query<Usuario>(sql);
        //         conn.Close();
        //         return list;

        //     }
        // }

        // private void InsertUser(Usuario u)
        // {
        //     var connStr = "Server=.;Database=UserDB;Integrated Security=true;";
        //     var sql = "insert into User(UserName,Password) values (@UserName,@Password)";
        //     using (var conn = new SqlConnection(connStr))
        //     {
        //         conn.Open();
        //         var list = conn.Execute(sql, new {""});
        //         conn.Close();

        //     }
        // }
    }
}