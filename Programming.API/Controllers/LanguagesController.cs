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

        public IEnumerable<Languages> Get()
        {
            return languagesDAL.GetAllLanguages();
        }

        public Languages Get(int ID)
        {
            return languagesDAL.GetLanguageByID(ID);
        }

        public Languages Post(Languages language)
        {
            return languagesDAL.CreateLanguage(language);
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
