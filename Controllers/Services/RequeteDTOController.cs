using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Lab4A.Models;
using Lab4A.Models.DTO;

namespace Lab4A.Controllers
{
    [Route("api/RequeteDTO")]
    [ApiController]
    public class RequeteDTOController : ControllerBase
    {

		Lab4Contexte contexte_;

        public RequeteDTOController(Lab4Contexte contexte)
        {
            contexte_ = contexte;
        }
        
        // POST: api/CreerUtilisateur
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public ReponseDTO CreerUtilisateur( RequeteDTO requeteDTO)
        {
            ReponseDTO reponse = new ReponseDTO();

            if (ModelState.IsValid)
            {
                UtilisateurTraitement traitements = new UtilisateurTraitement(contexte_);
				List<Utilisateur> utilisateurs = contexte_.Utilisateurs.ToList();

                if (utilisateurs.Any(utilisateur => utilisateur.Prenom == requeteDTO.PrenomConnexion && utilisateur.Nom == requeteDTO.NomConnexion && utilisateur.MotDePasse == requeteDTO.MdpConnexion))
                {
                    Utilisateur utilisateur = traitements.DTOaUtilisateur(requeteDTO);
                    if (!traitements.SauvegarderUtilisateur(utilisateur))
                    {
                        reponse.erreurs.Add("Erreur de la sauvegarde de l'utilisateur");
                    }
                    else
                    {

                        reponse.Reussite = "la sauvegarde de l'utilisateur a réussi";
                    }
                }
                else
                {
                    reponse.erreurs.Add("Autorisation refusé");
                }




			}
            else
            {
                var modelErrors = new List<string>();
                foreach(var modelstate in ModelState.Values)
                {
                    foreach (var modelError in modelstate.Errors)
                    {
                        modelErrors.Add(modelError.ErrorMessage);
                    }
                }
                reponse.erreurs = modelErrors;
            }

            return reponse;
        }

    }
}
