using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace PessoaFisica.Models
{
    public class Pessoa
    {

        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Column("Nome")]
        [MaxLength(15), MinLength(4)]
        [Display(Name = "Nome")]
        public String? Nome { get; set; }

        [Column("Sobrenome")]
        [MaxLength(15), MinLength(4)]
        [Display(Name = "Sobrenome")]
        public String? Sobrenome { get; set; }

        [Required]
        [Column("Email")]
        [MaxLength(30), MinLength(5)]
        [Display(Name = "E-mail")]
        public String Email { get; set; }


        [Column("DataNascimento")]
        [Display(Name = "Data de Nascimento")]
        public DateTime? DataNascimento { get; set; }

        [Column("RG")]
        [MaxLength(9), MinLength(9)]
        [Display(Name = "RG")]
        public String? RG { get; set; }

        [Column("CPF")]
        [MaxLength(11), MinLength(11)]
        [Display(Name = "CPF")]
        public String? CPF { get; set; }

        //Endereços

        [Column("Logradouro1")]
        [Display(Name = "Logradouro")]
        public String? Logradouro1 { get; set; }

        [Column("CEP1")]
        [Display(Name = "CEP")]
        public String? CEP1 { get; set; }

        [Column("Numero1")]
        [Display(Name = "Numero")]
        public int? Numero1 { get; set; }

        [Column("Complemento1")]
        [Display(Name = "Complemento")]
        public String? Complemento1 { get; set; }

        [Column("Cidade1")]
        [Display(Name = "Cidade")]
        public String? Cidade1 { get; set; }

        [Column("Estado1")]
        [Display(Name = "Estado")]
        public String? Estado1 { get; set; }

        [Column("Logradouro2")]
        [Display(Name = "Logradouro")]
        public String? Logradouro2 { get; set; }

        [Column("CEP2")]
        [Display(Name = "CEP")]
        public String? CEP2 { get; set; }

        [Column("Numero2")]
        [Display(Name = "Numero")]
        public int? Numero2 { get; set; }

        [Column("Complemento2")]
        [Display(Name = "Complemento")]
        public String? Complemento2 { get; set; }

        [Column("Cidade2")]
        [Display(Name = "Cidade")]
        public String? Cidade2 { get; set; }

        [Column("Estado2")]
        [Display(Name = "Estado")]
        public String? Estado2 { get; set; }

        //Contatos

        [Column("Nome1")]
        [Display(Name = "Nome")]
        public String? Nome1 { get; set; }

        [Column("ValorContato1")]
        [Display(Name = "Contato")]
        public String? ValorContato1 { get; set; }

        [Column("TipoContato1")]
        [Display(Name = "Tipo de Contato")]
        public String? TipoContato1 { get; set; }

        [Column("Nome2")]
        [Display(Name = "Nome")]
        public String? Nome2 { get; set; }

        [Column("ValorContato2")]
        [Display(Name = "Contato")]
        public String? ValorContato2 { get; set; }

        [Column("TipoContato2")]
        [Display(Name = "Tipo de Contato")]
        public String? TipoContato2 { get; set; }

        public Usuario? Usuario { get; set; }


    }
}
