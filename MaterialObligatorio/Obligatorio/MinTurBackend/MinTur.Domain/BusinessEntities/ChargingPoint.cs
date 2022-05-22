using System;
using System.Collections.Generic;
using System.Text;

namespace MinTur.Domain.BusinessEntities
{
    public class ChargingPoint
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }

        public TouristPoint TouristPoint { get; set; }

        public string Description { get; set; }
    }
}
