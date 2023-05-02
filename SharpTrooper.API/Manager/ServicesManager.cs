using Newtonsoft.Json;
using SharpTrooper.API.Helpers;
using SharpTrooper.API.Models;
using System.Collections.Specialized;
using System.Net;
using System.Text;

namespace SharpTrooper.API.Manager
{
    public class ServicesManager : IServicesManager
    {
        //private readonly ILogger<ServicesManager> logger;
        private readonly string proxyName;

        public ServicesManager(/*ILogger<ServicesManager> logger,*/ string proxyName)
        {
            //this.logger = logger;
            this.proxyName = proxyName ?? string.Empty;
        }

        public async Task<People> GetPeople(string id) =>
            await GetSingle<People>($"/people/{id}");

        public async Task<SharpEntityResults<People>> GetAllPeople(string pageNumber = "1") =>
            await GetAllPaginated<People>("/people/", pageNumber);

        public async Task<Film> GetFilm(string id) =>
            await GetSingle<Film>($"/films/{id}");

        public async Task<SharpEntityResults<Film>> GetAllFilms(string pageNumber = "1") =>
            await GetAllPaginated<Film>("/films/", pageNumber);

        public async Task<Planet> GetPlanet(string id) =>
            await GetSingle<Planet>($"/planets/{id}");

        public async Task<SharpEntityResults<Planet>> GetAllPlanets(string pageNumber = "1") =>
            await GetAllPaginated<Planet>("/planets/", pageNumber);

        public async Task<Specie> GetSpecie(string id) =>
            await GetSingle<Specie>($"/species/{id}");

        public async Task<SharpEntityResults<Specie>> GetAllSpecies(string pageNumber = "1") =>
            await GetAllPaginated<Specie>("/species/", pageNumber);

        public async Task<Starship> GetStarship(string id) =>
            await GetSingle<Starship>($"/starships/{id}");

        public async Task<SharpEntityResults<Starship>> GetAllStarships(string pageNumber = "1") =>
            await GetAllPaginated<Starship>("/starships/", pageNumber);

        public async Task<Vehicle> GetVehicle(string id) =>
            await GetSingle<Vehicle>($"/vehicles/{id}");

        public async Task<SharpEntityResults<Vehicle>> GetAllVehicles(string pageNumber = "1") =>
            await GetAllPaginated<Vehicle>("/vehicles/", pageNumber);

        #region Supporting Functions

        private async Task<string> Request(string url, HttpMethod httpMethod, string data, bool isProxyEnabled)
        {
            string result = string.Empty;

            using (var httpClientHandler = new HttpClientHandler())
            {
                if (isProxyEnabled)
                {
                    httpClientHandler.Proxy = new WebProxy(proxyName, 80);
                    httpClientHandler.UseProxy = true;
                }

                using (var httpClient = new HttpClient(httpClientHandler))
                {
                    var requestMessage = new HttpRequestMessage(httpMethod, url);

                    if (!string.IsNullOrEmpty(data))
                    {
                        requestMessage.Content = new StringContent(data, Encoding.UTF8, "application/json");
                    }

                    using (var response = await httpClient.SendAsync(requestMessage))
                    {
                        result = await response.Content.ReadAsStringAsync();
                    }
                }
            }

            return result;
        }

        private string SerializeDictionary(Dictionary<string, string> dictionary)
        {
            var parameters = new StringBuilder();
            foreach (KeyValuePair<string, string> keyValuePair in dictionary)
            {
                parameters.Append(keyValuePair.Key + "=" + keyValuePair.Value + "&");
            }
            return parameters.Remove(parameters.Length - 1, 1).ToString();
        }

        private async Task<T> GetSingle<T>(string endpoint, Dictionary<string, string> parameters = null) where T : SharpEntity
        {
            string serializedParameters = "";
            if (parameters != null)
            {
                serializedParameters = "?" + SerializeDictionary(parameters);
            }

            return await GetSingleByUrl<T>(url: string.Format("{0}{1}{2}", Constants.APIURL, endpoint, serializedParameters));
        }

        private async Task<T> GetSingleByUrl<T>(string url) where T : SharpEntity
        {
            string json = await Request(url, HttpMethod.Get, null, false);
            T swapiResponse = JsonConvert.DeserializeObject<T>(json);
            return swapiResponse;
        }

        private async Task<SharpEntityResults<T>> GetMultiple<T>(string endpoint) where T : SharpEntity
        {
            return await GetMultiple<T>(endpoint, null);
        }

        private async Task<SharpEntityResults<T>> GetMultiple<T>(string endpoint, Dictionary<string, string> parameters) where T : SharpEntity
        {
            string serializedParameters = "";
            if (parameters != null)
            {
                serializedParameters = "?" + SerializeDictionary(parameters);
            }

            string json = await Request(string.Format("{0}{1}{2}", Constants.APIURL, endpoint, serializedParameters), HttpMethod.Get, null, false);
            SharpEntityResults<T> swapiResponse = JsonConvert.DeserializeObject<SharpEntityResults<T>>(json);
            return swapiResponse;
        }

        private NameValueCollection GetQueryParameters(string dataWithQuery)
        {
            var result = new NameValueCollection();
            string[] parts = dataWithQuery.Split('?');
            if (parts.Length > 0)
            {
                string QueryParameter = parts.Length > 1 ? parts[1] : parts[0];
                if (!string.IsNullOrEmpty(QueryParameter))
                {
                    string[] p = QueryParameter.Split('&');
                    foreach (string s in p)
                    {
                        if (s.IndexOf('=') > -1)
                        {
                            string[] temp = s.Split('=');
                            result.Add(temp[0], temp[1]);
                        }
                        else
                        {
                            result.Add(s, string.Empty);
                        }
                    }
                }
            }
            return result;
        }

        private async Task<SharpEntityResults<T>> GetAllPaginated<T>(string entityName, string pageNumber = "1") where T : SharpEntity
        {
            var parameters = new Dictionary<string, string>
            {
                { "page", pageNumber }
            };

            SharpEntityResults<T> result = await GetMultiple<T>(entityName, parameters);

            result.nextPageNo = string.IsNullOrEmpty(result.next) ? null : GetQueryParameters(result.next)["page"];
            result.previousPageNo = string.IsNullOrEmpty(result.previous) ? null : GetQueryParameters(result.previous)["page"];

            return result;
        }

        #endregion
    }
}
