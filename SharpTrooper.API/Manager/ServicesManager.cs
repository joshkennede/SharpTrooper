using SharpTrooper.API.Models;

namespace SharpTrooper.API.Manager
{
    public class ServicesManager : IServicesManager
    {
        public ServicesManager()
        {
        }

        public SharpEntityResults<Film> GetAllFilms(string pageNumber = "1")
        {
            throw new NotImplementedException();
        }

        public SharpEntityResults<People> GetAllPeople(string pageNumber = "1")
        {
            throw new NotImplementedException();
        }

        public SharpEntityResults<Planet> GetAllPlanets(string pageNumber = "1")
        {
            throw new NotImplementedException();
        }

        public SharpEntityResults<Specie> GetAllSpecies(string pageNumber = "1")
        {
            throw new NotImplementedException();
        }

        public SharpEntityResults<Starship> GetAllStarships(string pageNumber = "1")
        {
            throw new NotImplementedException();
        }

        public SharpEntityResults<Vehicle> GetAllVehicles(string pageNumber = "1")
        {
            throw new NotImplementedException();
        }

        public Film GetFilm(string id)
        {
            throw new NotImplementedException();
        }

        public People GetPeople(string id)
        {
            throw new NotImplementedException();
        }

        public Planet GetPlanet(string id)
        {
            throw new NotImplementedException();
        }

        public Specie GetSpecie(string id)
        {
            throw new NotImplementedException();
        }

        public Starship GetStarship(string id)
        {
            throw new NotImplementedException();
        }

        public Vehicle GetVehicle(string id)
        {
            throw new NotImplementedException();
        }
    }
}
