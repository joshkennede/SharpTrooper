using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharpTrooper.API.Manager;
using SharpTrooper.API.Models;

namespace SharpTrooper.API.Controllers
{
	[Route("api/planet/")]
	[ApiController]
	public class PlanetController : ControllerBase
	{
		private readonly IServicesManager servicesManager;

		public PlanetController(IServicesManager servicesManager)
		{
			this.servicesManager = servicesManager;
		}

		[HttpGet]
		[Route("{id:int}")]
		public async Task<Planet> GetPlanet(int id)
		{
			var result = await servicesManager.GetPlanet(id.ToString());
			return result;
		}

		[HttpGet]
		public async Task<SharpEntityResults<Planet>> GetAllPlanets([FromQuery]string pageNumber)
		{
			var result = await servicesManager.GetAllPlanets(pageNumber);
			return result;
		}
	}
}
