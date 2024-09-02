using DesignPattern.Observer.DAL;
using System;

namespace DesignPattern.Observer.Observer
{
    public class CreateMagazineAnnocuncement : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new Context();

        public CreateMagazineAnnocuncement(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser appUser)
        {
            context.UserProcesses.Add(new UserProcess
            {
                NameSurname = appUser.Name + " " + appUser.Surname,
                Magazine = "Bilim Dergisi",
                Content = "Bilim Dergimizin Ekim Sayısı 1 Ekimde evinize ulaştırılacaktır.Konu Başlıkları:Kara Delik,Mars ve Dünya,Roketler"
            });
            context.SaveChanges();
        }
    }
}
