using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace PessoaFisica.Models
{
    public class Usuario
    {
        public Usuario()
        {
            ListaDePessoas = new Collection<Pessoa>();

        }

        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Required]
        [Column("Username")]
        [MaxLength(15), MinLength(4)]
        [Display(Name = "Username")]
        public String Username { get; set; }

        [Required]
        [Column("Email")]
        [MaxLength(30), MinLength(5)]
        [Display(Name = "E-mail")]
        public String Email { get; set; }

        [Required]
        [Column("Telefone")]
        [MaxLength(13), MinLength(8)]
        [Display(Name = "Telefone")]
        public String Telefone { get; set; }

        [Required]
        [Column("Senha")]
        [MaxLength(15), MinLength(4)]
        [Display(Name = "Senha")]
        public String Senha { get; set; }

        [Column("Imagem")]
        [MaxLength(500), MinLength(5)]
        [Display(Name = "Imagem")]
        public String? Imagem { get; set; }

        public virtual ICollection<Pessoa> ListaDePessoas { get; set; }
    }
}
