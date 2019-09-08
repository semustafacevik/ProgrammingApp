using Programming.API.Security;
using Programming.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace Programming.API.Controllers
{
    [APIAuthorize(Roles = "Admin")]
    public class LanguagesController : ApiController
    {
        LanguagesDAL languagesDAL = new LanguagesDAL();

        /*
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, languagesDAL.GetAllLanguages());
        }
        */

        [ResponseType(typeof(IEnumerable<Languages>))]
        public IHttpActionResult Get()
        {
            return Ok(languagesDAL.GetAllLanguages());
        }

        [ResponseType(typeof(Languages))]
        public IHttpActionResult Get(int ID)
        {
            var language = languagesDAL.GetLanguageByID(ID);

            if (language == null)
                return NotFound();

            return Ok(language);
        }

        [ResponseType(typeof(Languages))]
        public IHttpActionResult Post(Languages language)
        {
            if (ModelState.IsValid)
                return CreatedAtRoute("DefaultApi", new { id = language.ID }, languagesDAL.CreateLanguage(language));

            else
                return BadRequest(ModelState);
        }

        [ResponseType(typeof(Languages))]
        public IHttpActionResult Put(int ID, Languages language)
        {
            //id?
            if (!languagesDAL.IsThereAnyLanguage(ID))
                return NotFound();
            //model state?
            else if (!ModelState.IsValid)
                return BadRequest(ModelState);
            //ok
            else
                return Ok(languagesDAL.UpdateLanguage(ID, language));
        }
        
        public IHttpActionResult Delete(int ID)
        {
            if (!languagesDAL.IsThereAnyLanguage(ID))
                return NotFound();

            else
            {
                languagesDAL.DeleteLanguage(ID);
                return Ok();
            }
        }
        
        public IHttpActionResult GetSearchByName(string name)
        {
            return Ok("Name: " + User.Identity.Name);
        }

        public IHttpActionResult GetSearchBySurname(string surname)
        {
            return Ok("Surname: " + surname);
        }
    }
}