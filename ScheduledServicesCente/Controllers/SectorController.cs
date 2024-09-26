using Domain;
using Microsoft.AspNetCore.Mvc;

namespace ScheduledServicesCente.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SectorController : Controller
    {
        //[HttpGet]
        //public ActionResult<List<Sector>> GetSectors([FromHeader] bool WithOut = true)
        //{
        //    //var respone = Sector.GetRooms();
        //    //if (respone == null)
        //    //    return NotFound();
        //    //return WithOut ? Ok(mapper.Map<List<RoomWithOutBookings>>(respone)) : Ok(respone);
        //}
    }
}
