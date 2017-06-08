using IOTapp.Connections;
using IOTapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IOTapp.Controllers
{
    public class NutrientsController : ApiController
    {

        DatabaseConnection db;

        NutrientsController()
        {
            db = new DatabaseConnection();
        }

        [HttpGet]
        public HttpResponseMessage Get()
        {

            IEnumerable<Nutrients> ClientList = db.SelectAllNutrients();
            if (ClientList != null)
                return Request.CreateResponse<IEnumerable<Nutrients>>(HttpStatusCode.OK, ClientList);
            else
                return Request.CreateResponse(HttpStatusCode.NotFound);

        }


    }
}
