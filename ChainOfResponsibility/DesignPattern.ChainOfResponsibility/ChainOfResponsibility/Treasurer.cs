using DesignPattern.ChainOfResponsibility.DAL;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public class Treasurer : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
           Context context = new Context();

            if (req.Amount <=100000)
            {
                CustomerProcess customerProcess = new();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.Description = "Para Çekim İşlemi Onaylandı.Müşteriye Talep Ettiği Tutar Ödendi.";
                customerProcess.EmployeeName = "Veznedar-Arda Çimen";

                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();

            }
            else if(NextApprover !=null)
            {
                CustomerProcess customerProcess = new();
                customerProcess.Amount =req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Veznedar-Arda Çimen";
                customerProcess.Description = "Para Çekim Tutarı Veznedarın Günlük Ödeyebileceği Limiti İşlemi Aştığı İçin İşlem Şube Müdür Yardımcısına Yönlendirildi.";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(req); //Sonraki onaylayıcıya alınan değerleri gönder.
            }

        }
    }
}
