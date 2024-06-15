using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ECommerceApp.Presentation.API.Controllers.Base;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Authorization;
using EcommerceApp.Application.Command.Login;
using MediatR;

namespace ECommerceApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ApiBaseController
    {
        private readonly IMediator _mediator;
        public AccountController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginCommand request)
        {
            var response = await _mediator.Send(request);
            if (response.IsAuthenticated)
            {
                return Ok(response);
            }
            return Unauthorized(response);
        }

        //[HttpPost("register")]
        //public async Task<IActionResult> Register([FromBody] AdminRegisterVM model)
        //{
        //    if (!ModelState.IsValid)
        //        return BadRequest(ModelState);

        //    if (!await _roleManager.RoleExistsAsync("Admin"))
        //    {
        //        await _roleManager.CreateAsync(new IdentityRole("Admin"));
        //    }

        //    var user = new IdentityUser { UserName = model.email, Email = model.email };

        //    var result = await _userManager.CreateAsync(user, model.Password);

        //    if (result.Succeeded)
        //    {
        //        await _userManager.AddToRoleAsync(user, "Admin");
        //        return Ok(new { Message = "User registered as SuperAdmin successfully." });
        //    }

        //    return BadRequest(new { Errors = result.Errors });
        //}
    }
}
