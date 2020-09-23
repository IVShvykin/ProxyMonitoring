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
    public class AccidentsController : ControllerBase
    {
        [HttpGet]
        public async Task<VmAccidentResponse[]> Get([FromQuery] VmAccidentsRequest vmAccidentsRequest)
        {
            return VmMock.vmAccidentResponse;
        }

        [HttpGet("info")]
        public async Task<VmAccidentInfoResponse> AccidentInfo([FromQuery] string id)
        {
            return VmMock.vmAccidentInfoResponse;
        }

        [HttpGet("history")]
        public async Task<VmAccidentHistoryResponse> AccidentHistory([FromQuery] string id)
        {
            return VmMock.vmAccidentHistoryResponse;
        }

        [HttpGet("descriptions")]
        public async Task<VmAccidentDescriptionResponse[]> AccidentDescriptions([FromQuery] string id)
        {
            return VmMock.vmAccidentDescriptionResponse;
        }

        [HttpGet("workers")]
        public async Task<VmAccidentWorkersResponse> AccidentWorkers([FromQuery] string id)
        {
            return VmMock.vmAccidentWorkersResponse;
        }
    }
}
