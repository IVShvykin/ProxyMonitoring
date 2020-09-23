using Common.Dto.Enums;
using System;

namespace Common.Dto.ViewModels
{
    public class VmMetricPoint
    {
        public long Value { get; set; }
        public long Delta { get; set; }
        public double DeltaPercent { get; set; }
        public BlMetricsStatus DeltaStatus { get; set; }
        public DateTime Date { get; set; }
    }
}
