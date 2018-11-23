using AutoMapper;
using Mickey.DataAccess;
using Mickey.Domain;
using Mickey.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mickey.Web.Controllers
{
    public class CustomerController : Controller
    {
        private readonly CustomersService _CustomersService;

        public CustomerController()
        {
            _CustomersService = new CustomersService();
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CustomersViewModel FormData)
        {
            if (!ModelState.IsValid)
            {
                return View(FormData);
            }

            var CreateData = Mapper.Map<Customers>(FormData);
            _CustomersService.Create(CreateData);

            return RedirectToAction(nameof(this.Index));
        }

    }
}