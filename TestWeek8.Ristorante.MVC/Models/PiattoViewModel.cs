using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestWeek8.Ristorante.MVC.Models
{
    public class PiattoViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Insert Name!")]
        [MaxLength(100, ErrorMessage = "Max 100 characters")]
        public string Nome { get; set; }
        [Required]
        public string Tipologia { get; set; }
        [Required]
        public decimal Prezzo { get; set; }
        public string Menu { get; set; }
    }
}
