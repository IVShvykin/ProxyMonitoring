namespace Common.Dto.ViewModels
{
    public class VmSystemResponseModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public bool Mine { get; set; } = false;
        public int CriticalAccidents { get; set; } = 0;
        public int MajorAccedents { get; set; } = 0;
        public int MinorAccedents { get; set; } = 0;
    }
}
