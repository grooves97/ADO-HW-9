namespace Railway.DataAcces
{
    using Railway.Models;
    using System;
    using System.Data.Entity;

    public class RailwayContext : DbContext
    {
        public RailwayContext()
            : base("name=RailwayContext")
        {
        }
        public virtual DbSet<Passenger> Passengers { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<Train> Trains { get; set; }
    }
}