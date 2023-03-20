using Microsoft.AspNetCore.Mvc;
using E;
using System.Collections;
using m;
namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/Department")]
    public class DepartmeiesControlls: Controller
    {
        public DepartmeiesControlls()
        {
        }
        [HttpGet("GetAlldepartment")]
         public  JsonResult getList()
        {
            List<Deparment> list = new List<Deparment>();
            DeparmentEntits D =new DeparmentEntits();
            try
            {
                list = D.GetAllDeparment();
                return new JsonResult(list);
            }
            catch(Exception e)
            {

                return new JsonResult(e);
            }


           
        }
        [HttpGet("getByIdDeparment/{id}")]
        public JsonResult getById(int id)
        {
            List<Deparment> list = new List<Deparment>();
            DeparmentEntits D = new DeparmentEntits();
            try
            {
                list = D.GetOneDeparment(id);
                return new JsonResult(list);
            }
            catch (Exception e)
            {

                return new JsonResult(e);
            }
        }

        [HttpPost("saveDeparment")]
        public JsonResult saveDeparmentData([FromBody]Deparment d) 
        {
            DeparmentEntits D = new DeparmentEntits();
            try
            {
                string res = D.InsertOneDeparment(d);
                return new JsonResult(res);
            }
            catch (Exception e)
            {

                return new JsonResult(e);
            }
        }
        [HttpDelete("deleteDeparment/{id}")]
        public JsonResult deleteDeparment(int id)
        {
            try
            {
                DeparmentEntits D = new DeparmentEntits();
                string res = D.DeleteOneDeparment(id);
                return new JsonResult(res);
            }
            catch (Exception e)
            {

                return new JsonResult(e);
            }
        }
        [HttpPut("editDeparment")]
        public JsonResult editDeparment([FromBody] Deparment d)
        {
            try
            {
                DeparmentEntits D = new DeparmentEntits();
                string res = D.EditOneDeparment(d);
                return new JsonResult(res);
            }
            catch (Exception e)
            {

                return new JsonResult(e);
            }
        }
    }

}
