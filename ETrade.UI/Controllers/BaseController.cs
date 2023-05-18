using ETrade.UoW;

using Microsoft.AspNetCore.Mvc;

namespace ETrade.UI.Controllers
{
    public class BaseController : Controller
    {
        public IUoW Uow;

        public BaseController(IUoW uow)
        {
            Uow = uow;
        }
    }
}