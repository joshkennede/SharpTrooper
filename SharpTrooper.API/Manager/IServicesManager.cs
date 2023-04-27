using SharpTrooper.API.Models;

namespace SharpTrooper.API.Manager
{
    public interface IServicesManager
    {
        // People
        /// <summary>
        /// get a specific people resource
        /// </summary>
        public People GetPeople(string id);

        /// <summary>
        /// get all the people resources
        /// </summary>
        public SharpEntityResults<People> GetAllPeople(string pageNumber = "1");

        // Film
        /// <summary>
        /// get a specific film resource
        /// </summary>
        public Film GetFilm(string id);

        /// <summary>
        /// get all the film resources
        /// </summary>
        public SharpEntityResults<Film> GetAllFilms(string pageNumber = "1");

        // Planet
        /// <summary>
        /// get a specific planet resource
        /// </summary>
        public Planet GetPlanet(string id);

        /// <summary>
        /// get all the planet resources
        /// </summary>
        public SharpEntityResults<Planet> GetAllPlanets(string pageNumber = "1");

        // Specie
        /// <summary>
        /// get a specific specie resource
        /// </summary>
        public Specie GetSpecie(string id);

        /// <summary>
        /// get all the specie resources
        /// </summary>
        public SharpEntityResults<Specie> GetAllSpecies(string pageNumber = "1");

        // Starship
        /// <summary>
        /// get a specific starship resource
        /// </summary>
        public Starship GetStarship(string id);

        /// <summary>
        /// get all the starship resources
        /// </summary>
        public SharpEntityResults<Starship> GetAllStarships(string pageNumber = "1");

        // Vehicle
        /// <summary>
        /// get a specific vehicle resource
        /// </summary>
        public Vehicle GetVehicle(string id);

        /// <summary>
        /// get all the vehicle resources
        /// </summary>
        public SharpEntityResults<Vehicle> GetAllVehicles(string pageNumber = "1");
    }
}
