using DesignPattern.Facade.DAL;

namespace DesignPattern.Facade.Facade
{
    public class ProductStock
    {
        Context context = new Context();

        //stok azaltma
        public void StockDecrease(int id,int amount)
        {
            var value = context.Products.Find(id);
            value.ProductStock -= amount;
            context.SaveChanges();


        }

    }
}
