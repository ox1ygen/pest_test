using PEST_test.Models;
using System.Threading.Tasks;
using System.Web.Http;

namespace PEST_test.Controllers
{
    public class postController : ApiController
    {
        //POST:

        [HttpPost]
        public async Task<IHttpActionResult> AddUser(User user) {
            await Task.Run(() => UserOperations.UsrOps.AddUser(user));
            return Ok();
        }
    }
}
