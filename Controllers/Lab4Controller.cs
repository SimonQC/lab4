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
            UtilisateurTraitement traitements = new UtilisateurTraitement(contexte);
            return View(modele);
        }

        [HttpPost]
        public IActionResult SauvegarderUtilisateur(UtilisateurViewModel modele)
        {
            UtilisateurTraitement traitements = new UtilisateurTraitement(contexte);

            // On retourne à la vue initiale
            return View("CreerUtilisateur", modele);
        }

    }
}
