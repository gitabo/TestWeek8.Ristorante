using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TestWeek8.Ristorante.Core.Models;

namespace TestWeek8.Ristorante.MVC.Models
{
    public class MenuViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Insert Name!")]
        [MaxLength(100, ErrorMessage = "Max 100 characters")]
        public string Nome { get; set; }

        public IList<Piatto> Piatti { get; set; }
    }
}
