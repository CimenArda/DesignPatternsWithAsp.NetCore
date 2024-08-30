using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public abstract class Employee
    {
        protected Employee NextApprover;


        public void setNextApprover(Employee SuperVisor)
        {
            this.NextApprover = SuperVisor;
        }

        public abstract void ProcessRequest(CustomerProcessViewModel req);
    }
}
