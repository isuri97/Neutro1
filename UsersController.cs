using IOTapp.Connections;
using IOTapp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IOTapp.Controllers
{
    public class UsersController : ApiController
    {


        DatabaseConnection db;

        UsersController()
        {
            db = new DatabaseConnection();
        }

        public HttpResponseMessage Get([FromUri]int key)
        {

            Users driver = db.Select(key);
            if (driver.UserID1 != null || driver.UserID1 == "")
                return Request.CreateResponse<Users>(HttpStatusCode.OK, driver);

            else
                return Request.CreateResponse(HttpStatusCode.NotFound);


        }

        [HttpPost]
        public String Post([FromUri]String key, [FromUri]String key1, [FromUri]String key2, [FromUri]String key3, [FromUri]String key4, [FromUri]String key5)
        {

            Users ws =new Users();
            ws.UserID1 = key;
            ws.UserName1 = key1;
            ws.UserHeight1 = key2;
            ws.UserWeight1 = key3;
            ws.UserBMI1 = key4;
            ws.RequiredNeutrition1 = key5;
            try
            {
               // ws = JsonConvert.DeserializeObject<Users>(key);
                // return "success "+ key;
                return db.InsertUser(ws);
            }
            catch (Exception ex)
            {
                return "ERROR Testing Purposes: " + ex;
            }

        }


        [HttpGet]
        public HttpResponseMessage Get()
        {

            IEnumerable<Users> ClientList = db.SelectAllUsers();
            if (ClientList != null)
                return Request.CreateResponse<IEnumerable<Users>>(HttpStatusCode.OK, ClientList);
            else
                return Request.CreateResponse(HttpStatusCode.NotFound);

        }

        [HttpPost]
        public String Post([FromUri]String key, [FromUri]String key1, [FromUri]String key2)
        {

            Users ws = new Users();
            ws.UserID1 = key;
           
            ws.UserHeight1 = key1;
            ws.UserWeight1 = key2;
           
            try
            {
                // ws = JsonConvert.DeserializeObject<Users>(key);
                // return "success "+ key;
                return db.UpdateUser(ws);
            }
            catch (Exception ex)
            {
                return "ERROR Testing Purposes: " + ex;
            }

        }

        [HttpPost]
        public IHttpActionResult postingUser([FromBody]Users user)

        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
             
            db.InsertUser(user);

            return StatusCode(HttpStatusCode.OK);
        }

    }
}
