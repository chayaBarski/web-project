using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using m;
namespace Sql
{
    public class ProductsSql
    {
        public List<Product> getAllProductSql()
        {
            string stringSql = "exec getAllProduct";
            DataTable table = new DataTable();
            DAL.connectToSql.RunCommand(stringSql, table.Load);
            return convertToList(table);
        }
        public List<Product> getOneProductSql(int id)
        {
            string stringSql = $"exec getOneProduct { id}";
            DataTable table = new DataTable();
            DAL.connectToSql.RunCommand(stringSql, table.Load);
            return convertToList(table);
        }
        public string insertOneProductSql(m.Product p)
        {
            string stringSql = $"exec insertOneProduct {p.Name},{p.price},{p.count},{p.IdDeparment}";
            DataTable table = new DataTable();
            DAL.connectToSql.RunCommand(stringSql, table.Load);
            return "the inster is succsed";
        }
        public string editOneProductSql(m.Product p)
        {
            string stringSql = $"exec editOneProduct{p.Id}, {p.Name},{p.price},{p.count},{p.IdDeparment}";
            DataTable table = new DataTable();
            DAL.connectToSql.RunCommand(stringSql, table.Load);
            return "the edit is succsed";
        }
        public string deleteOneProductSql(int id)
        {
            string stringSql = $"exec deleteOneProduct {id}";
            DataTable table = new DataTable();
            DAL.connectToSql.RunCommand(stringSql, table.Load);
            return "the delete is succsed";
        }
        public List<Product> convertToList(DataTable table)
        {
            List<Product> list = new List<Product>();
            foreach (DataRow Row in table.Rows)
            {
                Product p = new Product();
                p.Id = (int)Row["id"];
                p.Name = (string)Row["nameProduct"];
                p.price = (int)Row["Price"];
                p.count = (int)Row["countProduct"];
                p.IdDeparment = (int)Row["idDeparment"];
                p.Deparment = (string)Row["nameDeparment"];
                p.Edit =false;
                list.Add(p);
            }
            return list;
        }
    }
}
