using Microsoft.AspNetCore.Mvc;
using MilitaryStore.Models;
namespace MilitaryStore.Controllers
{
    public class AdminController : Controller
    {
        private IProductRepository repository;
        public AdminController(IProductRepository repo)
        {
            repository = repo;
        }
        public ViewResult Index() => View(repository.Products);
    }
}