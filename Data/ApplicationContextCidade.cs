using DominandoEFCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DominandoEFCore.Data
{
    public class ApplicationContextCidade : DbContext
    {
        public DbSet<Cidade> Cidades { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            const string strConnection = "Server=localhost,1433;Database=EFCore;User ID=sa;Password=1q2w3e4r@#$";
            optionsBuilder
                .UseSqlServer(strConnection)
                .EnableSensitiveDataLogging()
                .LogTo(Console.WriteLine, LogLevel.Information);
        }
    }
}
