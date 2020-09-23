using Common.Dto.ViewModels.SubModels;

namespace Common.Dto.ViewModels.Response
{
    public class VmAccedentHistoryResponse
    {
        public VmHistoryRecord[] CompletedHistory { get; set; }
        public VmHistoryRecord[] PlanHistory { get; set; }
    }
}
