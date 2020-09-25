using System;
using System.Runtime.Serialization;

namespace Common.Dto.ViewModels.SubModels
{
    [DataContract]
    public class VmHistoryRecord
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "finishDate")]
        public DateTime FinishDate { get; set; }

        [DataMember(Name = "role")]
        public string Role { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }
    }
}
