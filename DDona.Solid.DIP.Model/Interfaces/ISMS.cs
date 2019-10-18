using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.Solid.DIP.Model.Interfaces
{
    public interface ISMS : ISendMessage
    {
        string PhoneNumber { get; set; }
        string Message { get; set; }
    }
}
