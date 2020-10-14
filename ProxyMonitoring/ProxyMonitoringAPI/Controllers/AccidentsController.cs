using System.ComponentModel.DataAnnotations;
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
        [HttpPost]
        public async Task<VmAccidentResponse[]> Get([FromBody] VmAccidentsRequest vmAccidentsRequest)
        {
            return VmMock.vmAccidentResponse;
        }

        [HttpGet("new")]
        public async Task<VmNewAccidentResponse> GetNewAccedent()
        {
            return VmMock.vmNewAccidentResponse;
        }

        [HttpGet("info")]
        public async Task<VmAccidentInfoResponse> AccidentInfo([FromQuery][Required] string id)
        {
            return VmMock.vmAccidentInfoResponse;
        }

        [HttpGet("history")]
        public async Task<VmAccidentHistoryResponse> AccidentHistory([FromQuery][Required] string id)
        {
            return VmMock.vmAccidentHistoryResponse;
        }

        [HttpGet("descriptions")]
        public async Task<VmAccidentDescriptionResponse[]> AccidentDescriptions([FromQuery][Required] string id)
        {
            return VmMock.vmAccidentDescriptionResponse;
        }

        [HttpGet("workers")]
        public async Task<VmAccidentWorkersResponse> AccidentWorkers([FromQuery][Required] string id)
        {
            return VmMock.vmAccidentWorkersResponse;
        }
    }
}
