using System;

namespace Common.Dto.ViewModels
{
    public class VmMetricInfoRequestModel
    {
        public string Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
    }
}
