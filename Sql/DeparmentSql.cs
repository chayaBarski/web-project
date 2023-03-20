using System.Data;
using DAL;
using m;
namespace Sql
{
    public class DeparmentSql
    {
        public List<Deparment> getAllDeparmentSql()
        {
            string stringSql = "EXEC getAllDeparment";
            DataTable table = new DataTable();
            connectToSql.RunCommand(stringSql, table.Load);
            return convertToList(table);
        }
        public List<Deparment> getOneDeparmentSql(int id)
        {
            string stringSql = $"exec getOneDeparment { id}";
            DataTable table = new DataTable();
            DAL.connectToSql.RunCommand(stringSql, table.Load);
            return convertToList(table);
        }
        public string insertOneDeparmentSql(Deparment d)
        {
            string stringSql = $"exec insertOneDeparment {d.Name},{d.Description}";
            DataTable table = new DataTable();
            DAL.connectToSql.RunCommand(stringSql, table.Load);
            return "the inster is succsed";
        }
        public string deleteOneDeparmentSql(int  id)
        {
            string stringSql = $"exec deleteOneDeparment {id}";
            DataTable table = new DataTable();
            DAL.connectToSql.RunCommand(stringSql, table.Load);
            return "the delete is succsed";
        }
        public string editOneDeparmentSql(m.Deparment d)
        {
            string stringSql = $"exec editOneDeparment{d.Id}, {d.Name},{d.Description}";
            DataTable table = new DataTable();
            DAL.connectToSql.RunCommand(stringSql, table.Load);
            return "the edit is succsed";
        }
        public List<Deparment> convertToList(DataTable table)
        {
            List<Deparment> list = new List<Deparment>();
            foreach (DataRow Row in table.Rows)
            {
                Deparment d = new Deparment();
                d.Id = (int)Row["id"];
                d.Name=(string)Row["nameDeparment"];
                d.Description=(string)Row["descrepion"];
                d.Edit = false;
                list.Add(d);
            }
            return list;
        }
    }
}