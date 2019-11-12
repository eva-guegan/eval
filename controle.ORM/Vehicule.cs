using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controle.ORM
{
    public class Vehicule
    {
        [Key]
        public int idVehicule { get; set; }

        [Required]
        [StringLength(20)]
        public string Immatriculation { get; set; }

        [Required]
        [StringLength(50)]
        public string Marque { get; set; }

        [Required]
        [StringLength(50)]
        public string Modele { get; set; }

        public decimal VolumeUtile { get; set; }

        public virtual Intervenant Intervenant { get; set; }
    }
}
