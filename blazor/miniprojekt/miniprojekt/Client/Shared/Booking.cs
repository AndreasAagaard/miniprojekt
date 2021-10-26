using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miniprojekt.Client.Shared
{
    public class Booking
    {
        private string _id;
        private DateTime startdate;
        private DateTime slutdate;
        private int antal_pers;
        private string shelter_id;
        private string bruger_id;


        public Booking()
        {

        }

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public DateTime Startdate
        {
            get { return startdate; }
            set { startdate = value; }
        }
        public DateTime Slutdate
        {
            get { return slutdate; }
            set { slutdate = value; }
        }
        public int Antal_pers
        {
            get { return antal_pers; }
            set { antal_pers = value; }
        }
        public string Shelter_id
        {
            get { return shelter_id; }
            set { shelter_id = value; }
        }
        public string Bruger_id
        {
            get { return bruger_id; }
            set { bruger_id = value; }
        }




    }
}
