using SharpTrooper.API.Models;

namespace SharpTrooper.API.Manager
{
    public interface IServicesManager
    {
        /// People
        /// <summary>
        /// get a specific people resource
        /// </summary>
        Task<People> GetPeople(string id);

        /// <summary>
        /// get all the people resources
        /// </summary>
        Task<SharpEntityResults<People>> GetAllPeople(string pageNumber = "1");

        /// <summary>
        /// get people schema
        /// </summary>
        Task<Schema> GetPeopleSchema();

        /// Film
        /// <summary>
        /// get a specific film resource
        /// </summary>
        Task<Film> GetFilm(string id);

        /// <summary>
        /// get all the film resources
        /// </summary>
        Task<SharpEntityResults<Film>> GetAllFilms(string pageNumber = "1");

        /// <summary>
        /// get films schema
        /// </summary>
        Task<Schema> GetFilmsSchema();

        /// Planet
        /// <summary>
        /// get a specific planet resource
        /// </summary>
        Task<Planet> GetPlanet(string id);

        /// <summary>
        /// get all the planet resources
        /// </summary>
        Task<SharpEntityResults<Planet>> GetAllPlanets(string pageNumber = "1");

        /// <summary>
        /// get planets schema
        /// </summary>
        Task<Schema> GetPlanetsSchema();

        /// Specie
        /// <summary>
        /// get a specific specie resource
        /// </summary>
        Task<Specie> GetSpecie(string id);

        /// <summary>
        /// get all the specie resources
        /// </summary>
        Task<SharpEntityResults<Specie>> GetAllSpecies(string pageNumber = "1");

        /// <summary>
        /// get species schema
        /// </summary>
        Task<Schema> GetSpeciesSchema();

        /// Starship
        /// <summary>
        /// get a specific starship resource
        /// </summary>
        Task<Starship> GetStarship(string id);

        /// <summary>
        /// get all the starship resources
        /// </summary>
        Task<SharpEntityResults<Starship>> GetAllStarships(string pageNumber = "1");

        /// <summary>
        /// get starship schema
        /// </summary>
        Task<Schema> GetStarshipsSchema();

        /// Vehicle
        /// <summary>
        /// get a specific vehicle resource
        /// </summary>
        Task<Vehicle> GetVehicle(string id);

        /// <summary>
        /// get all the vehicle resources
        /// </summary>
        Task<SharpEntityResults<Vehicle>> GetAllVehicles(string pageNumber = "1");

        /// <summary>
        /// get vehicle schema
        /// </summary>
        Task<Schema> GetVehiclesSchema();
    }
}
