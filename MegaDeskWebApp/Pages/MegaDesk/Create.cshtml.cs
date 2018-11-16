using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MegaDeskWebApp.Models;
using static MegaDeskWebApp.Models.DeskQuote;
using Microsoft.EntityFrameworkCore;

namespace MegaDeskWebApp.Pages.MegaDesk
{
    public class CreateModel : PageModel
    {
        private readonly MegaDeskWebApp.Models.MegaDeskWebAppContext _context;

        public CreateModel(MegaDeskWebApp.Models.MegaDeskWebAppContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public DeskQuote DeskQuote { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // call Quote Total Function from model
            DeskQuote.DeskQuoteDate = DateTime.Now;
            DeskQuote.CalculateQuote();

            _context.DeskQuote.Add(DeskQuote);
            await _context.SaveChangesAsync();

            return RedirectToPage("../Index");
        }
    }
}