using Common.Dto.Enums;
using System.Runtime.Serialization;

namespace Common.Dto.ViewModels.SubModels
{
    [DataContract]
    public class VmWorker
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "status")]
        public BlWorkerStatus Status { get; set; }

        [DataMember(Name = "role")]
        public string Role { get; set; }
    }
}
