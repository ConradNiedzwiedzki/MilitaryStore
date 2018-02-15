using Microsoft.AspNetCore.Mvc;

namespace MilitaryStore.Controllers
{
    public class ErrorController : Controller
    {
        public ViewResult Error() => View();
    }
}
