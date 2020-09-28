﻿using System;

namespace Common.Dto.ViewModels.Request
{
    public class VmMetricInfoRequest : VmPageRequestBase
    {
        public string Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public string Keyword { get; set; }
    }
}
