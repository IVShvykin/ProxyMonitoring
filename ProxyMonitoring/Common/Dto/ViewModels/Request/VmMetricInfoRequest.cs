using System;
using System.ComponentModel.DataAnnotations;

namespace Common.Dto.ViewModels.Request
{
    public class VmMetricInfoRequest : VmPageRequestBase
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime FinishDate { get; set; }
    }
}
