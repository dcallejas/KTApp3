using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KTApp3.Data;
using KTApp3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KTApp3.Pages
{
    public class CustomersModel : PageModel
    {

        private readonly MyAppDbContext context = null;

        public CustomersModel(MyAppDbContext context) { this.context = context; }

        public void OnGet()
        {
            CustomersList = context.Customers.ToList();
        }


        public List<Customer> CustomersList;

    }
}