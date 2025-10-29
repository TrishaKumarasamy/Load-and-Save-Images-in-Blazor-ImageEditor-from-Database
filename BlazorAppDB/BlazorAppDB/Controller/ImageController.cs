using Microsoft.AspNetCore.Mvc;
using BlazorAppDB.Data;
namespace BlazorAppDB.Controller;

[Route("api/[controller]")]
[ApiController]
public class ImageController : ControllerBase
{
    private readonly ImageDbContext _dbContext;

    public ImageController(ImageDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpPost]
    public IActionResult SaveImage([FromForm] string id, [FromForm] IFormFile imageFile)
    {
        if (string.IsNullOrEmpty(id) || imageFile == null || imageFile.Length == 0)
        {
            return BadRequest("Invalid input");
        }

        using (var memoryStream = new MemoryStream())
        {
            // Copy the uploaded file's content into the memory stream
            imageFile.CopyTo(memoryStream);

            // Convert the memory stream into a byte array
            byte[] imageBytes = memoryStream.ToArray();

            // Check if the image already exists
            var existingImage = _dbContext.ImageCollections.FirstOrDefault(i => i.Id == id);
            if (existingImage != null)
            {
                // Update existing record
                existingImage.Name = imageFile.FileName;
                existingImage.ImageData = imageBytes;
            }
            else
            {
                // Add new record
                var imageRecord = new CustomImageData
                {
                    Id = id,
                    Name = imageFile.FileName,
                    ImageData = imageBytes
                };
                _dbContext.ImageCollections.Add(imageRecord);
            }

            _dbContext.SaveChanges();

            return Ok("Image saved successfully");
        }
    }

    [HttpGet("{id}")]
    public IActionResult LoadImage(string id)
    {
        var image = _dbContext.ImageCollections.FirstOrDefault(i => i.Id == id);
        if (image == null)
        {
            return NotFound("Image not found");
        }

        // Convert the byte array to a Base64 string
        var base64Image = Convert.ToBase64String(image.ImageData);
        return Ok(base64Image);
    }

}