namespace Common.Dto.ViewModels.Request
{
    public class VmMetricsRequest : VmPageRequestBase
    {
        public bool? OnlyMine { get; set; }
        public string Keyword { get; set; }
    }
}
