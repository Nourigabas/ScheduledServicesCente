using Data.Repository.ImageRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ScheduledServicesCente.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        private readonly IFileRepository fileRepository;

        public FileController(IFileRepository fileRepository)
        {
            this.fileRepository = fileRepository;
        }
        [HttpPost]
        public ActionResult<string> UploadFile()
        {
            var file = Request.Form.Files[0];
            string path = fileRepository.UploadFile(file);
            return Ok(path);
        }
    }
}
