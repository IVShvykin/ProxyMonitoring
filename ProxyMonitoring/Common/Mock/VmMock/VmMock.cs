using System;
using Common.Dto.ViewModels;
using Common.Dto.Enums;

namespace Common.Mock.VmMock
{
    public static class VmMock
    {
        public static readonly VmAccedentHistoryResponse vMAccedentHistoryResponse =
            new VmAccedentHistoryResponse()
            {
                CompletedHistory = new VmHistoryRecord[] { new VmHistoryRecord() { Name = "Соколов А. А.", FinishDate = new DateTime(2020, 6, 26), Description = "Описание работы" } },
                PlanHistory = new VmHistoryRecord[] { new VmHistoryRecord() { Name = "Иванов И. И.", FinishDate = new DateTime(2020, 7, 15), Description = "Описание другой работы" } },
            };

        public static readonly VmAccedentInfoResponse vmAccedentInfoResponse =
            new VmAccedentInfoResponse()
            {
                Id = "1",
                Name = "Авария IM-216836", // Имя аварии *
                Type = BlWorkType.accident, // Тип авария или плановая работа accident/plan *
                Category = 10, // Категория аварии *
                Status = "Устранение последствий", // Статус аварии *
                StatusType = BlAccidentStatusType.warning, // Тип статуса аварии critical/warning/normal *
                Description = "Описание", // Описание аварии *
                ImpactDescription = "Описание последствия", // Описание последствия *
                FailurePoint = "М-Банк", // Точка сбоя *
                ConfigurationUnit = "М-Банк", // Конфигурационная единица *
                AffectedSystems = new string[] { "Платежи", "Переводы" },// Затронутые системы *
                StartDate = new DateTime(2020, 6, 26), // Дата начала *
                DetectionDate = new DateTime(2020, 7, 20), // Дата выявления *
                PredictDate = new DateTime(2020, 6, 21), // Прогнозируемая дата завершения *
                ConferenceLink = "https://bankvtb.webex.com/meet/xxx", // Ссылка на конференцию (Webex) *
                TelegramLink = "https://t.me/vtb" // Ссылка на Telegram-чат *
            };

        public static readonly VmAccedentsResponseModel[] vmAccedentsResponseModel =
            new VmAccedentsResponseModel[]
            {
                new VmAccedentsResponseModel()
                {
                    Id = "1", // Идентификатор аварии *
                    Name = "Авария IM-216836", // Имя аварии *
                    Type = BlWorkType.accident, // Тип авария или плановая работа accident/plan *
                    Category = 10, // Категория аварии *
                    Status = "Устранение последствий", // Статус аварии *
                    StatusType = BlAccidentStatusType.warning, // Тип статуса аварии critical/warning/normal *
                    Description = "Описание", // Описание аварии *
                    AffectedSystems = new string[] { "Платежи","Переводы" },// Затронутые системы * 
                    DetectionDate =new DateTime(2020,6,26) // Дата выявления *
                }
            };
    }
}
