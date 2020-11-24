using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab4A.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab4A.Controllers
{
    public class Lab4Controller : Controller
    {

        private readonly Lab4Contexte contexte;

        public Lab4Controller(Lab4Contexte contexte_)
        {
            contexte = contexte_;
        }

        public IActionResult CreerUtilisateur()
        {
            UtilisateurViewModel modele = new UtilisateurViewModel();
            return View(modele);
        }

        [HttpPost]
        public IActionResult SauvegarderUtilisateur(UtilisateurViewModel modele)
        {
            if (!ModelState.IsValid)
            {
                UtilisateurTraitement traitements = new UtilisateurTraitement(contexte);
                Utilisateur utilisateur = traitements.ViewModelAUtilisateur(modele);

                if (traitements.SauvegarderUtilisateur(utilisateur))
                {
                    TempData["Message"] = "l'utilisateur à été sauvegarder";
                    TempData["MessageStyle"] = "background-color: green;color: white;";
                }
                else
                {
                    TempData["Message"] = "";
                    TempData["MessageStyle"] = "background-color: red;color: white;";
                }


                // On retourne à la vue initiale
                return View("CreerUtilisateur", modele);
            }

            // On retourne à la vue initiale
            return View("CreerUtilisateur", modele);
        }

    }
}
