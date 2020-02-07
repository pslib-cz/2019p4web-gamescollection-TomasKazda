using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamesCollection.Models;
using GamesCollection.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace GamesCollection.Pages
{
    public class IndexModel : PageModel
    {
        private readonly GameCompanyService gs;

        public IList<Company> Companies { get; set; }
        public SelectList CountriesList { get; set; }
        public IndexModel(GameCompanyService gs)
        {
            this.gs = gs;
        }

        public void OnGet(string order, string search, string nameFilter, string countryFilter, int? ownerFilter = null)
        {
            CountriesList = new SelectList(new List<string> { 
                "CZ", "FR", "GE", "PL", "SE", "US"
            });
            //IQueryable<Company> companies = _context.Companies;
            Companies = new List<Company>();
        }
    }
}
