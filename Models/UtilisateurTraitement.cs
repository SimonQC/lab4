using Lab4A.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4A.Models
{
	public class UtilisateurTraitement
	{
		private Lab4Contexte _contexte;

		public UtilisateurTraitement(Lab4Contexte contexte)
		{
			_contexte = contexte;
		}

		public void SauvegarderUtilisateur(Utilisateur utilisateur)
		{
			_contexte.Utilisateur.Add(utilisateur);

			_contexte.SaveChanges();

		}

		public Utilisateur DTOaUtilisateur(RequeteDTO requeteDTO)
		{

			Utilisateur utilisateur = new Utilisateur();
			utilisateur.IdUtilisateur = requeteDTO.Id;
			utilisateur.Prenom = requeteDTO.Prenom;
			utilisateur.Nom = requeteDTO.Nom;
			utilisateur.Courriel = requeteDTO.Courriel;
			utilisateur.MotDePasse = requeteDTO.MotDePasse;
			utilisateur.DateDeNaissance = requeteDTO.DateDeNaissance;
			utilisateur.Homme = requeteDTO.Homme;
			utilisateur.Telephone = requeteDTO.Telephone;
			utilisateur.NumCivique = requeteDTO.NumCivique;
			utilisateur.Rue = requeteDTO.Rue;
			utilisateur.NumCarteCredit = requeteDTO.NumCarteCredit;
			utilisateur.CouleurPreferee = (Couleur?)requeteDTO.CouleurPreferee;
			utilisateur.SiteWeb = requeteDTO.SiteWeb;

			return utilisateur;

		}

		public Utilisateur ViewModelAUtilisateur(UtilisateurViewModel modele){

			Utilisateur utilisateur = new Utilisateur();

			utilisateur.IdUtilisateur = new Guid();
			utilisateur.Prenom = modele.Prenom;
			utilisateur.Nom = modele.Nom;
			utilisateur.Courriel = modele.Courriel;
			utilisateur.MotDePasse = modele.MotDePasse;
			utilisateur.DateDeNaissance = modele.DateDeNaissance;
			utilisateur.Homme = modele.Homme;
			utilisateur.Telephone = modele.Telephone;
			utilisateur.NumCivique = modele.NumCivique;
			utilisateur.Rue = modele.Rue;
			utilisateur.NumCarteCredit = modele.NumCarteCredit;
			utilisateur.CouleurPreferee = modele.CouleurPreferee;
			utilisateur.SiteWeb = modele.SiteWeb;

			return utilisateur;
		}
	}
		
}
