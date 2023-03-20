using Microsoft.AspNetCore.Mvc;
using E;
using m;
namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/Product")]
    public class ProductControlls : Controller
    {public ProductControlls()
        {

        }
        [HttpGet("Producs")]
public  JsonResult getList()
        {
            try
            {
 List<Product> list = new List<Product>();
            ProductEntites P = new ProductEntites();
           list= P.GetAllProduct();
            return new JsonResult(list);
            }
            catch (Exception e)
            {

                return new JsonResult(e);
            }

        }
        [HttpGet("getById/{id}")]
        public  JsonResult getById(int id)
        {
            try
            {
                List<Product> list = new List<Product>();
                ProductEntites P = new ProductEntites();
                list = P.GetOneProduct(id);
                return new JsonResult(list);
            }
            catch (Exception e)
            {

                return new JsonResult(e);
            }
        }
        [HttpPost("saveProduct/")]
        public  JsonResult saveDeparmentData([FromBody] Product p)
        {
            try
            {
                ProductEntites P = new ProductEntites();
                string res = P.InsertOneProduct(p);
                return new JsonResult(res);
            }
            catch (Exception e)
            {

                return new JsonResult(e);
            }
        }
        [HttpDelete("deleteProdu/{id}")]
        public JsonResult deleteProducr(int id)
        {
            try
            {
                ProductEntites P = new ProductEntites();
                string res = P.DeleteOneProduct(id);
                return new JsonResult(res);
            }
            catch (Exception e)
            {

                return new JsonResult(e);
            }
        }
        [HttpPut("editProducr")]
        public JsonResult editProducr([FromBody] Product p)
        {
            try
            {
                ProductEntites P = new ProductEntites();
                string res = P.EditOneProduct(p);
                return new JsonResult(res);
            }
            catch (Exception e)
            {

                return new JsonResult(e);
            }
        }

    }

}
