using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEtudiant.clsGestionEtudiant_variables
{
    public interface  clsvariable_etudiants
    {
        string id { get; set; }
         string matricule { get; set; }
         string nom { get; set; }
         string postnom { get; set; }
         string prenom { get; set; }
         string sexe { get; set; }
         string etat_civil { get; set; }
    }
}
