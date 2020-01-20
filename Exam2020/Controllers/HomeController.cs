using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Exam2020.Models;
using System.Text.Json;
using System.Drawing;
using Microsoft.EntityFrameworkCore;

namespace Exam2020.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ExamDataContext _dataContext;

        public HomeController(ILogger<HomeController> logger, ExamDataContext dataContext)
        {
            _logger = logger;
            _dataContext = dataContext;
        }

        public IActionResult Index(string NameOfTicket)
        {
            SetModel(NameOfTicket);

            ViewData["Rezult"] = _dataContext.T1Garage.Include(i=>i.Cars).Select(i=>(object)i).ToList(); //"Сюда вписать запрос"; .Select(i=>(object)i).ToList()
            return View();
        }
        private void SetModel(string NameOfTicket)
        {
            switch (NameOfTicket)
            {
                case "T1":
                    {
                        SetT1ToModel();
                        break;
                    }
                case "T2":
                    {
                        SetT2ToModel();
                        break;
                    }
                default:
                    {
                        SetT1ToModel();
                        break;
                    }
            }
        }

        private void SetT2ToModel()
        {
            ViewData.Model = new List<string>()
           {
               "T2Model",
               "T2Shop",
               "T2ShopItems",
               "T2Manufecturer"
           };
            ViewData["T2Model"] = _dataContext.T2Models.Select(i=>(object)i).ToList();
            ViewData["T2Shop"] = _dataContext.T2Shops.Select(i => (object)i).ToList();
            ViewData["T2ShopItems"] = _dataContext.T2ShopItems.Select(i => (object)i).ToList();
            ViewData["T2Manufecturer"] = _dataContext.T2Manufecturers.Select(i => (object)i).ToList();
        }
        private void SetT1ToModel()
        {
            ViewData.Model = new List<string>()
           {
               "T1Manufacturer",
               "T1Auto",
               "T1Garage",
               "T1CarModel"
           };
            ViewData["T1Manufacturer"] = _dataContext.T1Manufacturers.Select(i => (object)i).ToList();
            ViewData["T1Auto"] = _dataContext.T1Auto.Select(i => (object)i).ToList();
            ViewData["T1Garage"] = _dataContext.T1Garage.Select(i => (object)i).ToList();
            ViewData["T1CarModel"] = _dataContext.T1CarModels.Select(i => (object)i).ToList();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
