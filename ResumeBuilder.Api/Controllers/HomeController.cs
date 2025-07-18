using System;
using Microsoft.AspNetCore.Mvc;

namespace ResumeBuilder.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class HomeController : ControllerBase
{
    [HttpGet]
    public IActionResult Index()
    {
        return Ok("Welcome to the Resume Builder API!");
    }


}
