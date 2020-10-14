using Common.Dto.ViewModels.Request;
using Common.Dto.ViewModels.Response;
using Common.Mock.VmMock;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ProxyMobileMonitoringAPI.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class PlansController : ControllerBase
    {
        [HttpPost("sections")]
        public async Task<VmPlanSectionsResponse[]> GetPlanSections([FromBody] VmPlanSectionRequest vmPlanSectionRequest)
        {
            return VmMock.vmPlanSectionsResponse;
        }

        [HttpPost]
        public async Task<VmPlanResponse[]> Get([FromBody] VmPlanRequest vmPlanRequest)
        {
            return VmMock.vmPlanResponse;
        }

        [HttpGet("info")]
        public async Task<VmPlanInfoResponse> GetPlanInfo([FromQuery][Required] string id)
        {
            return VmMock.vmPlanInfoResponse;
        }

        [HttpGet("workers")]
        public async Task<VmPlanWorkers> GetPlanWorkers([FromQuery][Required] string id)
        {
            return VmMock.vmPlanWorkers;
        }

        [HttpGet("history")]
        public async Task<VmPlanHistoryResponse> GetPlanHistory([FromQuery][Required] string id)
        {
            return VmMock.vmPlanHistoryResponse;
        }

        [HttpGet("descriptions")]
        public async Task<VmPlanDescriptionResponse[]> AccidentDescriptions([FromQuery][Required] string id)
        {
            return VmMock.vmPlanDescriptionResponse;
        }
    }
}
