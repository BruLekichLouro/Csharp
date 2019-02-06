using ByteBank.Modelos;
using Microsoft.EntityFrameworkCore;
using System;


namespace ByteBank.SistemaAgencia
{
    internal class BancoContext : DbContext
    {
        public DbSet<ContaCorrente> Contas { get; set; }

        public BancoContext()
        { }

        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        { }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ClientesDB;User Id = DESKTOP - LEKICH\bubub;Password = ;");
            }
            



        }
    }
}