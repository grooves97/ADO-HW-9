using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Railway.DataAcces;
using Railway.Models;

namespace RailWay
{
    public partial class Form1 : Form
    {
        private List<Train> allTrains;
        private List<Train> possibleTrains = new List<Train>();

        object[] cities = new object[]
        {
            City.Astana,City.Aktau, City.Almaty,City.Karaganda,City.Kokshetau
        };
        public Form1()
        {
            InitializeComponent();
            dateTimeDeparture.MinDate = DateTime.Now;
            comboBoxListFrom.Items.AddRange(cities);
            comboBoxListTo.Items.AddRange(cities);
            listBoxLastTickets.HorizontalScrollbar = true;
        }

        private void ButtonFind_Click(object sender, EventArgs e)
        {
            using (var context = new RailwayContext())
            {
                allTrains = context.Trains.ToList();
                foreach (var train in allTrains)
                {
                    if (train.Departure.ToString() == comboBoxListFrom.Text
                        && train.Airrival.ToString() == comboBoxListTo.Text
                        && train.DepartureTime.Date == dateTimeDeparture.Value.Date
                        && train.FreePlaces > 0)
                    {
                        possibleTrains.Add(train);
                        listBoxLastTickets.Items.Add($"{train.Departure} - {train.Airrival}Departure Time{train.DepartureTime}\nArrival Time{train.ArrivalTime}\n\n");
                    }
                }
                if (listBoxLastTickets.Items.Count == 0) MessageBox.Show("Sorry no available train");
            }
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            var train = possibleTrains[listBoxLastTickets.SelectedIndex];
            var passenger = new Passenger();

            Ticket ticket;
            if (textBoxPassengerName.Text.Length != 0)
            {
                passenger.FullName = textBoxPassengerName.Text;
            }
            else MessageBox.Show("You have to enter your name");
            if (listBoxLastTickets.SelectedIndex >= 0)
            {
                ticket = new Ticket
                {
                    //Train = train,
                    TrainId = train.Id,
                    //Passenger = passenger,
                    PassengerId = passenger.Id,
                };
                try { passenger.Tickets.Add(ticket); }
                catch
                {
                    passenger.Tickets = new List<Ticket>();
                    passenger.Tickets.Add(ticket);
                }
                using (var context = new RailwayContext())
                {
                    context.Tickets.Add(ticket);
                    context.Passengers.Add(passenger);
                    var result = context.Trains.SingleOrDefault(t => t.Id == train.Id);
                    context.SaveChanges();
                    MessageBox.Show("Your order has been admitted");
                }
            }
            else MessageBox.Show("You have to choose a ticket");
        }
    }
}
