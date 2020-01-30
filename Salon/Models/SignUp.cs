using System;
using System.Collections.Generic;
using System.Text;

namespace Salon.Models
{
    class SignUp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ModeOfSignUp { get; set; }
        public bool IsTermsAndConditionsCheckBoxChecked { get; set; }
    }
}
