using Code_Challenge_MT_21.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace Code_Challenge_MT_21.Controllers
{
    public class InterestCalculatorController : ApiController
    {
        // GET: InterestCalculator
        [HttpGet]
        public HttpResponseMessage CalculateRate(double creditAmount, int term, double existingCredit)
        {
            CreditRequest creditRequest = new CreditRequest();
            return Request.CreateResponse(HttpStatusCode.OK, creditRequest.CalculateInterest(creditAmount, term, existingCredit));
        }
    }
}