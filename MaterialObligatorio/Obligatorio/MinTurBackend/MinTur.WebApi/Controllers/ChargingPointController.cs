using MinTur.BusinessLogicInterface.ResourceManagers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using MinTur.Models.In;
using MinTur.Models.Out;

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

        [HttpDelete("{id:int}")]
        public IActionResult DeleteChargingPoint(int id)
        {
            _chargingPointManager.DeleteChargingPointById(id);
            return Ok(new { ResultMessage = $"Charging point {id} succesfully deleted" });
        }
    }
}
