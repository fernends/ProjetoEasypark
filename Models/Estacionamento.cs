using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEasypark.Models
{
    [Table("Estacionamentos")]
    public class Estacionamento
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

        [Required(ErrorMessage = "Obrigatório informar a quantidade de vagas!")]
        [Display(Name = "Normal")]
        public int VagaNormal { get; set; }
        
        [Required(ErrorMessage = "Obrigatório informar a quantidade de vagas!")]
        [Display(Name = "Idoso")]
        public int VagaIdoso { get; set; }
        
        [Required(ErrorMessage = "Obrigatório informar a quantidade de vagas!")]
        [Display(Name = "Deficiente")]
        public int VagaDeficiente { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a quantidade de vagas!")]
        [Display(Name = "Elétrica")]
        public int VagaElerica { get; set; }
    }

    public enum Estado
    {
        AC,
        AL,
        AP,
        AM,
        BA,
        CE,
        DF,
        ES,
        GO,
        MA,
        MT,
        MS,
        MG,
        PA,
        PB,
        PR,
        PE,
        PI,
        RJ,
        RN,
        RS,
        RO,
        RR,
        SC,
        SP,
        SE,
        TO
    }
}

