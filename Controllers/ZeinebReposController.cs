using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace ExerciceLidlet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ZeinebReposController : ControllerBase
    {
        public HttpClient client;
        public HttpContext rqt;
        [HttpGet]
        [EnableQuery]
        public async Task<string>  Get()
        {
            var x = new ZeinebRepos();

            return await x.getProjects(); 
        }
    }
}