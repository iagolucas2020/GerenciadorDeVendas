using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoVendas.Models.ViewModels
{
    public class ClientePessoaJuricaViewModel
    {
        //Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class AtividadePrincipal
        {
            public string id { get; set; }
            public string secao { get; set; }
            public string divisao { get; set; }
            public string grupo { get; set; }
            public string classe { get; set; }
            public string subclasse { get; set; }
            public string descricao { get; set; }
            public bool contribuinte { get; set; }
        }

        public class AtividadesSecundaria
        {
            public string id { get; set; }
            public string secao { get; set; }
            public string divisao { get; set; }
            public string grupo { get; set; }
            public string classe { get; set; }
            public string subclasse { get; set; }
            public string descricao { get; set; }
            public bool contribuinte { get; set; }
        }

        public class Cidade
        {
            public int id { get; set; }
            public string nome { get; set; }
            public int ibge_id { get; set; }
            public string siafi_id { get; set; }
        }

        public class Estabelecimento
        {
            public string cnpj { get; set; }
            public List<AtividadesSecundaria> atividades_secundarias { get; set; }
            public string cnpj_raiz { get; set; }
            public string cnpj_ordem { get; set; }
            public string cnpj_digito_verificador { get; set; }
            public string tipo { get; set; }
            public string nome_fantasia { get; set; }
            public string situacao_cadastral { get; set; }
            public string data_situacao_cadastral { get; set; }
            public string data_inicio_atividade { get; set; }
            public object nome_cidade_exterior { get; set; }
            public string tipo_logradouro { get; set; }
            public string logradouro { get; set; }
            public string numero { get; set; }
            public string complemento { get; set; }
            public string bairro { get; set; }
            public string cep { get; set; }
            public string ddd1 { get; set; }
            public string telefone1 { get; set; }
            public string ddd2 { get; set; }
            public string telefone2 { get; set; }
            public string ddd_fax { get; set; }
            public string fax { get; set; }
            public string email { get; set; }
            public object situacao_especial { get; set; }
            public object data_situacao_especial { get; set; }
            public DateTime atualizado_em { get; set; }
            public AtividadePrincipal atividade_principal { get; set; }
            public Pais pais { get; set; }
            public Estado estado { get; set; }
            public Cidade cidade { get; set; }
            public object motivo_situacao_cadastral { get; set; }
            public List<InscricoesEstaduai> inscricoes_estaduais { get; set; }
        }

        public class Estado
        {
            public int id { get; set; }
            public string nome { get; set; }
            public string sigla { get; set; }
            public int ibge_id { get; set; }
        }

        public class InscricoesEstaduai
        {
            public string inscricao_estadual { get; set; }
            public bool ativo { get; set; }
            public DateTime atualizado_em { get; set; }
            public Estado estado { get; set; }
        }

        public class NaturezaJuridica
        {
            public string id { get; set; }
            public string descricao { get; set; }
        }

        public class Pais
        {
            public string id { get; set; }
            public string iso2 { get; set; }
            public string iso3 { get; set; }
            public string nome { get; set; }
            public string comex_id { get; set; }
        }

        public class Porte
        {
            public string id { get; set; }
            public string descricao { get; set; }
        }

        public class QualificacaoDoResponsavel
        {
            public int id { get; set; }
            public string descricao { get; set; }
        }

        public class QualificacaoSocio
        {
            public int id { get; set; }
            public string descricao { get; set; }
        }

        public class Root
        {
            public string cnpj_raiz { get; set; }
            public string razao_social { get; set; }
            public string capital_social { get; set; }
            public string responsavel_federativo { get; set; }
            public DateTime atualizado_em { get; set; }
            public Porte porte { get; set; }
            public NaturezaJuridica natureza_juridica { get; set; }
            public QualificacaoDoResponsavel qualificacao_do_responsavel { get; set; }
            public List<Socio> socios { get; set; }
            public Simples simples { get; set; }
            public Estabelecimento estabelecimento { get; set; }
        }

        public class Simples
        {
            public string simples { get; set; }
            public string data_opcao_simples { get; set; }
            public object data_exclusao_simples { get; set; }
            public string mei { get; set; }
            public object data_opcao_mei { get; set; }
            public object data_exclusao_mei { get; set; }
            public DateTime atualizado_em { get; set; }
        }

        public class Socio
        {
            public string cpf_cnpj_socio { get; set; }
            public string nome { get; set; }
            public string tipo { get; set; }
            public string data_entrada { get; set; }
            public string cpf_representante_legal { get; set; }
            public object nome_representante { get; set; }
            public string faixa_etaria { get; set; }
            public DateTime atualizado_em { get; set; }
            public string pais_id { get; set; }
            public QualificacaoSocio qualificacao_socio { get; set; }
            public object qualificacao_representante { get; set; }
        }


    }
}
