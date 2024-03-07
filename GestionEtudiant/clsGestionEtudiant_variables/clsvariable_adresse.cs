using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEtudiant.clsGestionEtudiant_variables
{
    public interface clsvariable_adresse
    {
         string id { get; set; }
         string quartier { get; set; }
         string commune { get; set; }
         string ville { get; set; }
         string pays { get; set; }
    }
}
