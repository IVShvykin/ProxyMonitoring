﻿using System;

namespace Common.Models.VmModels
{
    public class AccidentsRequestModel : PageRequestBaseModel
    {
        public DateTime? StartDate { get; set; }
        public string[] AffectedSystems { get; set; }
        public string[] FailurePoints { get; set; }
        public long? SystemId { get; set; }
        public int? PlanTypeId { get; set; }
        public string Keyword { get; set; }
    }
}
