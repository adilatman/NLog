using Microsoft.AspNetCore.Mvc;
using NLog.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NLog.UI.Controllers
{
    public class DenemeController : Controller
    {
        private readonly INLogManager _logManager;
        public DenemeController(INLogManager logManager)
        {
            _logManager = logManager;
        }
        public IActionResult Index()
        {
            _logManager.LogError("Hata olustu seklinde log islensin");
            return View();
        }
    }
}
