using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1Week5.Models
{
    internal class Booking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookingID {  get; set; }

        [MaxLength(50)]
        public string Name { get; set; }
        public DateTime BookingDate { get; set;}
        public TimeSpan BookingTime { get; set;}

      
    }
}
