using Microsoft.EntityFrameworkCore;
using MinTur.DataAccessInterface.Repositories;
using MinTur.Domain.BusinessEntities;
using System.Collections.Generic;
using System.Linq;
using MinTur.Exceptions;
using System;

namespace MinTur.DataAccess.Repositories
{
    public class RegionRepository : IRegionRepository
    {
        protected DbContext Context { get; set; }

        public RegionRepository(DbContext dbContext)
        {
            Context = dbContext;
        }

        public List<Region> GetAllRegions()
        {
            return Context.Set<Region>().Include(r => r.TouristPoints).ToList();
        }

        public Region GetRegionById(int regionId)
        {
            Region retrievedRegion =  Context.Set<Region>().Where(r => r.Id == regionId).FirstOrDefault();

            if (retrievedRegion == null)
                throw new ResourceNotFoundException("Región Inválida");

            return retrievedRegion;
        }
    }
}
