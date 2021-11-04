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

    public class BookingController : ControllerBase
    {
        private IMongoCollection<Booking> _bookingcollection;

        public BookingController(IMongoClient client)
        {
            var database = client.GetDatabase("shelterdb");
            _bookingcollection = database.GetCollection<Booking>("booking");

        }

        [HttpGet]
        public IEnumerable<Booking> Get()
        {
            return _bookingcollection.Find(b => true).ToList();
        }

        [HttpGet("{id:length(24)}", Name = "GetBooking")]
        public Booking Get(string id)
        {
            return _bookingcollection.Find(b => b._id == id).FirstOrDefault();
        }

        [HttpPost]
        public string Post(Booking booking)
        {
            int antalBooking = _bookingcollection.AsQueryable().Count();
            booking.booking_id = antalBooking + 1;
            _bookingcollection.InsertOneAsync(booking);

            return "Added Succesfully";
        }

        [HttpPut]
        public string Put(string id)
        {
            var filter = Builders<Booking>.Filter.Eq("shelter_id", BsonNull.Value);
            var update = Builders<Booking>.Update.Set("shelter_id", id);

            return "Updated Succesfully";
        }

        [HttpDelete("{id:length(24)}", Name = "DeleteBooking")]
        public IActionResult Delete(string id)
        {
            var filter = Builders<Booking>.Filter.Eq("_id", id);
            _ = _bookingcollection.DeleteOne(filter);
            return NoContent();
            
        }
    }
}
