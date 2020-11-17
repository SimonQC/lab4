using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4A.BLL.Domaine
{
    public enum Couleur
    {
        Bleu = 0, Jaune = 1, Rouge = 2, Orange = 3, Vert = 4, Violet = 5, Blanc = 6, Noir = 7, Gris = 8, Brun = 9 
    }

    public class Utilisateur
    {
        public Guid? IdUtilisateur { get; set; }
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
        public Couleur? CouleurPreferee { get; set; }
        public string SiteWeb { get; set; }
    }
}
