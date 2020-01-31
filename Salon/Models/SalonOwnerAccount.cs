using System;
using System.Collections.Generic;
using System.Text;

namespace Salon.Models
{
    class SalonOwnerAccount
    {
        public int Id { get; set; }
        public string NameOfSalon { get; set; }
        public string City { get; set; }
        public int NumberOfSalonists { get; set; }
        public  string  SalonImageUri { get; set; }
        public  int  NoOfDayWorkingHours { get; set; }
    }
}
