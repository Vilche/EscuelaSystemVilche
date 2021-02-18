using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EscuelaSystem.Data.Interfaces;
using EscuelaSystem.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EscuelaSystem.Web.Pages
{
    public class BecadosModel : PageModel
    {
        private readonly IBecadoRepository _becadoRepository;

        public BecadosModel(IBecadoRepository BecadoRepository)
        {
            _becadoRepository = BecadoRepository;
        }

        [BindProperty]
        public IEnumerable<Becado> Becados { get; set; }

        public IActionResult OnGet()
        {
            Becados = _becadoRepository.List();
            return Page();
        }
    }
}
