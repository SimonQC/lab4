using Lab4A.BLL.Domaine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4A.Models
{
    public class UtilisateurViewModel
    {
        public List<Couleur> ChoixCouleurs { get; set; }

        [Display(Name = "Prénom")]
        public string Prenom { get; set; }

        [Display(Name = "Nom")]
        public string Nom { get; set; }

        [Display(Name = "Courriel")]
        public string Courriel { get; set; }

        [Display(Name = "Mot de passe")]
        public string MotDePasse { get; set; }

        [Display(Name = "Date de naissance")]
        public DateTime DateDeNaissance { get; set; } = DateTime.Now;

        [Display(Name = "Je suis un homme")]
        public bool Homme { get; set; }

        [Display(Name = "Téléphone")]
        public string Telephone { get; set; }

        [Display(Name = "Adresse - Numéro civique")]
        public int? NumCivique { get; set; } = 1;

        [Display(Name = "Adresse - Nom de rue")]
        public string Rue { get; set; }

        [Display(Name = "Numéro de carte de crédit")]
        public string NumCarteCredit { get; set; }

        [Display(Name = "Couleur préférée")]
        public Couleur CouleurPreferee { get; set; }

        [Display(Name = "URL de votre site Web")]
        public string SiteWeb { get; set; }
    }
}
