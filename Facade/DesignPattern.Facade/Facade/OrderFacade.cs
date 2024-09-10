using DesignPattern.Facade.DAL;

namespace DesignPattern.Facade.Facade
{
    public class OrderFacade
    {
       Order order = new Order();
       OrderDetail orderDetail = new OrderDetail();
       ProductStock productStock = new ProductStock();

        AddOrder addOrder = new AddOrder();
        AddOrderDetail addOrderDetail = new AddOrderDetail();


        public void CompleteOrderDetail (int CustomerID,int ProductID,int OrderID,int ProductCount,decimal ProductPrice)
        {
            

            orderDetail.CustomerID = CustomerID;
            orderDetail.ProductID = ProductID;  
            orderDetail.OrderID = OrderID;  
            orderDetail.ProductPrice = ProductPrice;
            orderDetail.ProductCount = ProductCount;
            decimal TotalProductPrice = ProductCount * ProductPrice;
            orderDetail.ProductTotalPrice = TotalProductPrice;
            addOrderDetail.addNewOrderDetail(orderDetail);


            productStock.StockDecrease(ProductID, ProductCount);


        }

        public void CompleteOrder(int customer)
        {
            order.CustomerID = customer;
            addOrder.AddNewOrder(order);
        }

    }
}
