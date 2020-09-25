using System.Runtime.Serialization;

namespace Common.Dto.ViewModels.Response
{
    [DataContract]
    public class VmUpdateResponse
    {
        [DataMember(Name = "result")]
        public string Result { get; set; }
    }
}
