using Common.Dto.Enums;
using System;

namespace Common.Dto.ViewModels.Response
{
    public class VmPlanInfoResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public BlPlanStatus StatusType { get; set; }
        public string Description { get; set; }
        public string ImpactDescription { get; set; }
        public string DegradationRate { get; set; }
        public string ConfigurationUnit { get; set; }
        public string[] AffectedSystems { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public DateTime StartDownDate { get; set; }
        public DateTime FinishDownDate { get; set; }
    }
}
