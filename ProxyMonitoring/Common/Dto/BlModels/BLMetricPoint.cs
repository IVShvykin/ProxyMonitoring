using System;

namespace Common.Dto.BlModels
{
    public class BLMetricPoint
    {
        public long Value { get; set; }
        public long Delta { get; set; }
        public double DeltaPercent { get; set; }
        public BlMetricsStatus DeltaStatus { get; set; }
        public DateTime Date { get; set; }
    }
}
