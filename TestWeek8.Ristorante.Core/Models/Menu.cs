using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek8.Ristorante.Core.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public IList<Piatto> Piatti { get; set; }
    }
}
