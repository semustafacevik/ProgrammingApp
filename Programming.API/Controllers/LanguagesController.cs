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
            var languages = languagesDAL.GetAllLanguages();
            return Request.CreateResponse(HttpStatusCode.OK, languages);
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
            {
                var newLanguage = languagesDAL.CreateLanguage(language);
                return Request.CreateResponse(HttpStatusCode.Created, newLanguage);
            }
            else
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
        }

        public Languages Put(int ID, Languages language)
        {
            return languagesDAL.UpdateLanguage(ID, language);
        }

        public void Delete(int ID)
        {
            languagesDAL.DeleteLanguage(ID);
        }

    }
}
