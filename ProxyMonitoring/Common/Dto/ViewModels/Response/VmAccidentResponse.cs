using Common.Dto.Enums;
using System;

namespace Common.Dto.ViewModels.Response
{
    public class VmAccidentResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public BlWorkType Type { get; set; }
        public int Category { get; set; }
        public BlAccidentStatusType StatusType { get; set; }
        public string Description { get; set; }
        public string[] AffectedSystems { get; set; }
        public DateTime DetectionDate { get; set; }
        public string Status { get; set; }
    }
}
