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

        public ChargingPoint GetChargingPoint(int id)
        {
            if (!ChargingPointExists(id))
                throw new ResourceNotFoundException("Could not find specified charging point");

            return Context.Set<ChargingPoint>().AsNoTracking().Where(c => c.Id == id).FirstOrDefault();
        }

        public void DeleteChargingPoint(ChargingPoint chargingPoint)
        {
            if (!ChargingPointExists(chargingPoint.Id))
                throw new ResourceNotFoundException("Could not find specified charging point");

            DeleteChargingPointFromDb(chargingPoint);
        }

        private bool TouristPointExists(int touristPointId)
        {
            TouristPoint touristPoint = Context.Set<TouristPoint>().AsNoTracking().Where(r => r.Id == touristPointId).FirstOrDefault();
            return touristPoint != null;
        }

        private bool ChargingPointExists(int id)
        {
            ChargingPoint chargingPoint = Context.Set<ChargingPoint>().AsNoTracking().Where(c => c.Id == id).FirstOrDefault();
            return chargingPoint != null;
        }

        private void StoreChargingPointInDb(ChargingPoint chargingPoint)
        {
            Context.Set<ChargingPoint>().Add(chargingPoint);

            Context.SaveChanges();
        }

        private void DeleteChargingPointFromDb(ChargingPoint chargingPoint)
        {
            Context.Set<ChargingPoint>().Remove(chargingPoint);

            Context.SaveChanges();
        }
    }
}