using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCapEFModel.DAL
{
    public class BebidaDAL
    {
        public dbstarcapefwebEntities db = new dbstarcapefwebEntities();

        public List<Bebida> GetAll()
        {
            return db.Bebida.ToList();
        }
    }
}
