using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpTrooper.API.Models
{
    /// <summary>
    /// A Starship resource is a single transport craft that has hyperdrive capability.
    /// </summary>
    public class Starship : Vehicle
    {
		/// <summary>
    	/// The name of this starship. The common name, such as "Death Star".
    	/// </summary>
		public string name { get; set; }

		/// <summary>
    	/// The model or official name of this starship. Such as "T-65 X-wing" or "DS-1 Orbital Battle Station".
    	/// </summary>
		public string model { get; set; }

		/// <summary>
    	/// The class of this starship, such as "Starfighter" or "Deep Space Mobile Battlestation".
    	/// </summary>
		public string starship_class { get; set; }

		/// <summary>
    	/// The manufacturer of this starship. Comma separated if more than one.
    	/// </summary>
		public string manufacturer { get; set; }

		/// <summary>
    	/// The cost of this starship new, in galactic credits.
    	/// </summary>
		public string cost_in_credits { get; set; }

		/// <summary>
    	/// The length of this starship in meters.
    	/// </summary>
		public string length { get; set; }

		/// <summary>
    	/// The number of personnel needed to run or pilot this starship.
    	/// </summary>
		public string crew { get; set; }

		/// <summary>
    	/// The number of non-essential people this starship can transport.
    	/// </summary>
		public string passengers { get; set; }

		/// <summary>
    	/// The maximum speed of this starship in the atmosphere. "N/A" if this starship is incapable of atmospheric flight.
    	/// </summary>
		public string max_atmosphering_speed  { get; set; }

		/// <summary>
    	/// The class of this starship's hyperdrive.
    	/// </summary>
		public string hyperdrive_rating  { get; set; }

		/// <summary>
		/// The Maximum number of Megalights this starship can travel in a standard hour. A "Megalight" is a standard unit of distance and has never been defined before within the Star Wars universe. This figure is only really useful for measuring the difference in speed of starships. We can assume it is similar to AU, the distance between our Sun (Sol) and Earth
		/// </summary>
		public string MGLT { get; set; }

		/// <summary>
		/// The maximum number of kilograms that this starship can transport.
		/// </summary>
		public string cargo_capacity { get; set; }

		/// <summary>
		/// The maximum length of time that this starship can provide consumables for its entire crew without having to resupply.
		/// </summary>
		public string consumables { get; set; }

		/// <summary>
		/// An array of Film URL Resources that this starship has appeared in.
		/// </summary>
		public List<string> films { get; set; }

		/// <summary>
		/// An array of People URL Resources that this starship has been piloted by.
		/// </summary>
		public List<string> pilots { get; set; }

		/// <summary>
		/// The hypermedia URL of this resource.
		/// </summary>
		public string url { get; set; }

		/// <summary>
        /// The ISO 8601 date format of the time that this resource was created.
        /// </summary>
        public string created { get; set; }

        /// <summary>
        /// The ISO 8601 date format of the time that this resource was edited.
        /// </summary>
        public string edited { get; set; }
    }
}























//{"required": ["name", "model", "manufacturer", "cost_in_credits", "length", "max_atmosphering_speed", "crew", "passengers", "cargo_capacity", "consumables", "vehicle_class", "pilots", "films", "created", "edited", "url"], "title": "Starship", 

//"description": "A vehicle.", "$schema": "http://json-schema.org/draft-04/schema", "properties": {

//"consumables": {"description": "The maximum length of time that this vehicle can provide consumables for it's entire crew without having to resupply.", "type": "string"}, 
//"pilots": {"description": "An array of People URL Resources that this vehicle has been piloted by.", "type": "array"}, 
//"cargo_capacity": {"description": "The maximum number of kilograms that this vehicle can transport.", "type": "string"}, 
//"url": {"description": "The hypermedia URL of this resource.", "type": "string"}, 
//"crew": {"description": "The number of personnel needed to run or pilot this vehicle.", "type": "string"}, 
//"max_atmosphering_speed": {"description": "The maximum speed of this vehicle in atmosphere.", "type": "string"}, 
//"passengers": {"description": "The number of non-essential people this vehicle can transport.", "type": "string"}, 
//"vehicle_class": {"description": "The class of this vehicle, such as Wheeled.", "type": "string"}, 
//"created": {"description": "The ISO 8601 date format of the time that this resource was created.", "type": "string"}, 
//"name": {"description": "The name of this vehicle. The common name, such as Sand Crawler.", "type": "string"}, 
//"cost_in_credits": {"description": "The cost of this vehicle new, in galactic credits.", "type": "string"}, 
//"model": {"description": "The model or official name of this vehicle. Such as All Terrain Attack Transport.", "type": "string"}, 
//"films": {"description": "An array of Film URL Resources that this vehicle has appeared in.", "type": "array"}, 
//"manufacturer": {"description": "The manufacturer of this vehicle. Comma seperated if more than one.", "type": "string"}, 
//"length": {"description": "The length of this vehicle in meters.", "type": "string"}, 
//"edited": {"description": "the ISO 8601 date format of the time that this resource was edited.", "type": "string"}}, 
//"type": "object"}