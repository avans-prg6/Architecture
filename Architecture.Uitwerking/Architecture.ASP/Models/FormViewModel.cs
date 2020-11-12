using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Architecture.ASP.Models
{
    public class FormViewModel
    {
        public string Omschrijving { get; set; }

        [Required]
        public DateTime? Start { get; set; }

        [Required]
        public DateTime? Einde { get; set; }

        [Required]
        public Boolean IsRepeat { get; set; }

        public int? AantalKeer { get; set; }

        [Required]
        public Boolean IsHoliday { get; set; }
    }
}
