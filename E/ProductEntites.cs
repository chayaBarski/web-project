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
    public class ProductEntites 
    {
        public List<Product> GetAllProduct()
        {
            ProductsSql p = new Sql.ProductsSql();
            return p.getAllProductSql();
        }
        public List<Product> GetOneProduct(int id)
        {
            ProductsSql p = new ProductsSql();
            return p.getOneProductSql(id);
        }
        public string InsertOneProduct(Product product)
        {
            ProductsSql p = new ProductsSql();
            return p.insertOneProductSql(product);
        }
        public string EditOneProduct(Product product)
        {
            ProductsSql p = new ProductsSql();
            return p.editOneProductSql(product);
        }
        public string DeleteOneProduct(int id)
        {
            ProductsSql p = new ProductsSql();
            return p.deleteOneProductSql(id);
        }
        //    public object BuildStudentList(SqlDataReader reader)
        //    {
        //        object ret = null;
        //        Hashtable hash = new Hashtable();
        //        while (reader.Read())
        //        {
        //            m.Deparment Deparment = new m.Deparment();
        //            int colIdx = reader.GetOrdinal("CustomerName");
        //            Deparment.Name = reader.GetString(colIdx);
        //            Deparment.Id = reader.GetInt32(reader.GetOrdinal("Id"));
        //            hash.Add(Deparment.Id, Deparment);

        //        }

        //        ret = hash;
        //        return ret;
        //    }
        //    void funcRead(SqlDataReader reader)
        //    {
        //        while (reader.Read())
        //        {
        //            int colIdx = reader.GetOrdinal("Deparment");
        //            string name = reader.GetString(colIdx);

        //        }
        //    }
        //    public Hashtable GetDeparment()
        //    {
        //        Hashtable ht;
        //        try
        //        {
        //            DAL.connectToSql.RunCommand("select * from Deparment", funcRead);

        //            ht = (Hashtable)DAL.connectToSql.RunCommandResult("select * from Entities", BuildStudentList);
        //            return ht;
        //        }

        //        catch (Exception ex)
        //        {

        //        }
        //        return null;

        //    }
    }
}
