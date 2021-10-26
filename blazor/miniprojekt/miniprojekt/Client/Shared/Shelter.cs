using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace miniprojekt.Client.Shared
{
    public class Shelter
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        public string geometry { get; set; }
        public string properties { get; set; }
        
        public Shelter(string Id, string Geometry, string Properties)
        {
            _id = Id;
            geometry = Geometry;
            properties = Properties;
        }
    }

    public class Geometry
    {
        public List<List<double>>coordinates { get; set; }

    }

    public class Properties
    {
        public string navn { get; set; }
        public string cvr_navn { get; set; }
        public int kommunekode { get; set; }
        public string status { get; set; }
        public int antal_pl { get; set; }

        public Properties(string Navn, string Cvr_navn, int Kommunekode, string Status, int Antal_pl)
        {
            navn = Navn;
            cvr_navn = Cvr_navn;
            kommunekode = Kommunekode;
            status = Status;
            antal_pl = Antal_pl;
        }
    }




}
