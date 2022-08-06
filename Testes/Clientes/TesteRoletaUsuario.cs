using GerenciamentoVendas.Models;
using GerenciamentoVendas.Models.Enums;
using GerenciamentoVendas.Services;
using System;
using System.Collections.Generic;
using Xunit;

namespace GerenciamentoVendas.TesteUnitarios
{
    public class TesteRoletaUsuario
    {

        [Fact]
        public void MetodoRoleta()
        {
            //Arange
            int id = 17;
            string nome = "Martinez";
            string email = "martinez@hotmail.com";
            Regioes regiao = Enum.Parse<Regioes>("Sudeste");
            DateTime dataAtualizacao = new DateTime(2022, 08, 04, 20, 47, 50);

            //Act
            ClientePessoaJuridica cliente = new ClientePessoaJuridica("11039145000112", "Meta e treinamentos", 300.00, "Treinamentos");
            List<Usuario> usuario = UsuarioService.GetAllUsuarios();
            Usuario usuarioRoleta = cliente.RoletaUsuario(usuario, cliente);
            Console.WriteLine(usuarioRoleta.Id);

            //Assert
            Assert.Equal(id, 27);

        }

    }
}
