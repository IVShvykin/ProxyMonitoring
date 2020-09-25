using System.Runtime.Serialization;

namespace Common.Dto.ViewModels.Request
{
    [DataContract]
    public class VmPageRequestBase
    {
        [DataMember(Name = "limit")]
        public int Limit { get; set; }

        [DataMember(Name = "page")]
        public int Page { get; set; }
    }
}
