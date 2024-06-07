using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ECommerceApp.Presentation.API.Controllers.Base;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Authorization;

namespace ECommerceApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ApiBaseController
    {
        public AccountController()
        {
                
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginRequest Request)
        {
            return null;
        }
    }
}
