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
    public class IngresarBecadoModel : PageModel
    {
        private readonly IBecadoRepository _becadoRepository;

        public IngresarBecadoModel(IBecadoRepository becadoRepository)
        {
            _becadoRepository = becadoRepository;
        }

        [BindProperty]
        public Becado Becado { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _becadoRepository.Insert(Becado);

            return RedirectToPage("./Becados");
        }
    }
}
