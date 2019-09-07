using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication2.Api
{
    public class CarsController : ApiController
    {
        public string Get()
        {
            return "Hello world";
        }
    }
}
