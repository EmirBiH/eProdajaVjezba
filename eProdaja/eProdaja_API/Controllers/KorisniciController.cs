using eProdaja_API.Models;
using eProdaja_API.Util;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace eProdaja_API.Controllers
{
    public class KorisniciController : ApiController
    {
        private eProdajaEntities db = new eProdajaEntities();

        [HttpGet]
        [Route("api/Korisnici")]
        public IHttpActionResult GetKorisnici()
        {
            return Ok(db.sp_Korisnici_SelectAll().ToList());
        }

        [ResponseType(typeof(Korisnici))]
        [Route("api/Korisnici/{Id}")]
        public IHttpActionResult GetKorisnici(int Id)
        {
            Korisnici k = db.Korisnici.Find(Id);
            if (k == null)
               return NotFound();
            return Ok(k);
        }

        [HttpPost]
        [Route("api/Korisnici")]
        public IHttpActionResult PostKorisnici(Korisnici obj)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            try
            {
                db.sp_Korisnici_Insert(obj.Ime, obj.Prezime, obj.Email, obj.Telefon,
                       obj.KorisnickoIme, obj.LozinkaHash, obj.LozinkaSalt, obj.Status);
            }
            catch (EntityException ex)
            {
                throw CreateHttpResponseException(ExceptionHandler.HandleException(ex), HttpStatusCode.Conflict);
            }

            foreach (var item in obj.Uloge)
            {
                db.sp_KorisniciUloge_Insert(obj.KorisnikID, item.UlogaID);
            }
            return CreatedAtRoute("DefaultApi", new { id = obj.KorisnikID }, obj);
        }

        [HttpPut]
        [Route("api/Korisnici/{id}")]
        public IHttpActionResult PutKorisnici(int id, Korisnici obj)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            if (id != obj.KorisnikID)
                return BadRequest();

            db.sp_Korisnici_Update(obj.KorisnikID, obj.Ime, obj.Prezime, obj.Email, obj.Telefon, obj.KorisnickoIme, obj.LozinkaSalt, obj.LozinkaHash, obj.Status);

            db.sp_KorisniciUloge_Delete(obj.KorisnikID);
            foreach (var x in obj.Uloge)
                db.sp_KorisniciUloge_Insert(id, x.UlogaID);

            return StatusCode(HttpStatusCode.NoContent);
        }

        [ResponseType(typeof(Korisnici))]
        [Route("api/Korisnici/GetByUserName/{username}")]
        public IHttpActionResult GetByUserName(string username)
        {
            Korisnici k = db.Korisnici.Where(x => x.KorisnickoIme == username).FirstOrDefault();

            if (k == null)
                return NotFound();
            return Ok(k);
        }

        [HttpGet]
        [Route("api/Korisnici/SearchByName/{name?}")]
        public IHttpActionResult SearchByName(string name = "")
        {
            return Ok(db.sp_Korisnici_SelectbyImePrezime(name).ToList());
        }

        [HttpGet]
        [Route("api/Korisnici/UlogeZaKorisnika/{id}")]
        public IHttpActionResult UlogeZaKorisnika(int id)
        {
            List<int?> uloge= db.sp_KorisniciUloge_SelectByUserId(id).ToList();
            if (uloge.Count < 1)
                return NotFound();
            return Ok(uloge);
        }

        private HttpResponseException CreateHttpResponseException(string reson, HttpStatusCode code)
        {
            HttpResponseMessage msg = new HttpResponseMessage()
            {
                StatusCode = code,
                ReasonPhrase = reson,
                Content = new StringContent(reson)
            };
            return new HttpResponseException(msg);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                db.Dispose();

            base.Dispose(disposing);   
        }
    }
}
