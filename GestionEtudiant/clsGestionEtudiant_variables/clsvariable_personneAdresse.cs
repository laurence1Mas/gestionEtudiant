using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEtudiant.clsGestionEtudiant_variables
{
    public interface clsvariable_personneAdresse
    {
         string id { get; set; }
         string id_etudiant { get; set; }
         string id_adresse { get; set; }
         string avenue { get; set; }
         int numero_avenue { get; set; }
    }
}
