using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controle.ORM
{
    public class Intervenant
    {
        public Intervenant()
        {
            Vehicules = new List<Vehicule>();
            Materiels = new List<Materiel>();
            Interventions = new List<Intervention>();
        }

        [Key]
        public int idIntervenant { get; set; }

        public decimal Matricule { get; set; }

        [Required]
        [StringLength(50)]
        public string Nom { get; set; }

        [Required]
        [StringLength(50)]
        public string Prenom { get; set; }

        public virtual ICollection<Vehicule> Vehicules { get; set; }

        public virtual ICollection<Materiel> Materiels { get; set; }

        public virtual ICollection<Intervention> Interventions { get; set; }
    }
}
