using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudMvc.Models
{
    [Table("Aluno")]
    public class Aluno
    {
        public int Id { get; set; }
        [Required] 
        public string Nome { get; set; }
        [Required]
        [Display(Name = "Endereco")] 
        public string Endereco { get; set; }
        [Required]
        public string Telefone { get; set; }
        [Display(Name ="E-mail")]
        public string Email { get; set; }
        [Display(Name = "Data Nasc.")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Nascimento { get; set; }
        [Required]
        public bool Ativo { get; set; }
    }
}