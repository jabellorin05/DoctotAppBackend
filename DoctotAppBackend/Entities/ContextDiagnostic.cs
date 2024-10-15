


using DoctotAppBackend.Model;
using Microsoft.EntityFrameworkCore;
namespace DoctotAppBackend.Entities
{


    public class RepositoryContext : DbContext
    {

        public RepositoryContext(DbContextOptions options): base(options) { }  


        public DbSet<Observation>? Observations { get; set; }

        public DbSet<Prescription>? Prescriptions { get; set; }


    }



}


