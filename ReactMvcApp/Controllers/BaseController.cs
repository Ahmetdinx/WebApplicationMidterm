using Microsoft.AspNetCore.Mvc;

namespace ReactMvcApp.Controllers
{
    public class BaseController : Controller
    {
        protected string? GetIpAddress()
        {
            if (Request.Headers.ContainsKey("X-Forwarded-For")) return Request.Headers["X-Forwarded-For"];
            return HttpContext.Connection.RemoteIpAddress?.MapToIPv4().ToString();
        }
    }
}
