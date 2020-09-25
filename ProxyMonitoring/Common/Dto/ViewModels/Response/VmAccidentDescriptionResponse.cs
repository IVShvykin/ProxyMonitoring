using System.Runtime.Serialization;

namespace Common.Dto.ViewModels.Response
{
    [DataContract]
    public class VmAccidentDescriptionResponse
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }
        
        [DataMember(Name = "value")]
        public string Value { get; set; }
    }
}
