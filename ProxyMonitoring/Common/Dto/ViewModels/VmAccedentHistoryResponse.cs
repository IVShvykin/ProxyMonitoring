namespace Common.Dto.ViewModels
{
    public class VmAccedentHistoryResponse
    {
        public VmHistoryRecord[] CompletedHistory { get; set; }
        public VmHistoryRecord[] PlanHistory { get; set; }
    }
}
