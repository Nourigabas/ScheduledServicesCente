using Microsoft.AspNetCore.Http;

namespace Data.Repository.ImageRepository
{
    public interface IFileRepository
    {
        public string UploadFile(IFormFile file);
    }
}
