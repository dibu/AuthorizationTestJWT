using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthorizationTestJWT {
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase {
        [HttpGet]
        public string TestMethod() {
            return "TestController Working!";
        }
    }
}
