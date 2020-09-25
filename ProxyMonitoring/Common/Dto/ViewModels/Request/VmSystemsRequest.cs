using System.Runtime.Serialization;

namespace Common.Dto.ViewModels.Request
{
    [DataContract]
    public class VmSystemsRequest
    {
        [DataMember(Name = "onlyMine")]
        public bool? OnlyMine { get; set; }

        [DataMember(Name = "keyword")]
        public string Keyword { get; set; }
    }
}
