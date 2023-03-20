using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;
using m;
using Sql;
using System.Data;
namespace E
{
    public class DeparmentEntits
    {
        public List<Deparment> GetAllDeparment()
        {
            DeparmentSql d= new DeparmentSql();
            return d.getAllDeparmentSql();
        }
        public List<Deparment> GetOneDeparment(int id)
        {
            DeparmentSql d = new DeparmentSql();
            return d.getOneDeparmentSql(id);
        }
        public string InsertOneDeparment(Deparment deparment)
        {
            DeparmentSql d = new DeparmentSql();
            return d.insertOneDeparmentSql(deparment);
        }
        public string EditOneDeparment(Deparment deparment)
        {
            DeparmentSql d = new DeparmentSql();
            return d.editOneDeparmentSql(deparment);
        }
        public string DeleteOneDeparment(int id)
        {
            DeparmentSql d = new DeparmentSql();
            return d.deleteOneDeparmentSql(id);
        }
       
    }
}
