using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDeskWebApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using static MegaDeskWebApp.Models.DeskQuote;

namespace MegaDeskWebApp.Pages.MegaDesk
{
    public class IndexModel : PageModel
    {
        private readonly MegaDeskWebApp.Models.MegaDeskWebAppContext _context;

        public IndexModel(MegaDeskWebApp.Models.MegaDeskWebAppContext context)
        {
            _context = context;
        }

        public IList<DeskQuote> DeskQuote { get;set; }
        public string SearchString { get; set; }
        public SelectList Quotes { get; set; }
        public string QuoteName { get; set; }


        public async Task OnGetAsync(string quoteName, string searchString)
        {
            // Use LINQ to get list of genres.
            IQueryable<DeskMaterial>recordQuery = from MegaDesk in _context.DeskQuote
                              orderby MegaDesk.CustName
                              select MegaDesk.Material;

            var records = from MegaDesk in _context.DeskQuote
                          select MegaDesk;

            if (!String.IsNullOrEmpty(searchString))
            {
                records = records.Where(s => s.CustName.Contains(searchString));
            }

            if (!String.IsNullOrEmpty(quoteName))
            {
                records = records.Where(x => x.Material.ToString() == quoteName);
            }
            Quotes = new SelectList(await recordQuery.Distinct().ToListAsync());
            DeskQuote = await records.ToListAsync();
            SearchString = searchString;
        }
    }
}

