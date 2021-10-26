using miniprojekt.Shared;
using miniprojekt.Server;
using miniprojekt.Client.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using Microsoft.Extensions.Logging;
using System.IO;
using System.Text.Json;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace miniprojekt.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShelterControler : ControllerBase
    {
        string url = "shelter.json";

        private readonly ILogger<ShelterControler> logger;

        public ShelterControler(ILogger<ShelterControler> logger)
        {
            this.logger = logger;
        }

        public List<Shelter> LoadJson()
        {
            using (StreamReader r = new StreamReader(url))
            {
                string json = r.ReadToEnd();
                List<Shelter> items = JsonConvert.DeserializeObject<List<Shelter>>(json);
                return items;
            }
        }

        [HttpGet]
        public IEnumerable<Shelter> Get()
        {
            return LoadJson();
        }

    }
}
