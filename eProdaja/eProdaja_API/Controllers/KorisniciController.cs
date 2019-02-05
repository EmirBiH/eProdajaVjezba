using eProdaja_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace eProdaja_API.Controllers
{
    public class KorisniciController : ApiController
    {
        private eProdajaEntities db = new eProdajaEntities();


        public List<Korisnici_Result> GetKorisnici()
        {
            return db.sp_Korisnici_SelectAll().ToList();
        }

        [Route("api/Korisnici/{username}")]
        public IHttpActionResult GetKorisnici(string username)
        {
            Korisnici k = db.Korisnici.Where(x => x.KorisnickoIme == username).FirstOrDefault();

            if (k == null)
                return NotFound();
            return Ok(k);
        }
        public IHttpActionResult PostKorisnici(Korisnici obj)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            db.Korisnici.Add(obj);
            db.SaveChanges();
            return CreatedAtRoute("DefaultApi",new {id=obj.KorisnikID },obj);
        }
    }
}
