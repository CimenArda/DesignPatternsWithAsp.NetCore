using DesignPattern.CQRS.CQRSPattern.Commands;
using DesignPattern.CQRS.DAL;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class CreateProductCommandHandler
    {
        private readonly Context _context;

        public CreateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(CreateProductCommand command)
        {
            _context.Products.Add(new Product
            {
                Description = command.Description,
                Name = command.Name,
                Price = command.Price,
                Status = command.Status,

                Stock = command.Stock
            });

            _context.SaveChanges();
        }
    }
}
