using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4A.Models
{
    public class RequeteDTO
    {
        public Guid? Id { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public string Courriel { get; set; }
        public string MotDePasse { get; set; }
        public DateTime DateDeNaissance { get; set; }
        public bool? Homme { get; set; }
        public string Telephone { get; set; }
        public int? NumCivique { get; set; }
        public string Rue { get; set; }
        public string NumCarteCredit { get; set; }
        public int? CouleurPreferee { get; set; }
        public string SiteWeb { get; set; }
    }
}
