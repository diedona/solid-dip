using DDona.Solid.DIP.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.Solid.DIP.Model.Notification
{
    public class NotificationManager
    {
        // does not rely on "email" or "sms" concrete
        // only on an abstract interface
        private readonly List<ISendMessage> _messagesToBeSent;

        public NotificationManager(List<ISendMessage> messagesToBeSent)
        {
            _messagesToBeSent = messagesToBeSent;
        }

        public string SendMessages()
        {
            StringBuilder sb = new StringBuilder();

            foreach (ISendMessage message in _messagesToBeSent)
            {
                sb.AppendLine(message.SendMessage());
            }

            return sb.ToString();
        }
    }
}
