﻿using System;
using Common.Dto.ViewModels.Response;
using Common.Dto.ViewModels.SubModels;
using Common.Dto.Enums;

namespace Common.Mock.VmMock
{
    public static class VmMock
    {
        public static readonly VmAccidentDescriptionResponse[] vmAccidentDescriptionResponse =
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

        public static readonly VmPlanDescriptionResponse[] vmPlanDescriptionResponse =
            new VmPlanDescriptionResponse[]
            {
                    new VmPlanDescriptionResponse()
                    {
                        Name = "Для сотрудников",
                        Value = "Выявлена недоступность АБС М-Банк, инстанс main. Последствия — в ВТБ Онлайн профиль клиентов, имеющих продукты экс-БМ собираются из кэш. Во время сбоя в ВТБ-онлайн было невозможно проведение операций по части ранее выпущенных карт (только бывшего Банка Москвы)." // Текст описания *
                    },
                    new VmPlanDescriptionResponse()
                    {
                        Name = "Для СМИ",
                        Value = "Ранее зафиксированные проблемы в ВТБ-Онлайн полностью устранены, работа мобильного приложения восстановлена.\nРанее в системе наблюдался кратковременный технический сбой, в ходе которого в адрес клиентов произошла выгрузка ошибочных СМС о ранее проведённых архивных транзакциях, однако никаких списаний денежных средств не производилось.\nПриносим свои извинения за неудобства, наши IT специалисты делают все возможное для усовершенствования онлайн-сервисов."
                    }
            };

        public static readonly VmEventResponse[] vmEventResponse =
            new VmEventResponse[]
            {
                new VmEventResponse()
                {
                    Id = "1", // Идентификатор аварии
                    Date = new DateTime(2020, 6, 26),// Дата аварии
                    Type = BlWorkType.accident, //Тип аварии
                },
                new VmEventResponse()
                {
                    Id = "2", // Идентификатор аварии
                    Date = new DateTime(2020, 7, 20),// Дата аварии
                    Type = BlWorkType.plan, //Тип аварии
                }
            };

        public static readonly VmAccidentHistoryResponse vmAccidentHistoryResponse =
            new VmAccidentHistoryResponse()
            {
                CompletedHistory = new VmHistoryRecord[]
                {
                    new VmHistoryRecord()
                    {
                        Name = "Соколов А. А.",
                        FinishDate = new DateTime(2020, 6, 26).ToUniversalTime(),
                        Description = "Описание работы"
                    }
                },
                PlanHistory = new VmHistoryRecord[]
                {
                    new VmHistoryRecord()
                    {
                        Name = "Иванов И. И.",
                        FinishDate = new DateTime(2020, 7, 15).ToUniversalTime(),
                        Description = "Описание другой работы"
                    }
                },
            };

        public static readonly VmAccidentInfoResponse vmAccidentInfoResponse =
            new VmAccidentInfoResponse()
            {
                Id = "1",
                Name = "Авария IM-216836", // Имя аварии *
                Category = 10, // Категория аварии *
                Status = "Устранение последствий", // Статус аварии *
                StatusType = BlAccidentStatusType.warning, // Тип статуса аварии critical/warning/normal *
                Description = "Описание", // Описание аварии *
                ImpactDescription = "Описание последствия", // Описание последствия *
                FailurePoint = "М-Банк", // Точка сбоя *
                ConfigurationUnit = "М-Банк", // Конфигурационная единица *
                AffectedSystems = new string[] { "Платежи", "Переводы" },// Затронутые системы *
                StartDate = new DateTime(2020, 6, 26).ToUniversalTime(), // Дата начала *
                DetectionDate = new DateTime(2020, 6, 20).ToUniversalTime(), // Дата выявления *
                PredictDate = new DateTime(2020, 6, 21).ToUniversalTime(), // Прогнозируемая дата завершения *
                ConferenceLink = "https://bankvtb.webex.com/meet/xxx", // Ссылка на конференцию (Webex) *
                TelegramLink = "https://t.me/vtb" // Ссылка на Telegram-чат *
            };

        public static readonly VmAccidentResponse[] vmAccidentResponse =
            new VmAccidentResponse[]
            {
                new VmAccidentResponse()
                {
                    Id = "1", // Идентификатор аварии *
                    Name = "Авария IM-216836", // Имя аварии *
                    Category = 10, // Категория аварии *
                    Status = "Устранение последствий", // Статус аварии *
                    StatusType = BlAccidentStatusType.warning, // Тип статуса аварии critical/warning/normal *
                    Description = "Описание", // Описание аварии *
                    AffectedSystems = new string[] { "Платежи","Переводы" },// Затронутые системы * 
                    DetectionDate =new DateTime(2020,6,26).ToUniversalTime() // Дата выявления *
                }
            };

        public static readonly VmNewAccidentResponse vmNewAccidentResponse =
            new VmNewAccidentResponse()
            {
                Id = "1",
                Name = "Авария IM-216836"
            };

        public static readonly VmAccidentWorkersResponse vmAccidentWorkersResponse =
            new VmAccidentWorkersResponse
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

        public static readonly VmMetricsResponse[] vmMetricsResponse = new
            VmMetricsResponse[]
            {
                new VmMetricsResponse()
                {
                    Id="1",
                    Name = "Клиентов в ВТБ Онлайн", // Имя метрики *
                    Mine = true,
                    Value = "65024",
                    Delta = -56,
                    DeltaPercent = -0.6,
                    DeltaStatus = BlMetricsStatus.warning,
                    TotalPercent = 0.6
                },
                new VmMetricsResponse()
                {
                    Id = "2",
                    Name = "Очередь на исполнение документов БО",
                    Mine = true,
                    Value = "0",
                    Delta = -5,
                    DeltaPercent = -0.3,
                    DeltaStatus = BlMetricsStatus.normal,
                    TotalPercent = 0
                },
                new VmMetricsResponse()
                {
                    Id="3",
                    Name = "Количество новых операций в ВТБ-онлайн", // Имя метрики *
                    Mine = true,
                    Value = "0",
                    Delta = 50,
                    DeltaPercent = -0.6,
                    DeltaStatus = BlMetricsStatus.normal,
                    TotalPercent = 0.6
                },
                new VmMetricsResponse()
                {
                    Id="4",
                    Name = "Время формирования выписки", // Имя метрики *
                    Mine = true,
                    Value = "2.9с",
                    Delta = -56,
                    DeltaPercent = -0.6,
                    DeltaStatus = BlMetricsStatus.warning,
                    TotalPercent = 0.6
                }
            };

        public static readonly VmPlanSectionsResponse[] vmPlanSectionsResponse =
            new VmPlanSectionsResponse[]
            {
                new VmPlanSectionsResponse()
                {
                    Id = "1",
                    Name = "Экстренные",
                    Count = 1
                },
                new VmPlanSectionsResponse()
                {
                    Id = "2",
                    Name = "Плановые",
                    Count = 5
                },
            };

        public static readonly VmSystemResponse[] vmSystemResponse =
            new VmSystemResponse[]
            {
                new VmSystemResponse()
                {
                    Id = "1",
                    Name ="Бизнес операции", // Название системы *б
                    Mine = true,
                    CriticalAccidents = 1,
                    MajorAccedents = 3,
                    MinorAccedents = 10,
                },
                new VmSystemResponse()
                {
                    Id = "2",
                    Name = "Внутренние сервисы",
                },
            };

        public static readonly string[] affectedSystems = new string[]
        {
            "Платежи", // Название затронутой системы
            "Переводы",
            "Интернет банк",
            "Мобильный банк",
            "Вклады"
        };

        public static readonly string[] failurePoints = new string[]
        {
            "Profile", // Название точки сбоя
            "УСБС – бэк",
            "Сервисы Мультикарта",
            "Каналы связи",
            "Golden Gate",
            "Service Manager"
        };

        public static readonly VmUpdateResponse updateMetricsOrSystem = new VmUpdateResponse() { Result = "true" };

        public static readonly VmMetricInfoResponse[] vmMetricInfoResponse =
            new VmMetricInfoResponse[]
            {
                new VmMetricInfoResponse()
                {
                    Value = 65056,
                    Delta = 0,
                    DeltaPercent = 0,
                    DeltaStatus = BlMetricsStatus.normal,
                    Date = new DateTime(2020, 6, 26).ToUniversalTime()
                },
                new VmMetricInfoResponse()
                {
                    Value = 65000,
                    Delta = -56,
                    DeltaPercent = -0.6,
                    DeltaStatus = BlMetricsStatus.warning,
                    Date = new DateTime(2020, 6, 20).ToUniversalTime()
                }
            };

        public static readonly VmPlanResponse[] vmPlanResponse =
            new VmPlanResponse[]
            {
                new VmPlanResponse()
                {
                    Id = "1",
                    Name = "Изменение IM-283501",
                    Status = "Согласование",
                    StatusType = BlAccidentStatusType.warning,
                    Description = "Описание",
                    AffectedSystems = new string[]{ "Платежи", "Переводы" },
                    StartDate = new DateTime(2020, 6, 26).ToUniversalTime()
                },
                new VmPlanResponse()
                {
                    Id = "2",
                    Name = "Изменение IM-283501",
                    Status = "Выполнено",
                    StatusType = BlAccidentStatusType.normal,
                    Description = "Описание",
                    AffectedSystems = new string[]{ "Платежи" },
                    StartDate = new DateTime(2020, 7, 27).ToUniversalTime()
                }
            };

        public static readonly VmPlanInfoResponse vmPlanInfoResponse =
            new VmPlanInfoResponse()
            {
                Id = "10",
                Name = "Изменение IM-283501",
                Status = "Согласование",
                StatusType = BlPlanStatus.warning,
                Description = "Описание",
                ImpactDescription = "Описание последствий",
                DegradationRate = "Не влияет",
                ConfigurationUnit = "М-Банк",
                AffectedSystems = new string[] { "Платежи", "Переводы" },
                StartDate = new DateTime(2020, 6, 26).ToUniversalTime(),
                FinishDate = new DateTime(2020, 7, 27).ToUniversalTime(),
                StartDownDate = new DateTime(2020, 8, 30).ToUniversalTime(),
                FinishDownDate = new DateTime(2020, 9, 30).ToUniversalTime()
            };

        public static readonly VmPlanWorkersResponse vmPlanWorkers =
                new VmPlanWorkersResponse
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

        public static readonly VmPlanHistoryResponse vmPlanHistoryResponse =
            new VmPlanHistoryResponse()
            {
                CompletedHistory = new VmHistoryRecord[]
                {
                            new VmHistoryRecord()
                            {
                                Name = "Соколов А. А.",
                                FinishDate = new DateTime(2020, 6, 26).ToUniversalTime(),
                                Description = "Описание работы"
                            }
                },
                PlanHistory = new VmHistoryRecord[]
                {
                            new VmHistoryRecord()
                            {
                                Name = "Иванов И. И.",
                                FinishDate = new DateTime(2020, 7, 15).ToUniversalTime(),
                                Description = "Описание другой работы"
                            }
                },
            };
    }
}
