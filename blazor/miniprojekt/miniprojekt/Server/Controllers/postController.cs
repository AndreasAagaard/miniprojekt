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

    public class postController : ControllerBase
    {
        private IMongoCollection<Booking> _bookingcollection;

        public postController(IMongoClient client)
        {
            var database = client.GetDatabase("shelterdb");
            _bookingcollection = database.GetCollection<Booking>("booking");

        }

        [HttpGet]
        public IEnumerable<Booking> Get()
        {
            return _bookingcollection.Find(b => b.booking_id > 0).ToList();
        }

        [HttpPost]
        public string Post(Booking booking)
        {
            int antalBooking = _bookingcollection.AsQueryable().Count();
            booking.booking_id = antalBooking + 1;
            _bookingcollection.InsertOneAsync(booking);

            return "Added Succesfully";
        }

    }
}
