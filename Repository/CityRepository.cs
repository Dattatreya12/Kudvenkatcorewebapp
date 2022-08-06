using Kudvenkatcorewebapp.DBContext;
using Kudvenkatcorewebapp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kudvenkatcorewebapp.Repository
{
    public class CityRepository:Icity
    {
       // private readonly Icity _icity;
        private readonly AppDbContext _appDbContext;
        public IConfiguration _Configuration { get; }

        public CityRepository(AppDbContext appDbContext,IConfiguration configuration)
        {
            //this._icity = icity;
            this._appDbContext = appDbContext;
            _Configuration = configuration;
        }

        public async Task<List<CityMaster>> GetCities()
        {
            return await _appDbContext.CityMasters.Select(x => new CityMaster()
            {
                ID = x.ID,
                CityName = x.CityName
            }).ToListAsync();
        }
    }
}
