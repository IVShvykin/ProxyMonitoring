namespace Common.Dto.ViewModels
{
    public class VmAccedentHistoryResponse
    {
        public BlHistoryRecord[] CompletedHistory { get; set; }
        public BlHistoryRecord[] PlanHistory { get; set; }
    }
}
