﻿using System;
using Common.Dto.Enums;

namespace Common.Dto.ViewModels.Response
{
    public class VmAccidentInfoResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Category { get; set; }
        public string Status { get; set; }
        public BlAccidentStatusType StatusType { get; set; }
        public string Description { get; set; }
        public string ImpactDescription { get; set; }
        public string FailurePoint { get; set; }
        public string ConfigurationUnit { get; set; }
        public string[] AffectedSystems { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DetectionDate { get; set; }
        public DateTime PredictDate { get; set; }
        public string ConferenceLink { get; set; }
        public string TelegramLink { get; set; }
    }
}
