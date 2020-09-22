using Common.Models.BlModels;

namespace Common.Models.VmModels
{
    public class MetricsResModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool Mine { get; set; }
        public string Value { get; set; }
        public long Delta { get; set; }
        public double DeltaPercent { get; set; }
        public MetricsStatus DeltaStatus { get; set; }
        public double TotalPercent { get; set; }
    }
}
