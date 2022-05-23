using System;
using System.Collections.Generic;
using MinTur.BusinessLogicInterface.Pricing;
using MinTur.BusinessLogicInterface.ResourceManagers;
using MinTur.DataAccessInterface.Facades;
using MinTur.Domain.BusinessEntities;
using MinTur.Domain.Reports;

namespace MinTur.BusinessLogic.ResourceManagers
{
    public class ChargingPointManager : IChargingPointManager
    {
        private readonly IRepositoryFacade _repositoryFacade;

        public ChargingPointManager(IRepositoryFacade repositoryFacade)
        {
            _repositoryFacade = repositoryFacade;
        }

        public int RegisterChargingPoint(ChargingPoint chargingPoint)
        {
            chargingPoint.ValidOrFail();
            TouristPoint relatedTouristPoint= _repositoryFacade.GetTouristPointById(chargingPoint.TouristPoint.Id);

            int newChargingPointId = _repositoryFacade.StoreChargingPoint(chargingPoint);

            return newChargingPointId;
        }
        public void DeleteChargingPointById(int id)
        {
            _repositoryFacade.DeleteChargingPoint(id);
        }
    }
}