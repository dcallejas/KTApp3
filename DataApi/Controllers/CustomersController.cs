using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataApi.Data;
using DataApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DataApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly MyAppDbContext context = null;

        public CustomersController(MyAppDbContext context) { this.context = context; }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(context.Customers.ToList());
        }
    }
}