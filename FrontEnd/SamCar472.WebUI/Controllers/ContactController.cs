using MailKit.Net.Smtp;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using SamCar472.Application.Features.Mediator.Commands.ContactCommands;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace SamCar472.WebUI.Controllers
{
    public class ContactController : Controller
    {
        private readonly IMediator _mediator;
        public ContactController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(CreateContactCommand command)
        {
            MimeMessage mimeMessage = new MimeMessage();
            MailboxAddress mailboxAddressFrom = new MailboxAddress("SamCar", command.Email );
            MailboxAddress mailboxAddressTo = new MailboxAddress("User", "nexorevolutionn@gmail.com");

            mimeMessage.From.Add(mailboxAddressFrom);
            mimeMessage.To.Add(mailboxAddressTo);

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = command.Name + "tarafından bir mesajınız var";
            mimeMessage.Body = bodyBuilder.ToMessageBody();

            mimeMessage.Subject = command.Subject;

            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587, false);
            client.Authenticate("nexorevolutionn@gmail.com", "bcfu hpro lcfj ynmy");
            client.Send(mimeMessage);
            client.Disconnect(true);

            await _mediator.Send(command);

            return View();
        }
    }
}
