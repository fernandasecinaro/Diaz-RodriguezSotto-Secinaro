using System;
using System.Collections.Generic;
using MinTur.Domain.BusinessEntities;

namespace MinTur.DataAccessInterface.Repositories
{
    public interface IChargingPointRepository
    {
        int StoreChargingPoint(ChargingPoint chargingPoint);
        void DeleteChargingPoint(int id);
    }
}