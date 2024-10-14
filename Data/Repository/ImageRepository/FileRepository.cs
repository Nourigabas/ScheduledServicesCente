using Microsoft.AspNetCore.Http;

namespace Data.Repository.ImageRepository
{
    public class FileRepository : IFileRepository
    {
        public string UploadFile(IFormFile file)
        {
            string fileName = "";
            fileName = new string(Path.GetFileNameWithoutExtension(file.FileName).Take(10).ToArray()).Replace(" ", "_");
            fileName = fileName + DateTime.UtcNow.ToString("yymmssfff") + Path.GetExtension(file.FileName);

            var filepath = Path.Combine(Directory.GetCurrentDirectory(), "Resources", "Images", fileName);
            using (var stream = new FileStream(filepath, FileMode.Create))
            {
                file.CopyTo(stream);
            }
            return filepath;
        }
    }
}
