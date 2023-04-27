using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharpTrooper.API.Manager;
using SharpTrooper.API.Models;

namespace SharpTrooper.API.Controllers
{
    [Route("api/film/")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        private readonly IServicesManager servicesManager;

        public FilmController(IServicesManager servicesManager)
        {
            this.servicesManager = servicesManager;
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<Film> GetFilm(int id)
        {
            var result = await servicesManager.GetFilm(id.ToString());
            return result;
        }

        [HttpGet]
        [Route("{pageNumber}")]
        public async Task<SharpEntityResults<Film>> GetAllPeople(string pageNumber)
        {
            var result = await servicesManager.GetAllFilms(pageNumber);
            return result;
        }
    }
}
