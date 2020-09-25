using Common.Dto.Enums;
using System.Runtime.Serialization;

namespace Common.Dto.ViewModels.Response
{
    [DataContract]
    public class VmMetricsResponse
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "mine")]
        public bool Mine { get; set; }

        [DataMember(Name = "value")]
        public string Value { get; set; }

        [DataMember(Name = "delta")]
        public long Delta { get; set; }

        [DataMember(Name = "deltaPercent")]
        public double DeltaPercent { get; set; }

        [DataMember(Name = "deltaStatus")]
        public BlMetricsStatus DeltaStatus { get; set; }

        [DataMember(Name = "totalPercent")]
        public double TotalPercent { get; set; }
    }
}
