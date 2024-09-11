using DesignPattern.Decorator.DAL;
using DesignPattern.Decorator.DecoratorPattern2;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using System.Net.Mail;

namespace DesignPattern.Decorator.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            DAL.Message message = new DAL.Message();
            message.MessageContent = "Bu bir content Mesajıdır";
            message.MessageSender = "İK";
            message.MessageReceiver = "HERKES";
            message.MessageSubject = "DENEME YAPIYORUZ";

            CreateNewMessage createNewMessage = new CreateNewMessage();
            createNewMessage.SendMessage(message);
            return View();
        }
        public IActionResult Index2()
        {
            DAL.Message message = new DAL.Message();

            message.MessageSender = "İnsan Kaynakları Subjecct";
            message.MessageReceiver = "Yazılım Ekibi";
            message.MessageContent = "Saat 12.00'de toplantı var.";
            message.MessageSubject = "Toplantı";
            CreateNewMessage createNewMessage = new CreateNewMessage();

            EncryptoBySubjectDecorator encryptoBySubjectDecorator =new EncryptoBySubjectDecorator(createNewMessage);
            encryptoBySubjectDecorator.SendMessageByEncryptotoSubject(message);
            return View();
        }

        [HttpGet]
        public IActionResult Index3()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Index3(DAL.Message message)
        {
            CreateNewMessage createNewMessage = new CreateNewMessage();
            createNewMessage.SendMessage(message);
            return View();

        }










    }
}
