﻿using System.Threading.Tasks;
using Common.Dto.ViewModels.Request;
using Common.Dto.ViewModels.Response;
using Common.Mock.VmMock;
using Microsoft.AspNetCore.Mvc;

namespace ProxyMobileMonitoringAPI.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class PlanSectionsController : ControllerBase
    {
        [HttpGet]
        public async Task<VmPlanSectionsResponse[]> Get([FromQuery] VmPlanSectionRequest vmPlanSectionRequest)
        {
            return VmMock.vmPlanSectionsResponse;
        }
    }
}