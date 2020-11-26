using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Lab4A.Models;
/*
	Réponses aux questions :

	#6 : Un service web n'est généralement pas utilisé depuis un navigateur web,
		 ce qui rend l'affichage d'une page inutile. Il serait mieux de retourner
		 un code d'erreur http approprié.
 
 
	#7 : Actuellement, les mots de passe sont stockés en clair directement dans 
         la base de données. Une solution à ce problème serait de les hasher avant
		 de les enregistrer dans la base de données.
 
 
 */
namespace Lab4A.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
