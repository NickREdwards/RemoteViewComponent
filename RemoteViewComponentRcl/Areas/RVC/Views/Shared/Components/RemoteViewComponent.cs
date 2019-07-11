using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace RemoteViewComponentRcl.Areas.RVC.Views.Shared.Components
{
    public class RemoteViewComponent : ViewComponent
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public RemoteViewComponent(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<IViewComponentResult> InvokeAsync(string url)
        {
            var httpClient = new HttpClient();
            HttpRequest httpRequest = _httpContextAccessor.HttpContext.Request;

            httpClient.BaseAddress = new Uri($"{httpRequest.Scheme}://{httpRequest.Host}{httpRequest.PathBase}");
            HttpResponseMessage result = await httpClient.GetAsync(url);
            return new HtmlContentViewComponentResult(new HtmlString(await result.Content.ReadAsStringAsync()));
        }
    }
}