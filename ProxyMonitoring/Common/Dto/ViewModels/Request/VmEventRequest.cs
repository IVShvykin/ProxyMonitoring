using Common.Dto.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace Common.Dto.ViewModels.Request
{
    public class VmEventRequest
    {
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime FinishDate { get; set; }
        public BlWorkType? Type { get; set; }
    }
}
