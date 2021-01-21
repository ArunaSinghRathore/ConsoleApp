using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TodoApi.Controllers
{

    [Route("[controller]")]
    public class BookingController : ControllerBase
    {
        List<Stadium> stadiums = new List<Stadium>() 
                                 {
                                    new Stadium { 
                                        id =1,
                                        Name = "Sahara", 
                                        TimeSlot = TimeSlot.Morning.ToString("G") ,
                                        Status = Status.Free},
                                                             
                                    new Stadium { 
                                        id =2,
                                        Name = "Subrato", 
                                        TimeSlot = TimeSlot.Afternoon.ToString("G") , 
                                        Status = Status.Free}
                                    };
        private readonly ILogger<BookingController> _logger;

        public BookingController(ILogger<BookingController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        //public  IEnumerable<Stadium> Get()
        public  string Get()

        {
           var date = getDate(); //understand async await calls       
           
           var currenDate = DateTimeOffset.Now.Date; 
           var totalDates = currenDate.AddDays(1);
           
         
          // return stadiums.Where(stadium=>stadium.Status == Status.Free);
         return "t";
        }

        private async Task<DateTime> getDate()
        {
           var currenDate = DateTimeOffset.Now.Date; 
           //await Task.Run(() => Task.Delay(10));
           
           return currenDate;
        }

        // [HttpPut("{id}")]
        // public  IEnumerable<Stadium> UpdateStatus(int id)
        // { 
        //     var stadium = stadiums.Find(x=>x.id == id);
        //     stadium.Status = Status.Booked;
            
        //     return Get();
        // }
    }
}
