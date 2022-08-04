﻿using Flurl.Http;
using GerenciamentoVendas.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GerenciamentoVendas.Models.ViewModels;
using GerenciamentoVendas.Services;
using GerenciamentoVendas.Models.Enums;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GerenciamentoVendas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientePessoaJuridicaController : ControllerBase
    {

        // GET Geral
        [HttpGet]
        public IActionResult Get()
        {
            List<ClientePessoaJuridica> list = ClientePessoaJuridicaService.GetAllClientePessoaJuridica();
            return Ok(list);
        }

        // GET por Id
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            ClientePessoaJuridica cliente = ClientePessoaJuridicaService.GetByIdClientePessoaJuridica(id);
            if (cliente == null)
            {
                return NotFound();
            }
            return Ok(cliente);
        }

        // POST api/<ClientePessoaJuridicaController>
        [HttpPost]
        public async void Post([FromBody] ClientePessoaJuridica cliente)
        {
            string mensagem = "";

            try
            {
                if (cliente == null)
                {
                    throw new ArgumentNullException("Enviar todos os dados para Cadastrar o Usuário");
                }
                cliente.LimparCaractersCnpj();
                //Buscar demais dados do cliente
                var result = await GetByCnpj(cliente);

                //Puxar lista de usuarios cadastrados com o codigo da Região
                List<Usuario> listUsuarios = UsuarioService.GetAllUsuarios();

                //Filtrar Usuario que esta mais tempo se receber contato da região que vai receber o contato
                List<Usuario> users = listUsuarios.FindAll(u => u.Regioes == (Enum.Parse<Regioes>(cliente.CodigoIbge.ToString().Substring(0, 1))));
                if (users.Count == 0)
                {
                    throw new ArgumentNullException("Não existe Usuario nesta região, por favor realizar o cadastro de usuário nesta região antes.");
                }
                DateTime MinDate = (from d in users select d.DataAtualizacaoRegiao).Min();
                Usuario user = users.Find(u => u.DataAtualizacaoRegiao == MinDate);


                //Fazer Insert do cliente
                ClientePessoaJuridicaService.PostClientePessoaJuridica(cliente, user.Id, mensagem);

                //Update Data de Atualização da Região
                UsuarioService.UpDateDataAtualizacao(user.Id, mensagem);
            }
            catch (Exception e)
            {
                mensagem = $"Error: {e.Message}";
            }

        }

        public async Task<IActionResult> GetByCnpj(ClientePessoaJuridica cliente)
        {
            string cnpj = cliente.Cnpj;
            string link = "https://publica.cnpj.ws/cnpj/" + cnpj;
            var result = await link.GetJsonAsync<ClientePessoaJuricaViewModel.Root>();
            cliente.RazaoSocial = result.razao_social;
            cliente.Atividades = result.estabelecimento.atividade_principal.descricao == "" ? "Atividade Não declarada" : result.estabelecimento.atividade_principal.descricao;
            cliente.CodigoIbge = result.estabelecimento.estado.ibge_id;
            return Ok(cliente);
        }

    }
}
