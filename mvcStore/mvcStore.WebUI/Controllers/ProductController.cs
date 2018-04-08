using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcStore.Domain.Abstract;

namespace mvcStore.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _repository;

        public ProductController(IProductRepository repo)
        {
            _repository = repo;
        }
        
        // GET: Product
        public ViewResult List()
        {
            return View(_repository.Products);
        }
    }
}