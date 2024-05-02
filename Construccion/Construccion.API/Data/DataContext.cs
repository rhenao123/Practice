
using construccion.Shared.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace Construccion.API.Data
{
    public class DataContext:DbContext
    {

            public DataContext(DbContextOptions<DataContext> options ):base(options) { 


        
        }    

        public DbSet<ProjectConstr> ProjectConstrs { get; set; }
        public DbSet<EquiCons> EquiConss { get; set; }

        public DbSet<machinery> Machineries { get; set; }

        public DbSet<Tarea> Tareas { get; set; }
        public DbSet<Materiales> Materialess { get; set; }
        public DbSet<Presupuesto> Presupuestos { get; set; }

        public DbSet<AssignmentsTeams> AssignmentsTeamss { get; set; }

        public DbSet<AssigmentMats> AssigmentMatss { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ProjectConstr>().HasIndex(c=>c.id).IsUnique();
         
        }



    }
}
