using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ICD.Models;


namespace ICD.Controllers
{
    public class AgreementController : Controller
    {
        // GET: Agreement
        public ViewResult Agreements()
        {
            var Agreement = GetAgreements();
            // var Customer = _context.Customers.SingleOrDefault(c => c.Id == id);
   
            return View(Agreement);
        }

        public IEnumerable<Agreement> GetAgreements()
        {
            return new List<Agreement>
            {
                 new Agreement {Id = 1, Name = "Client1",Type="Purchase", Status="Released",Author="Mustermann", LastModifiedDate= DateTime.Now.AddDays(-10).ToShortDateString() },
                new Agreement {Id = 2, Name = "Client2",Type="Non Disclosure", Status="Draft" ,Author="Thomas", LastModifiedDate= DateTime.Now.AddDays(-4).ToShortDateString() }
            };

        }
    }


    
}