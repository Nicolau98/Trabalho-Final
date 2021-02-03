using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trabalho_Final.Models
{
    public class Curriculo
    {
        public List<Experiencia> Experiencias { get; set; }

        public List<Educacao> Educacaos { get; set; }

        public List<Lingua> Linguas { get; set; }

        public List<CartaConducao> CartaConducaos { get; set; }
    }
}
