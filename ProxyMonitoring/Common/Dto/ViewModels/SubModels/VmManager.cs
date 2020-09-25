using System.Runtime.Serialization;

namespace Common.Dto.ViewModels.SubModels
{
    [DataContract]
    public class VmManager
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "avatar")]
        public string Avatar { get; set; }

        [DataMember(Name = "role"))]
        public string Role { get; set; }
    }
}
