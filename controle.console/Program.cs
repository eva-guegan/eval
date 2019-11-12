using controle.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controle.console
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ContextBDD())
            {
                var dateNow = DateTime.Now;

                var intervenant = new Intervenant()
                {
                    Matricule = 123456,
                    Nom = "Guégan",
                    Prenom = "Eva",
                };

                var vehicule = new Vehicule()
                {
                    Immatriculation = "AB-123-CD",
                    Marque = "Toyota",
                    Modele = "azerty",
                    VolumeUtile = 25,
                };

                var materiel = new Materiel()
                {
                    RefUnique = 987,
                    Designation = "Tournevis plat",
                    Description = "Tournevis plat bosh ...",
                    DateAchat = dateNow,
                };

                var intervention = new Intervention()
                {
                    AdresseClient = "12 rue Saint Exupéry",
                    DebutIntervention = dateNow,
                    FinIntervention = dateNow,
                };

                intervenant.Interventions.Add(intervention);
                intervenant.Vehicules.Add(vehicule);
                intervenant.Materiels.Add(materiel);

                db.Intervenants.Add(intervenant);
                db.Vehicules.Add(vehicule);
                db.Materiels.Add(materiel);
                db.Interventions.Add(intervention);
                db.SaveChanges();

                Console.WriteLine("Les informations ont bien été inséré dans la base de données");
            }
        }
    }
}
