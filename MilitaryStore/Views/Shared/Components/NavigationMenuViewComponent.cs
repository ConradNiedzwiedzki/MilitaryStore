using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MilitaryStore.Models;

namespace MilitaryStore.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        IProductRepository repository;
        public NavigationMenuViewComponent(IProductRepository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(repository.Products
            .Select(x => x.Category)
            .Distinct()
            .OrderBy(x => x));
        }
    }
}