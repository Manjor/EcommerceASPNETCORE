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

        public DbSet<Produto> Produtos { get; private set; }
        public DbSet<ItemPedido> ItensPedido { get; set; }

        public BancoContext( DbContextOptions options) : base(options)
        {

        }



    }
}
