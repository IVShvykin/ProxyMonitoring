using Common.Dto.BlModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Dto.ViewModels
{
    public class BlAccedentInfoResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public BlWorkType Type { get; set; }
        public int Category { get; set; }
        public string Status { get; set; }
        public BlAccidentStatusType StatusType { get; set; }
        public string Description { get; set; }
        public string ImpactDescription { get; set; }
        public string[] AffectedSystems { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DetectionDate { get; set; }
        public string ConferenceLink { get; set; }
        public string TelegramLink { get; set; }
    }
}
