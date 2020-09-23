using Common.Dto.Enums;
using System;

namespace Common.Dto.ViewModels.Request
{
    public class VmGetEventsRequest
    {
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public BlWorkType? Type { get; set; }
    }
}
