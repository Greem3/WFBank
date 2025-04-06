using RestSharp;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Mail;

namespace Bank
{
    public class TestmailApiClient
    {
        private readonly string _apiKey;
        private readonly string _namespace;
        private readonly RestClient _client;

        public TestmailApiClient(string apiKey = "5e063c6c-d28f-428d-aaa8-0cd42b255d76", string @namespace = "qznu9")
        {
            _apiKey = apiKey;
            _namespace = @namespace;
            _client = new RestClient("https://api.testmail.app/api/json");
        }

        public EmailResponse GetEmails(string tag = null)
        {
            var request = new RestRequest();
            request.AddQueryParameter("apikey", _apiKey);
            request.AddQueryParameter("namespace", _namespace);

            if (!string.IsNullOrEmpty(tag))
            {
                request.AddQueryParameter("tag", tag);
            }

            var response = _client.Get(request);

            if (!response.IsSuccessful)
            {
                throw new Exception($"Error al obtener emails: {response.ErrorMessage}");
            }

            return JsonConvert.DeserializeObject<EmailResponse>(response.Content);
        }
        
        public void SendTestEmail(string tag)
        {
            // Configura el cliente SMTP (usa tu proveedor de email)
            var smtpClient = new SmtpClient("smtp-mail.outlook.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("ianpichardo575@gmail.com", "ydwdwjvwioeaemiq"),
                EnableSsl = true,
                UseDefaultCredentials = false,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Timeout = 10000
            };

            // Construye la dirección para Testmail
            string testmailAddress = $"{_namespace}.{tag}@inbox.testmail.app";

            using (MailMessage mailMessage = new MailMessage(
                       from: new MailAddress("FakeMail@fake.com", "Bank FI"),
                       to: new MailAddress(testmailAddress)
                   )
                   {
                       Subject = "Prueba de correo",
                       Body = "Este es un correo de prueba enviado desde Testmail API.",
                       Priority = MailPriority.Normal,
                   }
                   )
            {
                mailMessage.Headers.Add("X-Mailer", "Microsoft Outlook");

                smtpClient.Send(mailMessage);
            }
        }
    }

    public class EmailResponse
    {
        [JsonProperty("emails")]
        public Email[] Emails { get; set; }
    }

    public class Email
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    
        [JsonProperty("from")]
        public string From { get; set; }
    
        [JsonProperty("to")]
        public string To { get; set; }
    
        [JsonProperty("subject")]
        public string Subject { get; set; }
    
        [JsonProperty("text")]
        public string Text { get; set; }
    
        [JsonProperty("html")]
        public string Html { get; set; }
    
        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }
    }
}