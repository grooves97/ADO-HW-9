using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Railway.Models
{
    public class Ticket : Entity
    {
        public Guid TrainId { get; set; }
        public virtual Train Train { get; set; }
        public Guid PassengerId { get; set; }
        public virtual Passenger Passenger { get; set; }
    }
}
