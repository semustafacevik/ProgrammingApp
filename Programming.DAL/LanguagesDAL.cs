using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.DAL
{
    public class LanguagesDAL
    {
        ProgrammingDBEntities db = new ProgrammingDBEntities();

        public IEnumerable<Languages> GetAllLanguages()
        {
            return db.Languages;
        }

        public Languages GetLanguageByID(int ID)
        {
            return db.Languages.Find(ID);
        }

        public Languages CreateLanguage(Languages newLanguage)
        {
            db.Languages.Add(newLanguage);
            db.SaveChanges();
            return newLanguage;
        }

        public Languages UpdateLanguage(int ID, Languages updLanguage)
        {
            db.Entry(updLanguage).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return updLanguage;
        }

        public void DeleteLanguage(int ID)
        {
            db.Languages.Remove(db.Languages.Find(ID));
            db.SaveChanges();
        }

        public bool IsThereAnyLanguage(int ID)
        {
            return db.Languages.Any(x => x.ID == ID);
        }
    }
}
