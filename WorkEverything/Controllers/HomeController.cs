using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TranninShop.Model.Models;
using TranninShop.Service;
using TranninShop.Web.Models;

namespace TranninShop.Web.Controllers
{
	public class HomeController : Controller
	{
		IProductCategoryService _productCategoryService;

		public HomeController(IProductCategoryService productCategoryService) {
			this._productCategoryService = productCategoryService;
		}

		public ActionResult Index()
		{
			return View();
		}

		[ChildActionOnly]//Chi de nhung
		public ActionResult Header()
		{
			return PartialView();
		}

		[ChildActionOnly]//Chi de nhung
		public ActionResult Menu()
		{
			var model = _productCategoryService.GetAll();
			var listProductCategoryViewModel = Mapper.Map<IEnumerable<ProductCategory>, IEnumerable<ProductCategoryViewModel>>(model);
			return PartialView(listProductCategoryViewModel);
		}

		[ChildActionOnly]//Chi de nhung
		public ActionResult Bander()
		{
			return PartialView();
		}

		[ChildActionOnly]//Chi de nhung
		public ActionResult Footer()
		{
			return PartialView();
		}
	}
}