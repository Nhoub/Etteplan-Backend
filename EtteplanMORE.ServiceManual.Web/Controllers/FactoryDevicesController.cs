﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EtteplanMORE.ServiceManual.ApplicationCore.Entities;
using EtteplanMORE.ServiceManual.ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EtteplanMORE.ServiceManual.Web.Controllers
{
    [Route("api/[controller]")]
    public class FactoryDevicesController : Controller
    {
        private readonly IFactoryDeviceService _factoryDeviceService;

        public FactoryDevicesController(IFactoryDeviceService factoryDeviceService)
        {
            _factoryDeviceService = factoryDeviceService;
        }

        /// <summary>
        ///     HTTP GET: api/factorydevices/
        /// </summary>
        [HttpGet]
        public async Task<IEnumerable<FactoryDevice>> Get()
        {
            return (await _factoryDeviceService.GetAll());
        }
    }
}