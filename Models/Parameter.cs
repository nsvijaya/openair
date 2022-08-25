
namespace openaq.Models
{
    public class Parameter
    {

  public int id { get; set; }
        public string unit { get; set; }
        public int count { get; set; }
        public double average { get; set; }
        public double lastValue { get; set; }
        public string parameter { get; set; }
        public string displayName { get; set; }
        public DateTime lastUpdated { get; set; }
        public int parameterId { get; set; }
        public DateTime firstUpdated { get; set; }
        public List<Manufacturer> manufacturers { get; set; }

    }
}