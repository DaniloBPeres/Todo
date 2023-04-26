using System.Net;
using System.Net.Mail;
using Todo.API.Interfaces;
using Todo.API.Models.DTOs;
using Todo.API.Models.Entities;

namespace Todo.API.Repository
{
    public class EmailRepository : BaseRepository, IEmailRepository
    {
        private readonly TodoContext _context;

        public EmailRepository(TodoContext context) : base(context)
        {
            _context = context;
        }

        public bool CreateEmailConfirm(string email)
        {
            AwaitEmailConfirmDTO key = CreateKeyConfirm(email);
            if (!string.IsNullOrEmpty(key.CodeToConfirm))
            {
                MailMessage message = new("remember.todo@outlook.com", email);
                message.Subject = "Confirme seu e-mail";
                message.Body = $"<!DOCTYPE html>\r\n<html>\r\n<head>\r\n\t<title>Confirmação de E-mail</title>\r\n\t<meta charset=\"utf-8\">\r\n\t<meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n\t<style>\r\n\t\tbody {{\r\n\t\t\tbackground-color: #f4f4f4;\r\n\t\t\tfont-family: Arial, sans-serif;\r\n\t\t\tfont-size: 16px;\r\n\t\t\tline-height: 1.5;\r\n\t\t\tcolor: #555;\r\n\t\t\tmargin: 0;\r\n\t\t\tpadding: 0;\r\n\t\t}}\r\n\t\t.container {{\r\n\t\t\tmax-width: 600px;\r\n\t\t\tmargin: 0 auto;\r\n\t\t\tpadding: 20px;\r\n\t\t\tbox-sizing: border-box;\r\n\t\t}}\r\n\t\th1 {{\r\n\t\t\tfont-size: 24px;\r\n\t\t\tmargin-top: 0;\r\n\t\t\ttext-align: center;\r\n\t\t}}\r\n\t\tp {{\r\n\t\t\tmargin-bottom: 20px;\r\n\t\t}}\r\n\t\th3 {{\r\n\t\t\tbackground-color: #0095ff;\r\n\t\t\tcolor: #fff;\r\n            text-align: center;\r\n\t\t\ttext-decoration: none;\r\n\t\t\tpadding: 10px 20px;\r\n\t\t\tborder-radius: 5px;\r\n\t\t\tmargin-top: 20px;\r\n\t\t}}\r\n\t</style>\r\n</head>\r\n<body>\r\n\t<div class=\"container\">\r\n\t\t<h1>Confirmação de E-mail</h1>\r\n\t\t<p>Olá, {key.UserName},</p>\r\n\t\t<p>Obrigado por se inscrever em nosso serviço! Seu cadastro foi recebido com sucesso!</p>\r\n\t\t<p>Para confirmar seu cadastro, basta inserir o código abaixo na página que foi redirecionado:</p>\r\n\t\t<h3>{key.CodeToConfirm}</h3>\r\n\t\t<p>Se você não se inscreveu em nosso serviço, por favor, ignore este e-mail.</p>\r\n\t\t<p>Obrigado,</p>\r\n\t\t<p>A fazer!</p>\r\n\t</div>\r\n</body>\r\n</html>\r\n";
                message.IsBodyHtml = true;
                SmtpClient client = new SmtpClient("smtp.office365.com", 587);
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential("remember.todo@outlook.com", "remembertodo123");
                client.Send(message);
                return true;
            }
            else
                return false;
        }

        public bool CreateEmailRecoverPass()
        {
            throw new NotImplementedException();
        }

        private AwaitEmailConfirmDTO CreateKeyConfirm(string email)
        {
            var person = _context.Person.Single(x => x.Email == email);
            if (person != null) 
            {
                string keyConfirm = Guid.NewGuid().ToString();
                EmailConfirm emailConfirm = new EmailConfirm()
                {
                    Email = email,
                    Code_confirm = keyConfirm,
                    Has_confirmed = false,
                    PersonId = person.Id
                };
                Add(emailConfirm);
                SaveChanges();
                return new AwaitEmailConfirmDTO() { CodeToConfirm = keyConfirm, Email = email, UserName = person.User_name};
            }
            else
            {
                return new AwaitEmailConfirmDTO();
            }
        }
    }
}
