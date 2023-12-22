using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1Week5.Models
{
    internal class Space
    {
        private TimeSpan spaceTime;
        private DateTime date;
        private TimeSpan timeSpan;
        private int v1;
        private string v2;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SpaceID { get; set; }

        public DateTime SpaceDate { get; set; }

        public TimeSpan SpaceTime { get; set; }

        public double AvaliableSpace { get; set; }
        public string SpaceDay { get; set; }
        public ICollection<Booking> bookings { get; set; }

        public Space (DateTime spaceDate, TimeSpan spaceTime, double avaliableSpace, string spaceDay, ICollection<Booking> bookings)
        {
            
            SpaceDate = spaceDate;
            SpaceTime = spaceTime;
            AvaliableSpace = avaliableSpace;
            SpaceDay = spaceDay;
            this.bookings = bookings;
        }

        public Space(DateTime date, TimeSpan timeSpan, int v1, string v2)
        {
            this.date = date;
            this.timeSpan = timeSpan;
            this.v1 = v1;
            this.v2 = v2;
        }

        public bool IsSpaceAvaliable (DateTime BookingDate , TimeSpan SpaceTime, DateTime spaceDate, string spaceDay)
        {
            bool isDayValid = spaceDay != "Friday" && spaceDay != "starday";
            bool isTimeValid = spaceTime >= new  TimeSpan (8,0,0) && spaceTime <= new TimeSpan(10,0,0);

            return isDayValid &&
                spaceDate == BookingDate && isTimeValid && AvaliableSpace > 0;


        }

        internal bool IsSpaceAvaliable(DateTime bookingDate, TimeSpan bookingTime)
        {
            throw new NotImplementedException();
        }
    }
}
