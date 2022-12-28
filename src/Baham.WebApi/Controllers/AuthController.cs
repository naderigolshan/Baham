using Baham.Entities;
using Baham.ViewModels.Auth;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Baham.Common.Constants;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using AutoMapper;

namespace Baham.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
[Produces("application/json")]
public class AuthController : Controller
{
    public readonly UserManager<User> _userManager;
    private readonly IMapper _mapper;
    private readonly ILogger<AuthController> _logger;
    public AuthController(UserManager<User> userManager, IMapper mapper, ILogger<AuthController> logger)
    {
        _userManager = userManager;
        _logger = logger;
        _mapper = mapper;
    }

    // [HttpGet("{id}")]
    // [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
    // [ProducesResponseType(StatusCodes.Status404NotFound)]
    // public async Task<IActionResult> GetById(int id)
    // {
    //     var user = await _userManager.FindByIdAsync(id.ToString());
    //     return user == null ? NotFound() : Ok(user);
    // }

    // [HttpGet]
    // public async Task<IActionResult> CheckUsername(string username)
    // {
    //     return Json(true);
    // }

    [HttpPost]
    public async Task<IActionResult> Register(RegisterViewModel model)
    {
        var errors = new List<string>();

        if (ModelState.IsValid)
        {
            var user = _mapper.Map<User>(model);

            // var user = new User
            // {
            //     UserName = model.UserName,
            //     Email = model.Email,
            // };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                // _logger.LogInformation(LogCodes.RegisterCode, $"{user.UserName} create successfully");
                // var activationCode = _userManager.GenerateEmailConfirmationTokenAsync(user);
                // send email
                return Json("Success");
            }
            foreach (var error in result.Errors)
            {
                // ModelState.TryAddModelError(error.Code, error.Description);
                errors.Add(error.Description);
            }
        }
        return BadRequest(errors);
    }
}

