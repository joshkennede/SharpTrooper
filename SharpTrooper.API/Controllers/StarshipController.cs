using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharpTrooper.API.Manager;
using SharpTrooper.API.Models;

namespace SharpTrooper.API.Controllers
{
    [Route("api/starships/")]
    [ApiController]
    public class StarshipController : ControllerBase
    {
		private readonly IServicesManager servicesManager;

		public StarshipController(IServicesManager servicesManager)
		{
			this.servicesManager = servicesManager;
		}

		[HttpGet]
		[Route("{id:int}")]
		public async Task<Starship> GetStarship(int id)
		{
			var result = await servicesManager.GetStarship(id.ToString());
			return result;
		}

		[HttpGet]
		public async Task<SharpEntityResults<Starship>> GetAllStarships([FromQuery]string pageNumber)
		{
			var result = await servicesManager.GetAllStarships(pageNumber);
			return result;
		}

		[HttpOptions]
		[Route("schema/")]
		public async Task<Schema> GetStarshipsSchema()
		{
			var result = await servicesManager.GetStarshipsSchema();
			return result;
		}
	}
}
