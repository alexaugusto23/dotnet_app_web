using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models
{
    public class Context : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            //optionsBuilder.UseSqlServer(connectionString: @"Server=ALEX;Database=Curso_mvc;Integrated Security=true");
            optionsBuilder.UseSqlServer(connectionString: @"Data Source = tcp:cursomvcdbserveralex.database.windows.net,1433; Initial Catalog = CursoMVC_db; User Id = sa_alex@cursomvcdbserveralex; Password = Music2989#");

            
        }
    }
}
