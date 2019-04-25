using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Railway.Models
{
    public class Passenger : Entity
    {
        public string FullName { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
