
namespace SharpTrooper.API.Models
{
    public class Schema
    {
        public string name { get; set; }
        public string description { get; set; }
        public List<string> renders { get; set; }
        public List<string> parses { get; set; }
    }
}
