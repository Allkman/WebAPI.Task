using System.Net;
using System.Net.Mail;
using System.Text.Json;
using Task.Application.FactoryServices.Interfaces;
using Task.Shared.DTOs;

namespace Task.Application.FactoryServices
{
    public class EmailFactory : IEmailFactory
    {
        public void Create(EventDTO instance)
        {

            string emailBody = JsonSerializer.Serialize(instance);

            var smtpClient = new SmtpClient("smtp.mailgun.org")
            {
                Port = 587,
                Credentials = new NetworkCredential("postmaster@sandbox87557b45e98d413dbdd5b159e93c2487.mailgun.org", "1bdfb4d7b926f0e72b7f4b24697b4f88-45f7aa85-a7cda0f8"),
                EnableSsl = true,
            };

            smtpClient.Send(
                "postmaster@sandbox87557b45e98d413dbdd5b159e93c2487.mailgun.org",
                "juskysgytis@gmail.com",
                "WebAPI homework request",
                $"{emailBody}"
                );
        }
    }
}
