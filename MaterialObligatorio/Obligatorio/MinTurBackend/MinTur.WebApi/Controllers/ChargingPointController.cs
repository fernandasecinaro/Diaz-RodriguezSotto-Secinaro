using System;
using System.Collections.Generic;
using System.Linq;
using MinTur.BusinessLogicInterface.ResourceManagers;
using MinTur.Domain.BusinessEntities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using MinTur.Models.In;
using MinTur.Models.Out;
using MinTur.WebApi.Filters;
using MinTur.Domain.Reports;

namespace MinTur.WebApi.Controllers
{
    [EnableCors("AllowEverything")]
    [Route("api/chargingPoints")]
    [ApiController]
    public class ChargingPointController : ControllerBase
    {
        private readonly IChargingPointManager _chargingPointManager;

        public ChargingPointController(IChargingPointManager chargingPointManager)
        {
            _chargingPointManager = chargingPointManager;
        }

        [HttpPost]
        public IActionResult MakeChargingPoint([FromBody] ChargingPointIntentModel chargingPointIntentModel)
        {
            int createdChargingPoint = _chargingPointManager.RegisterChargingPoint(chargingPointIntentModel.ToEntity());
            ChargingPointConfirmationModel confirmation = new ChargingPointConfirmationModel(createdChargingPoint);
            return Ok(confirmation);
        }
    }
}
