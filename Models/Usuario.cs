﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEasypark.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o senha!")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o perfil!")]
        public Perfil Perfil { get; set; }
    }

    public enum Perfil
    {
        [Description("Cliente")] Cliente,
        [Description("Estacionamento")] Estacionamento,
        [Description("Serviço de Terceiros")] ServicoTerceiro
    }
}
