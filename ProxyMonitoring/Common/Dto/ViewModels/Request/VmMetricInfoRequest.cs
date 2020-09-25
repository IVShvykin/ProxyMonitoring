using System;
using System.Runtime.Serialization;

namespace Common.Dto.ViewModels.Request
{
    [DataContract]
    public class VmMetricInfoRequest : VmPageRequestBase
    {
        [DataMember(Name = "Id")]
        public string Id { get; set; }

        [DataMember(Name = "startDate")]
        public DateTime StartDate { get; set; }

        [DataMember(Name = "finishDate")]
        public DateTime FinishDate { get; set; }

        [DataMember(Name = "keyword")]
        public string Keyword { get; set; }
    }
}
