using DDona.Solid.DIP.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.Solid.DIP.Model.Specialization
{
    public class Email : IEmail
    {
        public string ToAddress { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }

        public string SendMessage()
        {
            // pretend we are sending email...
            return $"Sending email to {this.ToAddress}, Subject: {this.Subject}";
        }
    }
}
