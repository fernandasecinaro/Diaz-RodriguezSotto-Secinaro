using System;
using System.Collections.Generic;
using MinTur.Domain.BusinessEntities;

namespace MinTur.DataAccessInterface.Repositories
{
    public interface IChargingPointRepository
    {
        ChargingPoint GetChargingPoint(int id);
        int StoreChargingPoint(ChargingPoint chargingPoint);
        void DeleteChargingPoint(ChargingPoint chargingPoint);
    }
}