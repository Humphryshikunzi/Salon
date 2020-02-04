using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Salon.Models
{
    class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductImageUri { get; set; }
        public decimal Price { get; set; }

        public  Image  Image { get; set; }

    }
}
