namespace Common.Dto.ViewModels.Request
{
    public class VmPlanRequest : VmPageRequestBase
    {
        public string Keyword { get; set; }

        public int PlanSectionId { get; set; }
    }
}