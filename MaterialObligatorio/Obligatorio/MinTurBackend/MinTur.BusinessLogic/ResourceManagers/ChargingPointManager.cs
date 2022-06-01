using MinTur.BusinessLogicInterface.ResourceManagers;
using MinTur.DataAccessInterface.Facades;
using MinTur.Domain.BusinessEntities;
using MinTur.Exceptions;

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
            Region _ = _repositoryFacade.GetRegionById(chargingPoint.RegionId);
            ChargingPoint point = _repositoryFacade.GetChargingPointById(chargingPoint.Id);

            if (point != null)
            {
                throw new InvalidRequestDataException("El id ya está registrado");
            }

            int newChargingPointId = _repositoryFacade.StoreChargingPoint(chargingPoint);

            return newChargingPointId;
        }

        public void DeleteChargingPointById(int id)
        {
            _repositoryFacade.DeleteChargingPoint(id);
        }
    }
}