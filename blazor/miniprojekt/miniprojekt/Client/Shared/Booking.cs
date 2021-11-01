using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace miniprojekt.Client.Shared
{
    public class Booking
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        private DateTime startdate { get; set; }
        private DateTime slutdate { get; set; }
        private int antal_pers { get; set; }
        private string shelter_id { get; set; }
        private string bruger_id { get; set; }
        public int booking_id { get; set; }



        public Booking( DateTime Startdate, DateTime Slutdate, int Antal_pers, string Shelter_id, string Bruger_id)
        {
            startdate = Startdate;
            slutdate = Slutdate;
            antal_pers = Antal_pers;
            shelter_id = Shelter_id;
            bruger_id = Bruger_id;
        }




    }
}
