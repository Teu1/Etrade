using ETrade.UoW;
using Microsoft.AspNetCore.Mvc;

namespace ETrade.UI.Controllers
{
    public class OrdersController : BaseController
    {
        public OrdersController(IUoW uow) : base(uow)
        {
        }

        public IActionResult List()
        {
            return View(uow.OrderRepository.List());
        }
    }
}
