# GerenciadorDeVendas
O que é a aplicação ? A aplicação tem a finalidade de gerenciar os CLIENTES dos USUÁRIOS. Conforme são cadastrados os clientes, as informações dos clientes são passadas por uma espécie de ROLETA, a qual identifica os usuários daquela REGIÃO. Assim que geradas a lista dos USUARIOS, caso seja mais de um que atenda a região, é selecionado AQUELE que esta a mais tempo sem receber contato.
Para fazer POST e GET, estava utilizando o POSTAMAN.

API's

***USUÁRIOS:
->Como funciona ? Precisa cadastrar(POST) um usuário(Vendedor), utilizando a 
Url - https://localhost:5001/api/Usuario o cadastro exige dados,
```json
{
    "nome": "nome",
    "email": "email@email.com",
    "regioes": 1, 2, 3, 4 ou 5
}
```
->Após realizar o cadastro, pode-se fazer um GET de todos os usuários, com link abaixo
Url - https://localhost:5001/api/Usuario, vai retornar um array de objetos,
```json
{
     "email": "email@email.com",
     "regioes": 0,
     "dataAtualizacaoRegiao": "0001-01-01T00:00:00",
     "clientePessoaJuridica": "",
     "id": 0,
     "nome": ""
}
```
->Ou, pode-se fazer GET pelo ID do usuário, com o link abaixo,
Url - https://localhost:5001/api/Usuario/id, vai retornar um objeto,
```json
{
     "email": "email@email.com",
     "regioes": 0,
     "dataAtualizacaoRegiao": "0001-01-01T00:00:00",
     "clientePessoaJuridica": "",
     "id": 0,
     "nome": ""
}
```

***CLIENTES
->Como funciona ? Para cadastrar(POST) um Cliente exigi-se um cadastro de um Usuário na região do cliente, para esse cadastro, precisa-se utilizar a 
Url - https://localhost:5001/api/ClientePessoaJuridica, os dados para cadastro abaixo,
```json
{
    "cnpj": "00.000.000/0000-00",
    "nome": "nome",
    "valorMonetario": 0.00
}
```
->Após realizar o cadastro, pode-se fazer um GET de todos os Clientes, com link abaixo
Url - https://localhost:5001/api/ClientePessoaJuridica, vai retornar um array de objetos,
```json
{
        "cnpj": "00000000000000",
        "valorMonetario": 0.00,
        "razaoSocial": "razaosocial",
        "atividades": "atividades",
        "codigoIbge": 0,
        "usuario": {
            "email": "email@email.com",
            "regioes": 0,
            "dataAtualizacaoRegiao": "0001-01-01T00:00:00",
            "clientePessoaJuridica": null,
            "id": 0,
            "nome": "nome"
        },
        "id": 0,
        "nome": "nome"
}
```
->Ou, pode-se fazer GET pelo ID do Cliente, com o link abaixo,
Url - https://localhost:5001/api/ClientePessoaJuridica/id, vai retornar um objeto,
```json
{
    "cnpj": "00000000000000",
    "valorMonetario": 0.00,
    "razaoSocial": "razaosocial",
    "atividades": "atividades",
    "codigoIbge": 0,
    "usuario": null,
    "id": 0,
    "nome": "nome"
}
```
***OPORTUNIDADES
->Como funciona ? As oportunidades puxaram tadas a oportunidades de negocio do Usuario, para isso utiliza-se a link abaixo,
Url - https://localhost:5001/api/Usuario/GetOportunidadesUsuario?id=0, vai retornar um array de objetos,
```json
{
        "email": "email@email.com",
        "regioes": 0,
        "dataAtualizacaoRegiao": "0001-01-01T00:00:00",
        "clientePessoaJuridica": {
            "cnpj": "00000000000000",
            "valorMonetario": 0.00,
            "razaoSocial": "razaosocial",
            "atividades": "atividades",
            "codigoIbge": 0,
            "usuario": null,
            "id": 12,
            "nome": "nome"
        },
        "id": 0,
        "nome": "nome
}
```

Tecnologias Utilizadas:
BACK-END:
.Net FRAMEWORK - o qual realizei a criação dos endpoint, que pode ser consumida com os link acima. O endpoint fica na controladora, o que faz a comunicação do a camada de Serviço, que faz a comunicação com a camada DAL, que faz a buscas no banco de dados e retorna as informações.
Controladora:
Usei algumas bibliotecas como: 
using System.Linq - que ajudar a fazer filtra na lista retornada pelo banco;
using Flurl.Http - o qual consegui consumir um endpoint externo, usei para Get dos demais dados do cliente (Razão Social, Atividades).
using System.Collections.Generic - ajuda na criação das list;
Seriços: Utilizei para criação de algumas regra, antes de chegar na camada DAL, como a verificação verificar o cadastro do email do usuário, se já existe.
Dal: Camada de acesso aos dados, usei para fazer as buscas no banco, update e posts.

FRONT-END:
Html: fiz a criação dos formulários e tabelas;
Css: Usei para personalizar algum item da página web em html;
Bootstrap (FRAMEWORK): usei para auxiliar no ajustes do Grid;
JavaScrip: 
Utilizei para pegar os dados preenchidos no formulários, passar para os endpoint;
Para consumir o endpoint utilizei o framework do axios;
Também construi todas as tabelas utilizando javascript puro, manipulando DOM.


