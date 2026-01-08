using Microsoft.AspNetCore.Mvc;

namespace NerdStore.WebApp.MVC.Controllers
{
    public  abstract class ControllerBase : Controller
    {
        protected Guid ClienteId = Guid.Parse("49285721-0F72-4A72-BC78-7B29B8AE9886");
    }
}
