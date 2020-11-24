using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4A.Models.DTO
{
    public class ReponseDTO
    {
		public List<string> erreurs { get; set; } = new List<string>();
        public string Reussite { get; set; }
    }
}
