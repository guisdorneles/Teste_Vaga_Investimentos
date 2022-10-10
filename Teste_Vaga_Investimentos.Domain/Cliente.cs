using System;
using System.ComponentModel.DataAnnotations;

namespace Teste_Vaga_Investimentos.Domain{
    public class Cliente{

        [Required]
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int Idade {get;set;}
    }
}