using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharpTrooper.API.Manager;
using SharpTrooper.API.Models;

namespace SharpTrooper.API.Controllers
{
    [Route("api/vehicles/")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
		private readonly IServicesManager servicesManager;

		public VehicleController(IServicesManager servicesManager)
		{
			this.servicesManager = servicesManager;
		}

		[HttpGet]
		[Route("{id:int}")]
		public async Task<Vehicle> GetStarship(int id)
		{
			var result = await servicesManager.GetVehicle(id.ToString());
			return result;
		}

		[HttpGet]
		public async Task<SharpEntityResults<Vehicle>> GetAllVehicles([FromQuery]string pageNumber)
		{
			var result = await servicesManager.GetAllVehicles(pageNumber);
			return result;
		}

		[HttpOptions]
		[Route("schema/")]
		public async Task<Schema> GetVehiclesSchema()
		{
			var result = await servicesManager.GetVehiclesSchema();
			return result;
		}
    }
}
