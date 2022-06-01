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
            StoreChargingPointInDb(chargingPoint);

            return chargingPoint.Id;
        }

        public void DeleteChargingPoint(int id)
        {
            if (!ChargingPointExists(id))
                throw new ResourceNotFoundException("Could not find specified charging point");

            ChargingPoint chargingPoint = Context.Set<ChargingPoint>().AsNoTracking().Where(c => c.Id == id).FirstOrDefault();

            DeleteChargingPointFromDb(chargingPoint);
        }

        private bool ChargingPointExists(int id)
        {
            ChargingPoint chargingPoint = Context.Set<ChargingPoint>().AsNoTracking().Where(c => c.Id == id).FirstOrDefault();
            return chargingPoint != null;
        }

        private void StoreChargingPointInDb(ChargingPoint chargingPoint)
        {
            using (var transaction = Context.Database.BeginTransaction())
            {

                Region region = Context.Set<Region>().Where(r => r.Id == chargingPoint.RegionId).FirstOrDefault();
                chargingPoint.Region = region;

                Context.Set<ChargingPoint>().Add(chargingPoint);

                Context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT NaturalUruguayDB.dbo.ChargingPoints ON;");
                Context.SaveChanges();
                Context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT NaturalUruguayDB.dbo.ChargingPoints OFF;");
                transaction.Commit();
            }

        }

        private void DeleteChargingPointFromDb(ChargingPoint chargingPoint)
        {
            Context.Set<ChargingPoint>().Remove(chargingPoint);

            Context.SaveChanges();
        }

        public ChargingPoint GetChargingPointById(int id)
        {
            ChargingPoint point = Context.Set<ChargingPoint>().Where(r => r.Id == id).FirstOrDefault();
            return point;
        }
    }
}