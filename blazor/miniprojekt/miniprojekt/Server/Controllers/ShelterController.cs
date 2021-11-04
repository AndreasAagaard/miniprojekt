using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using miniprojekt.Client.Shared;
using miniprojekt.Shared;
using MongoDB.Bson;
using MongoDB.Driver;

namespace miniprojekt.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class ShelterController : ControllerBase
    {
        private IMongoCollection<shelter> _sheltercollection;

        public ShelterController(IMongoClient client)
        {
            var database = client.GetDatabase("shelterdb");
            _sheltercollection = database.GetCollection<shelter>("shelter");

        }

        [HttpGet]
        public IEnumerable<shelter> Get()
        {
            return _sheltercollection.Find(s => s.status == "Gældende / Vedtaget").ToList();
        }

        [HttpGet("{id:length(24)}", Name = "GetShelter")]
        public ActionResult<shelter> Get(string id)
        {
            return _sheltercollection.Find(s => s._id == id).FirstOrDefault();
        }
    }
}
