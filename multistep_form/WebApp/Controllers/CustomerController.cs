using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TravelExperts.Domain;
using Microsoft.AspNetCore.Authorization;
using TravelExperts.BLL;
using TravelExpertsWebApp.Models;

namespace TravelExpertsWebApp.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Add(CustomerModel customer)
        {

            var cust = new Customer
            {
                CustAddress = customer.Address,
                CustFirstName = customer.FirstName,
                CustLastName = customer.LastName,
                CustCity = customer.City,
                CustCountry = customer.Country,
                CustEmail = customer.Email,
                CustPostal = customer.Postal,
                CustProv = customer.Prov,
                UserLogin = customer.UserLogin,
                UserPass = customer.UserPass
            };

            cust.CustHomePhone = CustomerManager.tidyPhoneNumber(customer.HomePhone);
            if (customer.BusPhone != null && customer.BusPhone != String.Empty)
            {
                cust.CustBusPhone = CustomerManager.tidyPhoneNumber(customer.BusPhone);
            }

            CustomerManager.Add(cust);
            
            return RedirectToAction("Confirmation");
        }


        public IActionResult Confirmation()
        {
            return View();
        }

        public IActionResult Exist(string username)
        {
            var content = "";
            if (CustomerManager.Exists(username))
            {
                content = "Username already exists, please use a different user name.";
            }

            return Content(content);
        }
    }
}
