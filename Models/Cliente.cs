using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEasypark.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        [Key]
        public int Cliente_id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome!")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o tipo do carro!")]
        [Display(Name = "Tipo do Carro")]
        public string TipoCarro { get; set; }

        [Display(Name = "Modelo do Carro")]
        public string ModeloCarro { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a placa do carro!")]
        [Display(Name = "Placa do Carro")]
        public string PlacaCarro { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o e-mail!")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        //[ForeignKey]
        [Required(ErrorMessage = "Obrigatório informar CPF/CNPJ!")]
        [Display(Name = "CPF/CNPJ")]
        public int Registro { get; set; }

        [Display(Name = "Vaga preferida")]
        public TipoVaga TipoVaga { get; set; }

    }

    public enum TipoVaga
    {
        Normal,
        Idoso,
        Deficiente,
        Elétrica
    }
}
