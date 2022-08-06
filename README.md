# GerenciadorDeVendas
O que é a aplicação ? A aplicação tem a finalidade de gerenciar os CLIENTES dos USUÁRIOS. Conforme são cadastrados os clientes, as informações dos clientes são passadas por uma espécie de ROLETA, a qual identifica os usuários daquela REGIÃO. Assim que geradas a lista dos USUARIOS, caso seja mais de um que atenda a região, é selecionado AQUELE que esta a mais tempo sem receber contato.
API's
USUÁRIO:
Como funciona ? Precisa cadastrar um usuário(Vendedor), o cadastro exige dados,
{
    "nome": "nome",
    "email": "email@email.com",
    "regioes": 1, 2, 3, 4 ou 5
}
Após realizar o cadastro pode fazer um GET de todos os usuários
