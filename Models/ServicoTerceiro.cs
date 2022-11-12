using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEasypark.Models
{
    [Table("Servico Terceiro")]
    public class ServicoTerceiro
    {
        [Key]
        public int Cliente_id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome da empresa!")]
        [Display(Name = "Nome da Empresa")]
        public string NomeEmpresa { get; set; }

        //[ForeignKey]
        [Required(ErrorMessage = "Obrigatório informar CNPJ!")]
        [Display(Name = "CNPJ")]
        public int Cnpj { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o e-mail!")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o lugadouro!")]
        [Display(Name = "Lugadouro")]
        public string Lugadouro { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o número!")]
        [Display(Name = "Número")]
        public int Numero { get; set; }

        [Display(Name = "Complemento")]
        public int Complemento { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a Cidade!")]
        [Display(Name = "Cidade")]
        public string Cidade { get; set; }

        [Display(Name = "UF")]
        public Estado Estado { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o CEP!")]
        public int CEP { get; set; }

        public int Telefone { get; set; }

        [Display(Name = "Tipo de Serviço Prestado")]
        public TipoServico TipoServico { get; set; }

        
    }

    public enum TipoServico
    {
        Chaveiro,
        LavaJato,
        Reboque
    }
}
