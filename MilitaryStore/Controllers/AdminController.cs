using Microsoft.AspNetCore.Mvc;
using MilitaryStore.Models;
using System.Linq;

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

        public ViewResult Edit(int productId) => View(repository.Products.FirstOrDefault(p => p.ProductID == productId));
    }
}