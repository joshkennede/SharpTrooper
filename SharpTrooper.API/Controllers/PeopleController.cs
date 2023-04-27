using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharpTrooper.API.Manager;
using SharpTrooper.API.Models;

namespace SharpTrooper.API.Controllers
{
    [Route("api/people/")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly IServicesManager servicesManager;

        public PeopleController(IServicesManager servicesManager)
        {
            this.servicesManager = servicesManager;
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<People> GetPerson(int id)
        {
            var result = await servicesManager.GetPeople(id.ToString());
            return result;
        }

        [HttpGet]
        public async Task<SharpEntityResults<People>> GetAllPeople([FromQuery]string pageNumber)
        {
            var result = await servicesManager.GetAllPeople(pageNumber);
            return result;
        }
    }
}
