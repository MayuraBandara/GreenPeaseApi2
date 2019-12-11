using GreenPeaceAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GreenPeaceAPI.Controllers
{
    public class GreenLoginController : ApiController
    {

        [HttpPost]
        public string TestMethod([FromBody]LoginRequest value)
        {

            return "Hello from http post web api controller: " + value.Password;
        }

        [HttpPost]
        public string GreenRegister([FromBody]LoginRequest value)
        {

            return "Hello from http post web api controller: " + value.Password;
        }
    }
}
