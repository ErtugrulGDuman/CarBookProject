﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBookProject.WebUI.ViewComponents.UILayoutViewComponents
{
    public class _FooterUILayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
        //private readonly IHttpClientFactory _httpClientFactory;
        //public _FooterUILayoutComponentPartial(IHttpClientFactory httpClientFactory)
        //{
        //    _httpClientFactory = httpClientFactory;
        //}
        //public async Task<IViewComponentResult> InvokeAsync()
        //{
        //    var client = _httpClientFactory.CreateClient();
        //    var responseMessage = await client.GetAsync("https://localhost:7265/api/FooterAddresses");
        //    if (responseMessage.IsSuccessStatusCode)
        //    {
        //        var jsonData = await responseMessage.Content.ReadAsStringAsync();
        //        var values = JsonConvert.DeserializeObject<List<ResultFooterAddressDto>>(jsonData);
        //        return View(values);
        //    }
        //    return View();
        //}
    }
}
