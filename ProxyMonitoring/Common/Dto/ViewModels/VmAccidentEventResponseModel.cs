using Common.Dto.Enums;
using System;

namespace Common.Dto.ViewModels
{
    public class VmAccidentEventResponseModel
    {
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public BlWorkType Type { get; set; }
    }
}
