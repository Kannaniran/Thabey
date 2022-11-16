using CarterPlus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace CarterPlus.Controllers
{
    public class LoginAPIController : ApiController
    {
        LoginModel[] ObjLogin = new LoginModel[]
       {
            new LoginModel { ID = 1, Name = "Test1"},
            new LoginModel { ID = 1, Name = "Test2"},
            new LoginModel { ID = 1, Name = "Test3"},
       };

        public IEnumerable<LoginModel> GetAllEmployees()
        {
            return ObjLogin;
        }

        public IHttpActionResult GetEmployee(int id)
        {
            var LoginDetails = ObjLogin.FirstOrDefault((p) => p.ID == id);
            if (LoginDetails == null)
            {
                return NotFound();
            }
            return Ok(LoginDetails);
        }
        public IHttpActionResult Delete(int id)
        {
            var LoginDetails = ObjLogin.FirstOrDefault((p) => p.ID == id);
            if (LoginDetails == null)
            {
                return NotFound();
            }
            return Ok(LoginDetails);
        }
        public IHttpActionResult Edit(int id)
        {
            var LoginDetails = ObjLogin.FirstOrDefault((p) => p.ID == id);
            if (LoginDetails == null)
            {
                return NotFound();
            }
            return Ok(LoginDetails);
        }
        public IHttpActionResult Details(int id)
        {
            var LoginDetails = ObjLogin.FirstOrDefault((p) => p.ID == id);
            if (LoginDetails == null)
            {
                return NotFound();
            }
            return Ok(LoginDetails);
        }
    }
}
