namespace openaq.Models
{
    public class Result
    {
        public int id { get; set; }
        public string city { get; set; }
        public object name { get; set; }
        public string entity { get; set; }
        public string country { get; set; }
        public List<Source> sources { get; set; }
        public bool isMobile { get; set; }
        public bool isAnalysis { get; set; }
        public List<Parameter> parameters { get; set; }
        public string sensorType { get; set; }
        public object coordinates { get; set; }
        public DateTime lastUpdated { get; set; }
        public DateTime firstUpdated { get; set; }
        public int measurements { get; set; }
        public List<double> bounds { get; set; }
        public List<Manufacturer> manufacturers { get; set; }
    }

}
