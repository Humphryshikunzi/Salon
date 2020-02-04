﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Salon.Models
{
    class Salonist
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public  string  ProfileImageUri { get; set; }
        public  Image  Image { get; set; }
    }
}
