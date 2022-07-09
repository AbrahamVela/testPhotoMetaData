using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PhotoMetaData.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

            //using (var image = new MagickImage("C:\\Users\\Abraham\\Desktop\\testPhotoMetaData\\PhotoMetaData\\PhotoMetaData\\wwwroot\\Image\\DallasCowboys.jpg"))
            //{
            //    // Retrieve the exif information
            //    var profile = image.GetExifProfile();

            //    // Check if image contains an exif profile
            //    if (profile is null)
            //        Console.WriteLine("Image does not contain exif information.");
            //    else
            //    {
            //        // Write all values to the console
            //        foreach (var value in profile.Values)
            //        {
            //            Console.WriteLine("{0}({1}): {2}", value.Tag, value.DataType, value.ToString());
            //        }
            //    }
            //}
        }

    }
}