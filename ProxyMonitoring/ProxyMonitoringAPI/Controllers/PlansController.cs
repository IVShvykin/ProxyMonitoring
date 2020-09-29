using Common.Dto.ViewModels.Request;
using Common.Dto.ViewModels.Response;
using Common.Mock.VmMock;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProxyMobileMonitoringAPI.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class PlansController : ControllerBase
    {
        [HttpGet("sections")]
        public async Task<VmPlanSectionsResponse[]> GetPlanSections([FromQuery] VmPlanSectionRequest vmPlanSectionRequest)
        {
            return VmMock.vmPlanSectionsResponse;
        }

        [HttpGet]
        public async Task<VmPlanResponse[]> Get([FromQuery] VmPlanRequest vmPlanRequest)
        {
            return VmMock.vmPlanResponse;
        }

        [HttpGet("info")]
        public async Task<VmPlanInfoResponse> GetPlanInfo(string id)
        {
            return VmMock.vmPlanInfoResponse;
        }

        [HttpGet("workers")]
        public async Task<VmPlanWorkers> GetPlanWorkers(string id)
        {
            return VmMock.vmPlanWorkers;
        }

        [HttpGet("history")]
        public async Task<VmPlanHistoryResponse> GetPlanHistory(string id)
        {
            return VmMock.vmPlanHistoryResponse;
        }
    }
}
