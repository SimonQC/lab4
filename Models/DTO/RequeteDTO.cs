using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4A.Models
{
    public class RequeteDTO
    {
        [Required]
        public Guid? Id { get; set; }

        public List<Couleur> ChoixCouleurs { get; set; }

        [Required]
        [StringLength(45)]
        public string Prenom { get; set; }

        [Required]
        [StringLength(45)]
        public string Nom { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(45)]
        public string Courriel { get; set; }

        [Required]
        [StringLength(45)]
        public string MotDePasse { get; set; }

		[Required]
		public string DateDeNaissance { get; set; }

        [Required]
        public bool Homme { get; set; }

        [Required]
        [Phone]
        public string Telephone { get; set; }

        [Required]
        public int? NumCivique { get; set; } = 1;

        [Required]
        [StringLength(45)]
        public string Rue { get; set; }

        [Required]
        [CreditCard]
        [StringLength(45)]
        public string NumCarteCredit { get; set; }

        [Required]
        [Range(0, 9)]
        public Couleur CouleurPreferee { get; set; }

        [Required]
        [Url]
        [StringLength(45)]
        public string SiteWeb { get; set; }

		[Required]
		[StringLength(45)]
		public string PrenomConnexion { get; set; }

		[Required]
		[StringLength(45)]
		public string NomConnexion { get; set; }

		[Required]
		[StringLength(45)]
		public string MdpConnexion { get; set; }
	}
}
