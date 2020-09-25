using System;
using System.Runtime.Serialization;

namespace Common.Dto.ViewModels.Request
{
    [DataContract]
    public class VmAccidentsRequest : VmPageRequestBase
    {
        [DataMember(Name = "startDate")]
        public DateTime? StartDate { get; set; }

        [DataMember(Name = "affectedSystems")]
        public string[] AffectedSystems { get; set; }

        [DataMember(Name = "failurePoints")]
        public string[] FailurePoints { get; set; }

        [DataMember(Name = "systemId")]
        public long? SystemId { get; set; }

        [DataMember(Name = "planTypeId")]
        public int? PlanTypeId { get; set; }

        [DataMember(Name = "keyword")]
        public string Keyword { get; set; }
    }
}
