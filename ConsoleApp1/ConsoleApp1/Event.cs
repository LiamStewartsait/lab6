using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Event
    {
        public int event_number {  get; set; }
        public string location { get; set; }

        public Event(int event_number, string location)
        {
            this.event_number = event_number;
            this.location = location;
        }
    }
}
