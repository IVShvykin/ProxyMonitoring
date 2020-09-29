using Common.Dto.ViewModels.SubModels;

namespace Common.Dto.ViewModels.Response
{
    public class VmPlanHistoryResponse
    {
        public VmHistoryRecord[] CompletedHistory { get; set; }
        public VmHistoryRecord[] PlanHistory { get; set; }
    }
}
