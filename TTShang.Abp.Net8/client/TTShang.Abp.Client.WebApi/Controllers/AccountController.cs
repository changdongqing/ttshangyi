using Microsoft.AspNetCore.Mvc;
using TTShang.Framework.Rbac.Application.Contracts.Dtos.Account;
using TTShang.Framework.Rbac.Application.Contracts.IServices;

namespace TTShang.Abp.Client.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {


        private readonly ILogger<AccountController> _logger;
        private IAccountService _accountService;
        public AccountController(ILogger<AccountController> logger, IAccountService accountService)
        {
            _logger = logger;
            _accountService = accountService;
        }

        [HttpPost("my-login")]
        public async Task<IActionResult> Login(LoginInputVo input)
        {
            await _accountService.PostLoginAsync(input);
            return Ok();
        }



        [HttpGet("my-captcha-image")]
        public async Task<IActionResult> CaptchaImageAsync()
        {
            var output = await _accountService.GetCaptchaImageAsync();
            return Ok(output);
        }
    }
}
