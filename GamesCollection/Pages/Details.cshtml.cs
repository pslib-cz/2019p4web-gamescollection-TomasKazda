using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamesCollection.Models;
using GamesCollection.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GamesCollection
{
    public class DetailsModel : PageModel
    {
        private readonly GameCompanyService _gs;
        
        public DetailsModel(GameCompanyService gs)
        {
            _gs = gs;
        }
        public Company Company { get; set; }
        public void OnGet(int id)
        {
            Company = _gs.GetAllDataFromSingleCompany(id);
            if (Company == default) Company = new Company();
        }
    }
}