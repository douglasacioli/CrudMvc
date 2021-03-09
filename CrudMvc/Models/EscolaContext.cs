using System.Data.Entity;

namespace CrudMvc.Models
{
    public class EscolaContext : DbContext
    {
        public EscolaContext() : base("Escola")
        {
            Database.CreateIfNotExists(); 
        }
        public DbSet<Aluno> Alunos { get; set; }
   
    }
}