using SharpTrooper.API.Models;

namespace SharpTrooper.API.Manager
{
    public interface IServicesManager
    {
        // People
        /// <summary>
        /// get a specific people resource
        /// </summary>
        public Task<People> GetPeople(string id);

        /// <summary>
        /// get all the people resources
        /// </summary>
        public Task<SharpEntityResults<People>> GetAllPeople(string pageNumber = "1");

        // Film
        /// <summary>
        /// get a specific film resource
        /// </summary>
        public Task<Film> GetFilm(string id);

        /// <summary>
        /// get all the film resources
        /// </summary>
        public Task<SharpEntityResults<Film>> GetAllFilms(string pageNumber = "1");

        // Planet
        /// <summary>
        /// get a specific planet resource
        /// </summary>
        public Task<Planet> GetPlanet(string id);

        /// <summary>
        /// get all the planet resources
        /// </summary>
        public Task<SharpEntityResults<Planet>> GetAllPlanets(string pageNumber = "1");

        // Specie
        /// <summary>
        /// get a specific specie resource
        /// </summary>
        public Task<Specie> GetSpecie(string id);

        /// <summary>
        /// get all the specie resources
        /// </summary>
        public Task<SharpEntityResults<Specie>> GetAllSpecies(string pageNumber = "1");

        // Starship
        /// <summary>
        /// get a specific starship resource
        /// </summary>
        public Task<Starship> GetStarship(string id);

        /// <summary>
        /// get all the starship resources
        /// </summary>
        public Task<SharpEntityResults<Starship>> GetAllStarships(string pageNumber = "1");

        // Vehicle
        /// <summary>
        /// get a specific vehicle resource
        /// </summary>
        public Task<Vehicle> GetVehicle(string id);

        /// <summary>
        /// get all the vehicle resources
        /// </summary>
        public Task<SharpEntityResults<Vehicle>> GetAllVehicles(string pageNumber = "1");
    }
}
