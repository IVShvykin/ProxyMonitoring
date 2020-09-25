using Common.Dto.ViewModels.SubModels;
using System.Runtime.Serialization;

namespace Common.Dto.ViewModels.Response
{
    [DataContract]
    public class VmAccidentHistoryResponse
    {
        [DataMember(Name = "completedHistory")]
        public VmHistoryRecord[] CompletedHistory { get; set; }
        
        [DataMember(Name = "planHistory")]
        public VmHistoryRecord[] PlanHistory { get; set; }
    }
}
