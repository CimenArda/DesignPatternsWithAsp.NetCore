using DesignPattern.Facade.DAL;

namespace DesignPattern.Facade.Facade
{
    public class AddOrderDetail
    {
        Context context = new Context();

        public void addNewOrderDetail(OrderDetail orderDetail)
        {
            context.OrderDetails.Add(orderDetail);
            context.SaveChanges();
        }
    }
}
