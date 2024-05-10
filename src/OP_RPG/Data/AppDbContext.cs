using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OP_RPG.Models.RPG;

namespace OrdemParanormal.Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
              
        }

        public DbSet<OrigemModel> Origem { get; set; }
        public DbSet<ClasseModel> Classe { get; set; }
        public DbSet<TrilhaModel> Trilha { get; set; }
    }
}
