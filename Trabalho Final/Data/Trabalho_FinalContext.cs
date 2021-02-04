using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Trabalho_Final.Models;

namespace Trabalho_Final.Data
{
    public class Trabalho_FinalContext : DbContext
    {
        public Trabalho_FinalContext (DbContextOptions<Trabalho_FinalContext> options)
            : base(options)
        {
        }

        public DbSet<Trabalho_Final.Models.Experiencia> Experiencia { get; set; }

        public DbSet<Trabalho_Final.Models.Lingua> Lingua { get; set; }

        public DbSet<Trabalho_Final.Models.CartaConducao> CartaConducao { get; set; }

        public DbSet<Trabalho_Final.Models.Educacao> Educacao { get; set; }

        public DbSet<Trabalho_Final.Models.Mensagem> Mensagem { get; set; }

        public DbSet<Trabalho_Final.Models.Apresentacao> Apresentacao { get; set; }
    }
}
