using MinTur.Domain.BusinessEntities;
using System;

namespace MinTur.Models.Out
{
    public class ChargingPointConfirmationModel
    {
        public string UniqueCode { get; set; }

        public ChargingPointConfirmationModel(ChargingPoint chargingPoint) 
        {
            UniqueCode = chargingPoint.Id.ToString();
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(UniqueCode);
        }

    }
}
