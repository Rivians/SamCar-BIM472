using MailKit.Net.Smtp;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using SamCar472.Application.Features.Mediator.Commands.AppUserCommands;
using SamCar472.Dto.RegisterDtos;

namespace SamCar472.WebUI.Controllers
{
    public class RegisterController : Controller
    {
        private readonly IMediator _mediator;
        public RegisterController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(CreateAppUserCommand command)
        {
            if(command != null)
            {
                MimeMessage mimeMessage = new MimeMessage();
                MailboxAddress mailboxAddressFrom = new MailboxAddress("SamCar", "nexorevolutionn@gmail.com");
                MailboxAddress mailboxAddressTo = new MailboxAddress("User", command.Email);

                mimeMessage.From.Add(mailboxAddressFrom);
                mimeMessage.To.Add(mailboxAddressTo);

                var bodyBuilder = new BodyBuilder();
                bodyBuilder.TextBody = "Sevgili " + command.Name + ". Kayıt işleminiz Başarıyla Gerçekleştirilmiştir";
                mimeMessage.Body = bodyBuilder.ToMessageBody();

                mimeMessage.Subject = "SamCar Kayıt İşlemi";

                SmtpClient client = new SmtpClient();
                client.Connect("smtp.gmail.com", 587, false);
                client.Authenticate("nexorevolutionn@gmail.com", "bcfu hpro lcfj ynmy");
                client.Send(mimeMessage);
                client.Disconnect(true);

                await _mediator.Send(command);
                return RedirectToAction("Index","Login");
            }
            else 
            {
                return View(); 
            }
        }
    }
}
