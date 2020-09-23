using System;
using Common.Dto.ViewModels.Response;
using Common.Dto.ViewModels.SubModels;
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

        public static readonly VmAccedentsResponse[] vmAccedentsResponse =
            new VmAccedentsResponse[]
            {
                new VmAccedentsResponse()
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

        public static readonly VmAccedentWorkersResponse vmAccedentWorkersResponseModels =
            new VmAccedentWorkersResponse
            {
                Manager = new VmManager()
                {
                    Name = "Иванов К.А.", // Имя менеджера *
                    Avatar = "https://www.nj.com/resizer/h8MrN0-Nw5dB5FOmMVGMmfVKFJo=/450x0/smart/cloudfront-us-east-1.images.arcpublishing.com/advancelocal/SJGKVE5UNVESVCW7BBOHKQCZVE.jpg", // Ссылка на аватар менеджера *
                    Role = "Начальник управления УАБД ДРИ" // Роль менеджера *}
                },
                Workers = new VmWorker[]
                {
                    new VmWorker()
                    {
                        Name = "Соколов А. А.", // Имя участника *
                        Status = BlWorkerStatus.joined, // Статус участника joined/ready/pending *
                        Role = "Департамент развития инфрастуктуры", // Роль участника *
                    },
                    new VmWorker()
                    {
                        Name = "Иванов А. А.", // Имя участника *
                        Status = BlWorkerStatus.pending, // Статус участника joined/ready/pending *
                        Role = "Департамент развития инфрастуктуры", // Роль участника *
                    },
                    new VmWorker()
                    {
                        Name = "Сидоров А. А.", // Имя участника *
                        Status = BlWorkerStatus.ready, // Статус участника joined/ready/pending *
                        Role = "Департамент развития инфрастуктуры", // Роль участника *
                    }
                }
            };

        public static readonly VmAccidentDescriptionResponse[] vmAccidentDescriptionResponseModel =
            new VmAccidentDescriptionResponse[]
            {
                new VmAccidentDescriptionResponse()
                {
                    Name = "Для сотрудников",
                    Value = "Выявлена недоступность АБС М-Банк, инстанс main. Последствия — в ВТБ Онлайн профиль клиентов, имеющих продукты экс-БМ собираются из кэш. Во время сбоя в ВТБ-онлайн было невозможно проведение операций по части ранее выпущенных карт (только бывшего Банка Москвы)." // Текст описания *
                },
                new VmAccidentDescriptionResponse()
                {
                    Name = "Для СМИ",
                    Value = "Ранее зафиксированные проблемы в ВТБ-Онлайн полностью устранены, работа мобильного приложения восстановлена.\nРанее в системе наблюдался кратковременный технический сбой, в ходе которого в адрес клиентов произошла выгрузка ошибочных СМС о ранее проведённых архивных транзакциях, однако никаких списаний денежных средств не производилось.\nПриносим свои извинения за неудобства, наши IT специалисты делают все возможное для усовершенствования онлайн-сервисов."
                }
            };

        public static readonly VmAccidentEventResponse[] vmAccidentEventResponseModel =
            new VmAccidentEventResponse[]
            {
                new VmAccidentEventResponse()
                {
                    Id = "1", // Идентификатор аварии
                    Date = new DateTime(2020, 6, 26),// Дата аварии
                    Type = BlWorkType.accident, //Тип аварии
                },
                new VmAccidentEventResponse()
                {
                    Id = "2", // Идентификатор аварии
                    Date = new DateTime(2020, 7, 20),// Дата аварии
                    Type = BlWorkType.plan, //Тип аварии
                }
            };
    }
}
