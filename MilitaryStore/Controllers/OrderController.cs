using Microsoft.AspNetCore.Mvc;
using MilitaryStore.Models;

namespace MilitaryStore.Controllers
{
    public class OrderController : Controller
    {
        public ViewResult Checkout() => View(new Order());
    }
}