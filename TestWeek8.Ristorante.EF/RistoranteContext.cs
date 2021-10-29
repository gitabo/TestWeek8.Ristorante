using Microsoft.EntityFrameworkCore;
using System;
using TestWeek8.Ristorante.Core.Models;

namespace TestWeek8.Ristorante.EF
{
    public class RistoranteContext : DbContext
    {
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Piatto> Piatti { get; set; }
        public DbSet<User> Users { get; set; }

        public RistoranteContext(DbContextOptions<RistoranteContext> options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            var menuEntity = builder.Entity<Menu>();

            menuEntity.HasKey(m => m.Id);
            menuEntity.Property(m => m.Nome).HasMaxLength(100).IsRequired();
            menuEntity.HasMany(p => p.Piatti).WithOne(m => m.Menu);

            var piattoEntity = builder.Entity<Piatto>();
            piattoEntity.HasKey(p => p.Id);
            piattoEntity.Property(p => p.Nome).HasMaxLength(100).IsRequired();
            piattoEntity.Property(p => p.Prezzo).HasColumnType("decimal(5,2)").IsRequired();
            piattoEntity.HasCheckConstraint("constraint_type", "Tipologia = 'Primo' or Tipologia = 'Secondo' " +
                "or Tipologia = 'Contorno' or Tipologia = 'Dolce'");
            piattoEntity.Property(p => p.Tipologia).IsRequired();
            piattoEntity.HasOne(m => m.Menu).WithMany(p => p.Piatti);

            #region USER
            var userEntity = builder.Entity<User>();
            userEntity.HasKey(i => i.Id);
            userEntity.Property(e => e.Email).IsRequired();
            userEntity.Property(p => p.Password).IsRequired();
            userEntity.Property(r => r.Role).IsRequired();

            userEntity.HasData(
                new User
                {
                    Id = 1,
                    Email = "m.rossi@abc.it",
                    Password = "1234",
                    Role = Role.Ristoratore
                },
                new User
                {
                    Id = 2,
                    Email = "l.bianchi@abc.it",
                    Password = "5678",
                    Role = Role.Cliente
                }
                );
            #endregion
        }
    }
}
