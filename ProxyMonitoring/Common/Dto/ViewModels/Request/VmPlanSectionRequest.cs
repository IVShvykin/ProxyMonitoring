using System;
using System.Runtime.Serialization;

namespace Common.Dto.ViewModels.Request
{
    [DataContract]
    public class VmPlanSectionRequest
    {
        [DataMember(Name = "startDate")]
        public DateTime? StartDate { get; set; }

        [DataMember(Name = "finishDate")]
        public DateTime? FinishDate { get; set; }
    }
}
