using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using SmartMapper.Helper;
using SmartMapper.Models;
using SmartMapper.Models.Transport;
using SmartMapperCore.Util;
using SmartMapperService.Interface;

namespace SmartMapper.Controllers
{
    public class HomeController : Controller
    {
        private ITransport _transport;

        public HomeController(ITransport transport)
        {
            _transport = transport;
        }

        public IActionResult Index()
        {
            var myList = HelperExtensions.convertJsonToSqliteTransports(AppFunction.getTransportFromJson());
           
            var allTransport = _transport.GetAll();

            var transportModels = myList.Select(p => new TransportViewModel
            {
                Id = p.Id,
                Code = p.Code,
                Name = p.Name,
                Address = p.Address,
                Type = p.Type
            }).ToList();


            return View(transportModels);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
