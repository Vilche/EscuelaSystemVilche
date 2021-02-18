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
    public class EditarBecadoModel : PageModel
    {
        private readonly IBecadoRepository _becadoRepository;

        public EditarBecadoModel(IBecadoRepository becadoRepository)
        {
            _becadoRepository = becadoRepository;
        }

        [BindProperty]
        public Becado Becado { get; set; }
        public IActionResult OnGet(int id)
        {
            Becado = _becadoRepository.GetbyId(id);
            if (Becado == null)
            {
                return NotFound();
            }
            return Page();
        }

        public IActionResult OnPost(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var becadoToUpdate = _becadoRepository.GetbyId(id);
            if (becadoToUpdate == null)
                return NotFound();

            becadoToUpdate.Codigo = Becado.Codigo;
            becadoToUpdate.Descripcion = Becado.Descripcion;
            becadoToUpdate.Inscrito = Becado.Inscrito;

            _becadoRepository.Update(becadoToUpdate);

            return RedirectToPage("./Becados");
        }
    }
}

