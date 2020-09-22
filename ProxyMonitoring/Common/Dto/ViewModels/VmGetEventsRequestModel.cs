using Common.Dto.BlModels;
using System;

namespace Common.Dto.ViewModels
{
    public class VmGetEventsRequestModel
    {
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public BlWorkType? Type { get; set; }
    }
}
