using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek8.Ristorante.Core.Models
{
    public class Piatto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Tipologia { get; set; }//metto i controlli di check nell'OnModelCreating
        public decimal Prezzo { get; set; }
        public Menu Menu { get; set; }
    }
}
