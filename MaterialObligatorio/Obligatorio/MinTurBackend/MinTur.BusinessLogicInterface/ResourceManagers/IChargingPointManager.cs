using System;
using System.Collections.Generic;
using MinTur.Domain.BusinessEntities;
using MinTur.Domain.Reports;

namespace MinTur.BusinessLogicInterface.ResourceManagers
{
    public interface IChargingPointManager
    {
        int RegisterChargingPoint(ChargingPoint chargingPoint);
        void DeleteChargingPointById(int id);
    }
}