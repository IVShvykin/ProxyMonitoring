using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Common.Dto.ViewModels.Response;
using Common.Dto.ViewModels.Request;
using vmMock = Common.Mock.VmMock.VmMock;

namespace ProxyMobileMonitoringAPI.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class MetricsController : ControllerBase
    {
        [HttpGet]
        public async Task<VmMetricsResponse[]> Get([FromQuery] VmMetricInfoRequest vmMetricInfoRequest)
        {
            return vmMock.vmMetricsResponse;
        }

        [HttpPost("update")]
        public async Task<VmUpdateResponse> UpdateMetrics([FromBody] string[] vmUpdateRequest)
        {
            return vmMock.updateMetricsOrSystem;
        }

        [HttpGet("info")]
        public async Task<VmMetricInfoResponse[]> GetMetricInfo([FromQuery] VmMetricInfoRequest vmMetricInfoRequest)
        {
            return vmMock.vmMetricInfoResponse;
        }
    }
}
