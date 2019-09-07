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

        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, languagesDAL.GetAllLanguages());
        }

        public HttpResponseMessage Get(int ID)
        {
            var language = languagesDAL.GetLanguageByID(ID);

            if (language == null)
                return Request.CreateResponse(HttpStatusCode.NotFound, "No such record found!");

            return Request.CreateResponse(HttpStatusCode.OK, language);
        }

        public HttpResponseMessage Post(Languages language)
        {
            if (ModelState.IsValid)
                return Request.CreateResponse(HttpStatusCode.Created, languagesDAL.CreateLanguage(language));

            else
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
        }

        public HttpResponseMessage Put(int ID, Languages language)
        {
            //id?
            if (!languagesDAL.IsThereAnyLanguage(ID))
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No such record found!");
            //model state
            else if (!ModelState.IsValid)
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            //ok
            else
                return Request.CreateResponse(HttpStatusCode.OK, languagesDAL.UpdateLanguage(ID, language));
        }

        public HttpResponseMessage Delete(int ID)
        {
            if (!languagesDAL.IsThereAnyLanguage(ID))
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No such record found!");

            else
            {
                languagesDAL.DeleteLanguage(ID);
                return Request.CreateResponse(HttpStatusCode.NoContent);
            }
        }
    }
}