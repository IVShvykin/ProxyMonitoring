﻿using Common.Dto.Enums;

namespace Common.Dto.ViewModels
{
    public class VmMetricsResModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool Mine { get; set; }
        public string Value { get; set; }
        public long Delta { get; set; }
        public double DeltaPercent { get; set; }
        public BlMetricsStatus DeltaStatus { get; set; }
        public double TotalPercent { get; set; }
    }
}
