using System.Runtime.Serialization;

namespace Common.Dto.ViewModels.Response
{
    [DataContract]
    public class VmSystemResponse
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "mine")]
        public bool Mine { get; set; } = false;

        [DataMember(Name = "criticalAccidents")]
        public int CriticalAccidents { get; set; } = 0;

        [DataMember(Name = "majorAccedents")]
        public int MajorAccedents { get; set; } = 0;

        [DataMember(Name = "minorAccedents")]
        public int MinorAccedents { get; set; } = 0;
    }
}
