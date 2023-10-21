using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HDC.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly HttpClient _httpClient;
        public string CatUrl { get; } = "http://host.docker.internal:50003";
        public string DogUrl { get; } = "http://host.docker.internal:50005";
        public string FishUrl { get; } = "http://host.docker.internal:50007";

        public bool CatHealthy { get; set; }
        public bool DogHealthy { get; set; }
        public bool FishHealthy { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            _httpClient = new HttpClient();
        }

        public async Task OnGet()
        {
            CatHealthy = await CheckHealth($"{CatUrl}/Health");
            DogHealthy = await CheckHealth($"{DogUrl}/Health");
            FishHealthy = await CheckHealth($"{FishUrl}/Health");
        }

        private async Task<bool> CheckHealth(string url)
        {
            try
            {
                return (await _httpClient.GetAsync(url)).IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}