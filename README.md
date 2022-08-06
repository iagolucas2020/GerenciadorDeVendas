# GerenciadorDeVendas
<h5>O que é a aplicação ? A aplicação tem a finalidade de gerenciar os CLIENTES dos USUÁRIOS. Conforme são cadastrados os clientes, as informações dos clientes são passadas por uma espécie de ROLETA, a qual identifica os usuários daquela REGIÃO. Assim que geradas a lista dos USUARIOS, caso seja mais de um que atenda a região, é selecionado AQUELE que esta a mais tempo sem receber contato.<h5>
<p>Para fazer POST e GET, estava utilizando o POSTAMAN.<p>

<h1>API's<h1/>

<h3>USUÁRIOS:<h3>
<h5>Como funciona ? Precisa cadastrar(POST) um usuário(Vendedor), utilizando a 
Url - https://localhost:5001/api/Usuario o cadastro exige dados,<h5>

```json
{
    "nome": "nome",
    "email": "email@email.com",
    "regioes": 1, 2, 3, 4 ou 5
}
```

<h5>Após realizar o cadastro, pode-se fazer um GET de todos os usuários, com link abaixo
Url - https://localhost:5001/api/Usuario, vai retornar um array de objetos,<h5>
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
<h5>Ou, pode-se fazer GET pelo ID do usuário, com o link abaixo,
Url - https://localhost:5001/api/Usuario/id, vai retornar um objeto,<h5>
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

<h3>CLIENTES<h3>
<h5>Como funciona ? Para cadastrar(POST) um Cliente exigi-se um cadastro de um Usuário na região do cliente, para esse cadastro, precisa-se utilizar a 
Url - https://localhost:5001/api/ClientePessoaJuridica, os dados para cadastro abaixo,<h5>
```json
{
    "cnpj": "00.000.000/0000-00",
    "nome": "nome",
    "valorMonetario": 0.00
}
```
<h5>Após realizar o cadastro, pode-se fazer um GET de todos os Clientes, com link abaixo
Url - https://localhost:5001/api/ClientePessoaJuridica, vai retornar um array de objetos,<h5>
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
<h5>Ou, pode-se fazer GET pelo ID do Cliente, com o link abaixo,
Url - https://localhost:5001/api/ClientePessoaJuridica/id, vai retornar um objeto,<h5>
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
<h3>OPORTUNIDADES<h3>
<h5>Como funciona ? As oportunidades puxaram tadas a oportunidades de negocio do Usuario, para isso utiliza-se a link abaixo,
Url - https://localhost:5001/api/Usuario/GetOportunidadesUsuario?id=0, vai retornar um array de objetos,<h5>
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
        "nome": "nome"
}
```

<h1>Tecnologias Utilizadas:<h1>
<h3>BACK-END:<h3>
<p>.Net FRAMEWORK - o qual realizei a criação dos endpoint, que pode ser consumida com os link acima. O endpoint fica na controladora, o que faz a comunicação do a camada de Serviço, que faz a comunicação com a camada DAL, que faz a buscas no banco de dados e retorna as informações.<p>
<h5>Controladora:<h5>
<p>Usei algumas bibliotecas como:<p>
<p>using System.Linq - que ajudar a fazer filtra na lista retornada pelo banco;<p>
<p>using Flurl.Http - o qual consegui consumir um endpoint externo, usei para Get dos demais dados do cliente (Razão Social, Atividades).<p>
<p>using System.Collections.Generic - ajuda na criação das list;<p>
<h5>Services: <p>Utilizei para criação de algumas regra, antes de chegar na camada DAL, como a verificação verificar o cadastro do email do usuário, se já existe.<p><h5>
<h5>DAL: <p>Camada de acesso aos dados, usei para fazer as buscas no banco, update e posts.<p><h5>
<h5>MySql: <p>É o SGBD, o qual usei para fazer o gerencimento das tabelas, inclusive deixei um documento dentro da pasta DUMP com todas as tabelas que utilizei, é importante usa-la para testar a aplicação<p>

<h3>FRONT-END:<h3>
<h5>Html: <p>fiz a criação dos formulários e tabelas;<p><h5>
<h5>Css: <p>Usei para personalizar algum item da página web em html;<p><h5>
<h5>Bootstrap <p>(FRAMEWORK): usei para auxiliar no ajustes do Grid;<p><h5>
<h5>JavaScrip:
<p>Utilizei para pegar os dados preenchidos no formulários, passar para os endpoint;<p>
<p>Para consumir o endpoint utilizei o framework do axios;<p>
<p>Também construi todas as tabelas utilizando javascript puro, manipulando DOM.<p><h5> 


