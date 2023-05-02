using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharpTrooper.API.Manager;
using SharpTrooper.API.Models;

namespace SharpTrooper.API.Controllers
{
	[Route("api/species/")]
	[ApiController]
	public class SpecieController : ControllerBase
	{
		private readonly IServicesManager servicesManager;

		public SpecieController(IServicesManager servicesManger)
		{
			this.servicesManager = servicesManager;
		}

		[HttpGet]
		[Route("{id:int}")]
		public async Task<Specie> GetSpecie(int id)
		{
			var result = await servicesManager.GetSpecie(id.ToString());
			return result;
		}

		[HttpGet]
		public async Task<SharpEntityResults<Specie>> GetAllSpecies([FromQuery]string pageNumber)
		{
			var result = await servicesManager.GetAllSpecies(pageNumber);
			return result;
		}
	}
}
