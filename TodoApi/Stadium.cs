using System;

namespace TodoApi
{
    
    public class Stadium
    {
        
        public DateTimeOffset Date { get; set; } = DateTimeOffset.Now.Date;

        public string Name { get; set; }

        public Status Status { get; set; }

        public string TimeSlot { get; set; }

        public int id { get; set; }


        
    }

  
    public enum Status
    {
        Free,
        Booked
    }

 
    public enum TimeSlot
    {
        Morning,
        Afternoon,

        Evening
    }
}