using GerenciamentoVendas.Models;
using GerenciamentoVendas.Models.Enums;
using GerenciamentoVendas.Services;
using System;
using System.Collections.Generic;
using Xunit;

namespace GerenciamentoVendas.TestesUnitarios
{
    public class ClienteTeste
    {
        [Fact]
        public void MetodoRoleta()
        {
            //Arange
            int id = 27;
            string nome = "Martinez";
            string email = "martinez@hotmail.com";
            Regioes regiao = Enum.Parse<Regioes>("Sudeste");
            DateTime dataAtualizacao = new DateTime(2022, 08, 04, 20, 47, 50);

            //Act
            ClientePessoaJuridica cliente = new ClientePessoaJuridica("11039145000112", 31);
            List<Usuario> listUsuarios = UsuarioService.GetAllUsuarios();
            Usuario usuarioRoleta = cliente.RoletaUsuario(listUsuarios, cliente);
            Console.WriteLine(usuarioRoleta.Id);

            //Assert
            Assert.Equal(usuarioRoleta.Id, id);
            Assert.Equal(usuarioRoleta.Nome, nome);
            Assert.Equal(usuarioRoleta.Email, email);
            Assert.Equal(usuarioRoleta.Regioes, regiao);
            Assert.Equal(usuarioRoleta.DataAtualizacaoRegiao, dataAtualizacao);
        }
    }
}
