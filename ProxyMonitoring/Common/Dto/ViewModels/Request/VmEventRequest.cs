using Common.Dto.Enums;
using System;
using System.Runtime.Serialization;

namespace Common.Dto.ViewModels.Request
{
    [DataContract]
    public class VmEventRequest
    {
        [DataMember(Name = "startDate")]
        public DateTime StartDate { get; set; }

        [DataMember(Name = "finishDate")]
        public DateTime FinishDate { get; set; }

        [DataMember(Name = "type")]
        public BlWorkType? Type { get; set; }
    }
}
