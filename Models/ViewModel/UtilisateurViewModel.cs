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
        [StringLength(45)]
        public string Prenom { get; set; }

        [Required]
        [Display(Name = "Nom")]
        [StringLength(45)]
        public string Nom { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(45)]
        [Display(Name = "Courriel")]
        public string Courriel { get; set; }

        [Required]
        [StringLength(45)]
        [Display(Name = "Mot de passe")]
        public string MotDePasse { get; set; }

        [Required]
        [Display(Name = "Date de naissance")]
        public DateTime DateDeNaissance { get; set; } = DateTime.Now;

        [Display(Name = "Je suis un homme")]
        public bool Homme { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Téléphone")]
        public string Telephone { get; set; }

        [Required]
        [Display(Name = "Adresse - Numéro civique")]
        public int? NumCivique { get; set; } = 1;

        [Required]
        [StringLength(45)]
        [Display(Name = "Adresse - Nom de rue")]
        public string Rue { get; set; }

        [Required]
        [CreditCard]
        [StringLength(45)]
        [Display(Name = "Numéro de carte de crédit")]
        public string NumCarteCredit { get; set; }

        [Required]
        [Range(0,9)]
        [Display(Name = "Couleur préférée")]
        public Couleur CouleurPreferee { get; set; }

        [Required]
        [Url]
        [StringLength(45)]
        [Display(Name = "URL de votre site Web")]
        public string SiteWeb { get; set; }

		[Required]
		[EmailAddress]
		[StringLength(45)]
		[Display(Name = "Courriel administrateur")]
		public string CourrielAdmin { get; set; }

		[Required]
		[StringLength(45)]
		[Display(Name = "Mot de passe administrateur")]
		public string MotDePasseAdmin { get; set; }


		[Display(Name = "Lancer exception")]
		public bool erreur { get; set; }
	}
}
