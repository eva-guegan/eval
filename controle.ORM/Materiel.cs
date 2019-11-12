using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controle.ORM
{
    public class Materiel
    {
        [Key]
        public int IdMateriel { get; set; }

        public int RefUnique { get; set; }

        [Required]
        [StringLength(50)]
        public string Designation { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        public DateTime DateAchat { get; set; }

        public virtual Intervenant Intervenant { get; set; }
    }
}
