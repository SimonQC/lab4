using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Lab4A.Models;

namespace Lab4A.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequeteDTOController : ControllerBase
    {

		private Lab4Contexte contexte_;

        public RequeteDTOController(Lab4Contexte contexte)
        {
            contexte_ = contexte;
        }

        // POST: api/ApiDTO
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async void PostApiDTO(RequeteDTO requeteDTO)
        {

            UtilisateurTraitement traitements = new UtilisateurTraitement(contexte_);

            Utilisateur  utilisateur = traitements.DTOaUtilisateur(requeteDTO);        
            traitements.SauvegarderUtilisateur(utilisateur);

            //_context.ApiDTO.Add(requeteDTO);
            //await _context.SaveChangesAsync();

        }
    }
}
