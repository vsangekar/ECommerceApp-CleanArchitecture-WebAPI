﻿using EcommerceApp.Application.Command;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateUserCommand command)
        {
            var userId = await _mediator.Send(command);
            return Ok(userId);
        }
    }
}
