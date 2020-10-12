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
        [HttpPost]
        public async Task<VmMetricsResponse[]> Get([FromBody] VmMetricsRequest vmMetricInfoRequest)
        {
            return vmMock.vmMetricsResponse;
        }

        [HttpPost("update")]
        public async Task<VmUpdateResponse> UpdateMetrics([FromBody] string[] vmUpdateRequest)
        {
            return vmMock.updateMetricsOrSystem;
        }

        [HttpPost("info")]
        public async Task<VmMetricInfoResponse[]> GetMetricInfo([FromBody] VmMetricInfoRequest vmMetricInfoRequest)
        {
            return vmMock.vmMetricInfoResponse;
        }
    }
}
