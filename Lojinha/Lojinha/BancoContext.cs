using JetBrains.Annotations;
using Lojinha.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lojinha
{
    public class BancoContext : DbContext
    {

       
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ItemPedido> ItensPedido { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public BancoContext(DbContextOptions<BancoContext> options)
             : base(options)
        {

        }
        

    }
}
