using Common.Dto.Enums;
using System;
using System.Runtime.Serialization;

namespace Common.Dto.ViewModels.Response
{
    [DataContract]
    public class VmMetricInfoResponse
    {
        [DataMember(Name = "value")]
        public long Value { get; set; }
        
        [DataMember(Name = "delta")]
        public long Delta { get; set; }
        
        [DataMember(Name = "deltaPercent")]
        public double DeltaPercent { get; set; }

        [DataMember(Name = "deltaStatus")]
        public BlMetricsStatus DeltaStatus { get; set; }

        [DataMember(Name = "date")]
        public DateTime Date { get; set; }
    }
}
