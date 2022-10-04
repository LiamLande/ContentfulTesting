using Contentful.Core;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace Contenful_Test.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IContentfulClient _contentClient;
        public IndexModel(IContentfulClient contentClient)
        {
            _contentClient = contentClient;
        }
        public class ImageObj
        {
            public string Name { get; set; } = "";
            public string Description { get; set; } = "";
            public string ImageUrl { get; set; } = "";
        }
        public List<ImageObj> imageList = new List<ImageObj>();

        public static HttpClient Client = new HttpClient();
        public async Task OnGetAsync()
        {
            var contentTask = _contentClient.GetAssets();
            var assets = await contentTask;

            foreach (var asset in assets.Items.OrderBy(asset => asset.Title))
            {
                var img = new ImageObj();
                img.Name = asset.Title;
                img.Description = asset.Description;
                img.ImageUrl = asset.File.Url;

                imageList.Add(img);
            }
        }
    }
}