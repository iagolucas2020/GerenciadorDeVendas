using GerenciamentoVendas.Models;
using GerenciamentoVendas.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Cors;
using System.IO;
using Nancy.Json;

namespace GerenciamentoVendas.Controllers
{
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        // GET Geral
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                List<Usuario> list = UsuarioService.GetAllUsuarios();
                if (list.Count == 0)
                {
                    return NotFound("Dados não encontrados");
                }
                return Ok(list);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        //Get Oportunidades Usuário
        [HttpGet("GetOportunidadesUsuario")]
        public IActionResult GetOportunidadesUsuario([FromQuery] int id)
        {
            try
            {
                if (id == 0)
                {
                    return BadRequest("Preencher com o Id para puxar as oportunidades do usuário.");
                }
                List<Usuario> list = UsuarioService.GetOportunidadesUsuario(id);
                if (list.Count == 0)
                {
                    return NotFound("Dados não encontrados");
                }
                return Ok(list);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        // GET por Id
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                Usuario usuario = UsuarioService.GetByIdUsuario(id);
                if (usuario.Nome == null)
                {
                    return NotFound("Usuário não encontrado");
                }
                return Ok(usuario);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] Usuario usuario)
        {
            string mensagem = "";
            try
            {
                if (usuario == null && usuario.Regioes == 0)
                {
                    return BadRequest("Enviar todos os dados para Cadastrar o Usuário.");
                }
                UsuarioService.PostUsuario(usuario, mensagem);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        //View Usuarios
        [HttpGet("Usuarios")]
        public IActionResult ViewUsuarios()
        {
            var html = System.IO.File.ReadAllText(@"./Views/Usuarios/Usuarios.cshtml");
            return new ContentResult
            {
                Content = html,
                ContentType = "text/html"
            };
        }

        [HttpGet("Oportunidades")]
        public IActionResult ViewOportunidades()
        {
            var html = System.IO.File.ReadAllText(@"./Views/Usuarios/Oportunidades.cshtml");
            return new ContentResult
            {
                Content = html,
                ContentType = "text/html"
            };
        }

    }
}
