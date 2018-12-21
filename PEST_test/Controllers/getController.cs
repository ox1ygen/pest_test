using PEST_test.Models;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;

namespace PEST_test.Controllers
{
    public class getController : ApiController
    {
        //GET:

        [HttpGet]
        public async Task<JsonResult<User>> GetUserById(int id)
        {
            return Json(await UserOperations.UsrOps.GetUserById(id));
        }
    }
}
