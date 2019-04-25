using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Railway.Models
{
    public class Train : Entity
    {
        public City Departure { get; set; }
        public DateTime DepartureTime { get; set; }
        public City Airrival { get; set; }
        public DateTime ArrivalTime { get; set; }
        public int FreePlaces { get; set; }
    }
}
