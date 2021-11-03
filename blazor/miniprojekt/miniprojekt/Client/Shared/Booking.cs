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
        public DateTime startdate { get; set; }
        public DateTime slutdate { get; set; }
        public int antal_pers { get; set; }
        public string shelter_id { get; set; }
        public string navn { get; set; }
        public string telefon { get; set; }
        public string email { get; set; }
        public int booking_id { get; set; }
        public DateTime booking_date { get; set; }



        public Booking(DateTime Startdate, DateTime Slutdate, int Antal_pers, string Shelter_id, string Navn, string Telefon, string Email)
        {
            startdate = Startdate;
            slutdate = Slutdate;
            antal_pers = Antal_pers;
            shelter_id = Shelter_id;
            navn = Navn;
            telefon = Telefon;
            email = Email;
        }


        public Booking()
        {

        }

    }
}
