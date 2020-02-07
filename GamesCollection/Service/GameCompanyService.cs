using GamesCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamesCollection.Service
{
    public class GameCompanyService
    {
        readonly ApplicationDbContext _db;

        public GameCompanyService(ApplicationDbContext db)
        {
            _db = db;
        }
    }
}
