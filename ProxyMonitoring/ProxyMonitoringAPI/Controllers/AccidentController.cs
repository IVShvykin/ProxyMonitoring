using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    public class AccidentController : ControllerBase
    {
        [HttpGet]
        public async Task<VmAccidentResponse[]> Accidents([FromQuery] VmAccidentsRequest vmMetricsRequest)
        {
            return VmMock.vmAccidentResponse;
        }

        [HttpGet]
        public async Task<VmAccidentInfoResponse> AccidentInfo([FromQuery] string id)
        {
            return VmMock.vmAccidentInfoResponse;
        }

        [HttpGet]
        public async Task<VmAccidentHistoryResponse> AccidentHistory([FromQuery] string id)
        {
            return VmMock.vmAccidentHistoryResponse;
        }

        [HttpGet]
        public async Task<VmAccidentDescriptionResponse[]> AccidentDescriptions([FromQuery] string id)
        {
            return VmMock.vmAccidentDescriptionResponse;
        }

        [HttpGet]
        public async Task<VmAccidentWorkersResponse> AccidentWorkers([FromQuery] string id)
        {
            return VmMock.vmAccidentWorkersResponse;
        }
    }
}
