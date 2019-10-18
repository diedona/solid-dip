using DDona.Solid.DIP.Model.Interfaces;
using DDona.Solid.DIP.Model.Notification;
using DDona.Solid.DIP.Model.Specialization;
using System;
using System.Collections.Generic;

namespace DDona.Solid.DIP.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ISendMessage> messages = new List<ISendMessage>()
            {
                new Email(){ Content = "I LOV U", Subject = "To my dearest", ToAddress = "johny@bravo.com" },
                new Email(){ Content = "Hello there, did you see my email?", Subject = "URGENT!!!", ToAddress = "some@manager.com"},
                new SMS(){ Message = "Bring bread", PhoneNumber = "+55199388383838"}
            };

            NotificationManager manager = new NotificationManager(messages);
            Console.WriteLine(manager.SendMessages());
        }
    }
}
