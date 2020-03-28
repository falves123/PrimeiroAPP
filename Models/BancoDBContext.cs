using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace primeiroapp.models{

    public class BancoDBContext : DbContext{
            public BancoDBContext()
            {
                this.Database.EnsureCreated();
            }
            public DbSet<Produto> Produtos { get; set; }

            override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
                optionsBuilder.UseSqlite("Data source=banconovo.db");
            }
    }

    public class Produto{
        [Key]
        public int ProdutoID { get; set; }
        [StringLength(50)]
        [Required]
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }

    }
}