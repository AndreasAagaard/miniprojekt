using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace miniprojekt.Client.Shared
{
    public class Bruger
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        public string navn { get; set; }
        public string adresse { get; set; }
        public int telefonnr { get; set; }
        public string email { get; set; }
        public bool admin { get; set; }

        public Bruger(string Id, string Navn, string Adresse, int Telefonnr, string Email, bool Admin)
        {
            _id = Id;
            navn = Navn;
            adresse = Adresse;
            telefonnr = Telefonnr;
            email = Email;
            admin = Admin;
        }
    }

    public class Admin
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        public string kommune { get; set; }

        public Admin(string Id, string Kommune)
        {
            _id = Id;
            kommune = Kommune;
        }
    }
}
