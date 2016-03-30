using Microsoft.AspNet.Identity;
using System.Security.Claims;
using System.Web.Http;

namespace Disclosure.Controllers.Api
{
    public class AccountController:ApiController
    {
        [HttpGet]
        public IHttpActionResult Login()
        {
            var identity = new ClaimsIdentity(new[] {
                new Claim(ClaimTypes.Name, "Ben"),
                new Claim(ClaimTypes.Email, "a@b.com"),
                new Claim(ClaimTypes.Country, "England")
            }, DefaultAuthenticationTypes.ApplicationCookie);

            return Ok();
        }
    }
}