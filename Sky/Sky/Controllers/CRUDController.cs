﻿using Microsoft.AspNetCore.Mvc;

namespace Sky.Controllers
{
	public class CRUDController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult Details()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
    }
}
