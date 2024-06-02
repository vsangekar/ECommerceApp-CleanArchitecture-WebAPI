using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ECommerceApp.Presentation.API.Controllers.Base
{
    [EnableCors("Trusted")]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class ApiBaseController : ControllerBase
    {
        protected string Identity
        {
            get
            {
                return User?.Claims
                            .FirstOrDefault(c => c.Type == ClaimsIdentity.DefaultNameClaimType)
                            ?.Value ?? "Anonymous";
            }
        }

        protected string UserId
        {
            get
            {
                var claim = User?.Claims
                                .FirstOrDefault(c => c.Type == ClaimsIdentity.DefaultNameClaimType);
                return claim?.Value ?? "NoUserId";
            }
        }

        protected string Name
        {
            get
            {
                return User?.Claims
                            .FirstOrDefault(c => c.Type == ClaimTypes.GivenName)
                            ?.Value ?? "UnknownName";
            }
        }

        protected string UserRole
        {
            get
            {
                return User?.Claims
                            .FirstOrDefault(c => c.Type == ClaimTypes.Role)
                            ?.Value ?? "NoRole";
            }
        }
    }
}