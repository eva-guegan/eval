using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controle.ORM
{
    public class Intervention
    {
        [Key]
        public int idIntervention { get; set; }

        [Required]
        [StringLength(100)]
        public string AdresseClient { get; set; }

        public DateTime DebutIntervention { get; set; }

        public DateTime FinIntervention { get; set; }

        public virtual Intervenant Intervenant { get; set; }
    }
}
