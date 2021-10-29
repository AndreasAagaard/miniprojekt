using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace miniprojekt.Client.Shared
{
    [BsonIgnoreExtraElements]
    public class shelter
    {
        [BsonId]
        public ObjectId _id { get; set; }

        [BsonElement("type")]
        public string FeatureType { get; set; }

        [BsonElement("geometry")]
        public object geometry { get; set; }

        [BsonElement("properties")]
        public object properties { get; set; }

        [BsonElement("properties.status")]
        public string status { get; set; }        
        
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
