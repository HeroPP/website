using Microsoft.AspNetCore.Mvc;

namespace Website.Controllers
{
    [Route(".well-known")]
    [ApiController]
    public class WellKnownController : ControllerBase
    {
        [HttpGet("assetlinks.json")]
        public IActionResult GetAssetLinks()
        {
            return this.Ok(new
            {
                releation = new string[] { "delegate_permission/common.handle_all_urls" },
                target = new
                {
                    @namespace = "android_app",
                    package_name = "dev.curth.hero",
                    sha256_cert_fingerprints = new string[] { "4D:5E:D1:84:CA:FA:B6:75:B0:E7:4B:43:EB:D4:9E:46:BD:6A:F5:B7:DD:9C:46:66:A3:E8:0E:68:24:92:EE:C2" }
                }
            });
        }
    }
}
