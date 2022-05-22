using Microsoft.EntityFrameworkCore;
using MinTur.DataAccessInterface.Repositories;
using MinTur.Domain.BusinessEntities;
using System.Collections.Generic;
using System.Linq;
using MinTur.Exceptions;
using System;

namespace MinTur.DataAccess.Repositories
{
    public class ChargingPointRepository : IChargingPointRepository
    {
        protected DbContext Context { get; set; }

        public ChargingPointRepository(DbContext dbContext)
        {
            Context = dbContext;
        }

        public int StoreChargingPoint(ChargingPoint chargingPoint)
        {
            if (!TouristPointExists(chargingPoint.TouristPoint.Id))
                throw new ResourceNotFoundException("Could not find specified tourist point");

            StoreChargingPointInDb(chargingPoint);

            return chargingPoint.Id;
        }

        private bool TouristPointExists(int touristPointId)
        {
            TouristPoint touristPoint = Context.Set<TouristPoint>().AsNoTracking().Where(r => r.Id == touristPointId).FirstOrDefault();
            return touristPoint != null;
        }

        private void StoreChargingPointInDb(ChargingPoint chargingPoint)
        {
            using (var transaction = Context.Database.BeginTransaction())
            {

                TouristPoint touristPoint = Context.Set<TouristPoint>().Where(r => r.Id == chargingPoint.TouristPoint.Id).FirstOrDefault();
                chargingPoint.TouristPoint = touristPoint;

                Context.Set<ChargingPoint>().Add(chargingPoint);

                Context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT NaturalUruguayDB.dbo.ChargingPoints ON;");
                Context.SaveChanges();
                Context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT NaturalUruguayDB.dbo.ChargingPoints OFF;");
                transaction.Commit();
            }

        }
    }
}