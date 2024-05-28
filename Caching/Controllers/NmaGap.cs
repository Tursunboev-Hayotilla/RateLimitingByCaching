using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Caching.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NmaGap : ControllerBase
    {
        [HttpPost]
        public async Task<string> Salom(string gap)
        {
            return gap;
        }
    }
}
