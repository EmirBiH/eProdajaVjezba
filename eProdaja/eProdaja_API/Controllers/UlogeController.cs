using eProdaja_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace eProdaja_API.Controllers
{
    public class UlogeController : ApiController
    {
        private eProdajaEntities db = new eProdajaEntities();

        [HttpGet]
        [Route("api/Uloge")]
        public IHttpActionResult GetUloge()
        {
            List<Uloge> uloge = db.sp_Uloge_SelectAll().ToList();
            if (uloge == null)
              return  NotFound();
            return Ok(uloge);
        }

        [HttpGet]
        [Route("api/Uloge/{korisnikId}")]
        public IHttpActionResult GetUloge(int korisnikId)
        {
            List<Uloge> uloge = db.sp_Uloge_SelectAll().ToList();
            if (uloge == null)
                return NotFound();
            return Ok(uloge);
        }
    }
}
