using GerenciamentoVendas.Models;
using GerenciamentoVendas.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using System.IO;

namespace GerenciamentoVendas.Controllers
{
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {

        [HttpGet("Index")]
        public IActionResult View()
        {
            var html = System.IO.File.ReadAllText(@"./Views/Home/Index.cshtml"); ;
            return new ContentResult
            {
                Content = html,
                ContentType = "text/html"
            };
        }

        // GET Geral
        [HttpGet]
        public IActionResult Get()
        {
            List<Usuario> list = UsuarioService.GetAllUsuarios();
            return Ok(list);

        }

        //Get Oportunidades Usuário
        [HttpGet("GetOportunidadesUsuario")]
        public IActionResult GetOportunidadesUsuario([FromQuery] int id)
        {
            if (String.IsNullOrEmpty(id.ToString()))
            {
                throw new ArgumentNullException("Preencher com o Id para puxar as oportunidades do usuário.");
            }
            List<Usuario> lista = UsuarioService.GetOportunidadesUsuario(id);
            return Ok(lista);
        }

        // GET por Id
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            Usuario usuario = UsuarioService.GetByIdUsuario(id);
            if (usuario == null)
            {
                return NotFound();
            }
            return Ok(usuario);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Usuario usuario)
        {
            string mensagem = "";

            if (usuario == null || usuario.Regioes == 0)
            {
                throw new ArgumentNullException("Enviar todos os dados para Cadastrar o Usuário");
            }

            try
            {
                UsuarioService.PostUsuario(usuario, mensagem);
            }
            catch (Exception e)
            {
                mensagem = $"Error: {e.Message}";
            }
        }
    }
}
