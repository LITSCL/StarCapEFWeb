using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCapEFModel.DAL
{
    public class ClienteDAL
    {
        public dbstarcapefwebEntities db = new dbstarcapefwebEntities();

        public void Save(Cliente c)
        {
            db.Cliente.Add(c);
            db.SaveChanges();
        }

        public void Delete(String rut)
        {
            Cliente c = db.Cliente.Find(rut);
            db.Cliente.Remove(c);
            db.SaveChanges();
        }

        public List<Cliente> GetAll()
        {
            return db.Cliente.ToList();
        }

        public List<Cliente> GetAll(int nivel)
        {
            var query = from c in db.Cliente where c.Nivel == nivel select c;
            return query.ToList();
        }
    }
}
