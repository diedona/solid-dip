using DDona.Solid.DIP.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.Solid.DIP.Model.Specialization
{
    public class SMS : ISMS
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }

        public string SendMessage()
        {
            // pretend we are sending sms...
            return $"Sending SMS to {this.PhoneNumber}";
        }
    }
}
