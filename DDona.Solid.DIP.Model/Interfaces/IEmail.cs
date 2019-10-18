using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.Solid.DIP.Model.Interfaces
{
    public interface IEmail : ISendMessage
    {
        string ToAddress { get; set; }
        string Subject { get; set; }
        string Content { get; set; }
    }
}
