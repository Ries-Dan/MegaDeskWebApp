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

        public string NameSort { get; set; }
        public string DateSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }

        public IList<DeskQuote> DeskQuote { get;set; }
        public string SearchString { get; set; }
        public SelectList Quotes { get; set; }
        public string QuoteName { get; set; }


        public async Task OnGetAsync(string quoteName, string searchString, string sortOrder)
        {
            // Use LINQ to get list of genres.
            IQueryable<DeskMaterial>recordQuery = from MegaDesk in _context.DeskQuote
                              orderby MegaDesk.CustName
                              select MegaDesk.Material;

            var records = from MegaDesk in _context.DeskQuote
                          select MegaDesk;

            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";

            IQueryable<DeskQuote> quoteIQ = from s in _context.DeskQuote
                                            select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                records = records.Where(s => s.CustName.Contains(searchString));
            }

            if (!String.IsNullOrEmpty(quoteName))
            {
                records = records.Where(x => x.Material.ToString() == quoteName);
            }

            switch (sortOrder)
            {
                case "name_desc":
                    quoteIQ = quoteIQ.OrderByDescending(s => s.CustName);
                    break;
                case "Date":
                    quoteIQ = quoteIQ.OrderBy(s => s.DeskQuoteDate);
                    break;
                case "date_desc":
                    quoteIQ = quoteIQ.OrderByDescending(s => s.DeskQuoteDate);
                    break;
                default:
                    quoteIQ = quoteIQ.OrderBy(s => s.CustName);
                    break;
            }

            
            Quotes = new SelectList(await recordQuery.Distinct().ToListAsync());
            if (!String.IsNullOrEmpty(sortOrder))
            {
                DeskQuote = await quoteIQ.AsNoTracking().ToListAsync();
            }
            else
            {
                DeskQuote = await records.ToListAsync();
            }
            //DeskQuote = await records.ToListAsync();
            //DeskQuote = await quoteIQ.AsNoTracking().ToListAsync();
            SearchString = searchString;
        }
    }
}

