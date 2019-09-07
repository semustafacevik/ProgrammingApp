using Programming.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Programming.API.Controllers
{
    public class LanguagesController : ApiController
    {
        LanguagesDAL languagesDAL = new LanguagesDAL();

        /*
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, languagesDAL.GetAllLanguages());
        }
        */

        public IHttpActionResult Get()
        {
            return Ok(languagesDAL.GetAllLanguages());
        }

        public IHttpActionResult Get(int ID)
        {
            var language = languagesDAL.GetLanguageByID(ID);

            if (language == null)
                return NotFound();

            return Ok(language);
        }

        public IHttpActionResult Post(Languages language)
        {
            if (ModelState.IsValid)
                return CreatedAtRoute("DefaultApi", new { id = language.ID }, languagesDAL.CreateLanguage(language));

            else
                return BadRequest(ModelState);
        }

        public IHttpActionResult Put(int ID, Languages language)
        {
            //id?
            if (!languagesDAL.IsThereAnyLanguage(ID))
                return NotFound();
            //model state
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
    }
}