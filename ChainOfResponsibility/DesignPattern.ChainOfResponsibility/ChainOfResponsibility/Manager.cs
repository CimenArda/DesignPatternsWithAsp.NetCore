using DesignPattern.ChainOfResponsibility.DAL;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public class Manager : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            Context context = new Context();

            if (req.Amount <= 250000)
            {
                CustomerProcess customerProcess = new CustomerProcess();

                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.Description = "Para Çekim İşlemi Onaylandı.Müşteriye Talep Ettiği Tutar Ödendi.";
                customerProcess.EmployeeName = "Şube Müdürü-Elvin Şimşek";

                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();

            }
            else if (NextApprover != null)
            {
                CustomerProcess customerProcess = new();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Şube Müdürü-Elvin Şimşek";
                customerProcess.Description = "Para Çekim Tutarı Şube Müdürünün Günlük Ödeyebileceği Limiti İşlemi Aştığı İçin İşlem Bölge Müdürüne Yönlendirildi.";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(req); //Sonraki onaylayıcıya alınan değerleri gönder.
            }
        }
    }
}
