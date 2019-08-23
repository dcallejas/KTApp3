using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KTApp3.Data;
using KTApp3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging.Console;
using RestSharp;

namespace KTApp3.Pages
{
    public class CustomersModel : PageModel
    {

        private readonly MyAppDbContext context = null;
        private readonly IConfiguration configuration = null;

        public CustomersModel(MyAppDbContext context, IConfiguration configuration)
        {
            this.context = context;
            this.configuration = configuration;
        }

        public void OnGet()
        {
            var tmp = configuration.GetSection("apiURL");
            //var client = new RestClient("http://dataapi:4000/api");
            var client = new RestClient(configuration.GetSection("apiURL").Value);
            //var client = new RestClient("http://192.168.99.104:4000/api");
            var request = new RestRequest("customers",Method.GET);
            var response = client.Get<List<Customer>>(request);
            CustomersList = response.Data;
            //CustomersList = context.Customers.ToList();
        }


        public List<Customer> CustomersList;

    }
}