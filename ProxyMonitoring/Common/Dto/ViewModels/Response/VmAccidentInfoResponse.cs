using System;
using Common.Dto.Enums;
using System.Runtime.Serialization;

namespace Common.Dto.ViewModels.Response
{
    [DataContract]
    public class VmAccidentInfoResponse
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "type")]
        public BlWorkType Type { get; set; }

        [DataMember(Name = "category")]
        public int Category { get; set; }

        [DataMember(Name = "status")]
        public string Status { get; set; }

        [DataMember(Name = "statusType")]
        public BlAccidentStatusType StatusType { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "impactDescription")]
        public string ImpactDescription { get; set; }

        [DataMember(Name = "affectedSystems")]
        public string[] AffectedSystems { get; set; }

        [DataMember(Name = "startDate")]
        public DateTime StartDate { get; set; }

        [DataMember(Name = "detectionDate")]
        public DateTime DetectionDate { get; set; }

        [DataMember(Name = "conferenceLink")]
        public string ConferenceLink { get; set; }

        [DataMember(Name = "telegramLink")]
        public string TelegramLink { get; set; }

        [DataMember(Name = "failurePoint")]
        public string FailurePoint { get; set; }

        [DataMember(Name = "configurationUnit")]
        public string ConfigurationUnit { get; set; }

        [DataMember(Name = "predictDate")]
        public DateTime PredictDate { get; set; }
    }
}
