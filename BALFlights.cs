﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightsBAL
{
    public class BALFlights
    {
        public int FlightId { get; set; }
        public string FlightName { get; set; }
        public DateTime FlightArrival { get; set; }
        public DateTime FlightDeparture { get; set; }
        public int PassengersCount { get; set; }
        public int CaptainID { get; set; }
    }
    public class PassengerBAL
    {
        public int PassId { get; set; }
        public string PassName { get; set; }
        public int PassAge { get; set; }
        public int FlightId { get; set; }
        public int TicketNo { get; set; }
    }
}
