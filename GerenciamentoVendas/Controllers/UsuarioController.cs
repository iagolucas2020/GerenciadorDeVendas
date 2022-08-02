using GerenciamentoVendas.DAL;
using GerenciamentoVendas.Models;
using GerenciamentoVendas.Models.Enums;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GerenciamentoVendas.Controllers
{
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private List<Usuario> _usuario = new List<Usuario>
        {
            new Usuario(1, "Iago", "iago@hotmail.com", Regioes.CentroOeste),
            new Usuario(2, "Daiane", "daiane@hotmail.com", Regioes.Norte)
        };

        public object UsuarioDal { get; private set; }

        [HttpGet]
        public IActionResult Get()
        {
            UsuarioDAL.GetUsuarios();
            return Ok(_usuario);
        }
    }
}
