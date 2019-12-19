using GreenPeaceAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GreenPeaceAPI.DBService;
using GreenPeaceAPI.Models;


namespace GreenPeaceAPI.Controllers
{
    public class GreenLoginController : ApiController
    {

        [HttpPost]
        public string TestMethod([FromBody]LoginRequest value)
        {
            string Query = "select UserRoleStatus from GP_Users where Eamil = @Email and Password = @Password";
            string ConnectionString = "data source= DESKTOP-EIQBH4I\\SQLEXPRESS; database = GreenPease1; integrated security = true";

            DBAccess ReadDB = new DBAccess();
            LoginRequest LoginReturn = ReadDB.ReadDatabase(Query, ConnectionString, value);

            return "Hello from http post web api controller: " + value.Password;
        }

        [HttpPost]
        public string GreenRegister([FromBody]LoginRequest value)
        {

            return "Hello from http post web api controller: " + value.Password;
        }
    }
}
