using System;
using System.Collections.Generic;
using System.Text;
using MinTur.Domain.BusinessEntities;

namespace MinTur.Models.In
{
    public class ChargingPointIntentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }

        public int TouristPointId { get; set; }

        public string Description { get; set; }

        public ChargingPoint ToEntity()
        {
            return new ChargingPoint()
            {
                Id = Id,
                Name = Name,
                Address = Address,
                Description = Description,
                TouristPoint = new TouristPoint() { Id = TouristPointId },
            };
        }
    }
}
