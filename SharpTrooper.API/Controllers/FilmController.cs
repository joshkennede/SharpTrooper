using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharpTrooper.API.Filters;
using SharpTrooper.API.Manager;
using SharpTrooper.API.Models;

namespace SharpTrooper.API.Controllers
{
    [Route("api/films/")]
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
        [QueryParamFilter("search")]
        public async Task<SharpEntityResults<Film>> GetAllFilms(string pageNumber = "1", string? search = null)
        {
            var result = await servicesManager.GetAllFilms(pageNumber);
            return result;
        }

        [HttpOptions]
        [Route("schema/")]
        public async Task<Schema> GetFilmsSchema()
        {
            var result = await servicesManager.GetFilmsSchema();
            return result;
        }
    }
}
