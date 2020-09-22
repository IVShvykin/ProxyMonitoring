using Common.Dto.BlModels;
using System;

namespace Common.Dto.ViewModels
{
    public class VmAccedentsResponseModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public BlWorkType Type { get; set; }
        public int Category { get; set; }
        public BlAccidentStatusType StatusType { get; set; }
        public string Description { get; set; }
        public string[] AffectedSystems { get; set; }
        public DateTime DetectionDate { get; set; }
    }
}
