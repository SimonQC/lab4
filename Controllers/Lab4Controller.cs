using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Lab4A.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            TestSauvegarderUtilisateur();
            UtilisateurViewModel modele = new UtilisateurViewModel();
            return View(modele);
        }

        [HttpPost]
        public IActionResult SauvegarderUtilisateur(UtilisateurViewModel modele)
        {
            if (modele.erreur)
            {
                Exception exception = new Exception("Test d'erreur");
                Log(exception);
                throw exception;
            }
            if (ModelState.IsValid)
            {

                List<Utilisateur> utilisateurs = contexte.Utilisateurs.ToList();

                if (utilisateurs.Any(utilisateur => utilisateur.Courriel == modele.CourrielAdmin && utilisateur.MotDePasse == modele.MotDePasseAdmin))
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
                        TempData["Message"] = "Erreur de sauvegarde";
                        TempData["MessageStyle"] = "background-color: red;color: white;";
                    }

                }
                else
                {
                    TempData["Message"] = "Autorisation refuse";
                    TempData["MessageStyle"] = "background-color: red;color: white;";
                }


                // On retourne à la vue initiale
                return View("CreerUtilisateur", modele);
            }
            else
            {

                var modelErrors = "";
                foreach (var modelstate in ModelState.Values)
                {
                    foreach (var modelError in modelstate.Errors)
                    {
                        modelErrors = modelErrors + modelError.ErrorMessage;
                    }
                }


                TempData["Message"] = modelErrors;
                TempData["MessageStyle"] = "background-color: red;color: white;";


                // On retourne à la vue initiale
                return View("CreerUtilisateur", modele);
            }

        }

        private void Log(Exception exception)
        {
            string path = DateTime.Today.ToShortDateString();
            string id = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            using (StreamWriter sw = System.IO.File.AppendText("Log/" + path + ".log"))
            {
                sw.WriteLine(DateTime.Now.ToShortTimeString() + " : " + id + " : " + exception.Message);
            }
        }



        [TestMethod]
        private void TestSauvegarderUtilisateur()
        {
            UtilisateurViewModel modele = new UtilisateurViewModel();

            modele.Prenom = "Simon";
            modele.Nom = "Belliveau";
            modele.Courriel = "courriel@courriel.com";
            modele.MotDePasse = "Admin123%";
            modele.DateDeNaissance = DateTime.Today;
            modele.Homme = false;
            modele.Telephone = "1111111111";
            modele.NumCivique = 1;
            modele.Rue = "Patate";
            modele.NumCarteCredit = "4485230129808928";
            modele.CouleurPreferee = Couleur.Blanc;
            modele.SiteWeb = "http://test.com";
            modele.CourrielAdmin = "admin@admin.com";
            modele.MotDePasseAdmin = "Admin123$%";
            modele.erreur = false;

            List<Utilisateur> utilisateurs = contexte.Utilisateurs.ToList();


            if (utilisateurs.Any(utilisateur => utilisateur.Courriel == modele.CourrielAdmin && utilisateur.MotDePasse == modele.MotDePasseAdmin && utilisateur.DateDeNaissance == modele.DateDeNaissance))
            {
                SauvegarderUtilisateur(modele);
                TempData["Message"] = "";
                TempData["MessageStyle"] = "";
            }

            utilisateurs = contexte.Utilisateurs.ToList();


            Assert.IsTrue(utilisateurs.Any(utilisateur => modele.Prenom == utilisateur.Prenom &&
                                               modele.Nom == utilisateur.Nom &&
                                               modele.Courriel == utilisateur.Courriel &&
                                               modele.MotDePasse == utilisateur.MotDePasse &&
                                               modele.DateDeNaissance == utilisateur.DateDeNaissance &&
                                               modele.Homme == utilisateur.Homme &&
                                               modele.Telephone == utilisateur.Telephone &&
                                               modele.NumCivique == utilisateur.NumCivique &&
                                               modele.Rue == utilisateur.Rue &&
                                               modele.NumCarteCredit == utilisateur.NumCarteCredit &&
                                               modele.CouleurPreferee == utilisateur.CouleurPreferee &&
                                               modele.SiteWeb == utilisateur.SiteWeb));
		}

    }
}
