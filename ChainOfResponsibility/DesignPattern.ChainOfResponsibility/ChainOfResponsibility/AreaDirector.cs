using DesignPattern.ChainOfResponsibility.DAL;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public class AreaDirector : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            Context context = new Context();

            if (req.Amount <= 400000)
            {
                CustomerProcess customerProcess = new CustomerProcess();

                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.Description = "Para Çekim İşlemi Onaylandı.Müşteriye Talep Ettiği Tutar Ödendi.";
                customerProcess.EmployeeName = "Bölge Müdürü-Zeynep Güneş";

                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();

            }
            else
            {
                CustomerProcess customerProcess = new();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Bölge Müdürü-Zeynep Güneş";
                customerProcess.Description = "Para Çekim Tutarı Bölge Müdürünün Günlük Ödeyebileceği Limiti İşlemi Aştığı İçin İşlem Gerçekleştirilemedi.Daha Fazla Çekim Yapmak İçin Müşteri Birden Fazla Gün Gelmeli";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
        }
    }
}
