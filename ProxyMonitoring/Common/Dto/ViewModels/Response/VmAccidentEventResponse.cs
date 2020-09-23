using Common.Dto.Enums;
using System;

namespace Common.Dto.ViewModels.Response
{
    public class VmAccidentEventResponse
    {
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public BlWorkType Type { get; set; }
    }
}
