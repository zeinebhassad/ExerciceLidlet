using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ExerciceLidlet
{
    public class ZeinebRepos
    {

        private readonly HttpContext request;
        string BaseUrl = "https://api.lidlet.com/project";
        public HttpClient client = new HttpClient();

        public async Task<string> getProjects()
        {
            //string cookieValueFromContext = _httpContextAccessor.HttpContext.Request.Cookies["key"];
            //string cookies = request.Request.Headers.Add("");
            client.DefaultRequestHeaders.Add("cookie", "_ga=GA1.2.1396552231.1580301658; _gid=GA1.2.1498694230.1580301658; session=1195fa613a14b3ca55aed54e4b05e811");
            HttpResponseMessage httpResponse = await client.GetAsync(BaseUrl);
            string body = await httpResponse.Content.ReadAsStringAsync();
            List<Projet> Projects = JsonConvert.DeserializeObject<List<Projet>>(body);
            return Projects.First().name;
    }
}
    }


