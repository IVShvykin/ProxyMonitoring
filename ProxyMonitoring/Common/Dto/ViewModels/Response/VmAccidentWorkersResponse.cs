using Common.Dto.ViewModels.SubModels;
using System.Runtime.Serialization;

namespace Common.Dto.ViewModels.Response
{
    [DataContract]
    public class VmAccidentWorkersResponse
    {
        [DataMember(Name = "manager")]
        public VmManager Manager { get; set; }

        [DataMember(Name = "workers")]
        public VmWorker[] Workers { get; set; }
    }
}
