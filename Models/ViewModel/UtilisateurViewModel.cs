using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4A.Models
{
    public class UtilisateurViewModel
    {
        public List<Couleur> ChoixCouleurs { get; set; }

        [Display(Name = "Prénom")]
        [Required]
        public string Prenom { get; set; }

        [Required]
        [Display(Name = "Nom")]
        public string Nom { get; set; }

        [Required]
        [Display(Name = "Courriel")]
        public string Courriel { get; set; }

        [Required]
        [Display(Name = "Mot de passe")]
        public string MotDePasse { get; set; }

        [Required]
        [Display(Name = "Date de naissance")]
        public DateTime DateDeNaissance { get; set; } = DateTime.Now;

        [Required]
        [Display(Name = "Je suis un homme")]
        public bool Homme { get; set; }

        [Required]
        [Display(Name = "Téléphone")]
        public string Telephone { get; set; }

        [Required]
        [Display(Name = "Adresse - Numéro civique")]
        public int? NumCivique { get; set; } = 1;

        [Required]
        [Display(Name = "Adresse - Nom de rue")]
        public string Rue { get; set; }

        [Required]
        [Display(Name = "Numéro de carte de crédit")]
        public string NumCarteCredit { get; set; }

        [Required]
        [Display(Name = "Couleur préférée")]
        public Couleur CouleurPreferee { get; set; }

        [Required]
        [Display(Name = "URL de votre site Web")]
        public string SiteWeb { get; set; }
    }
}
