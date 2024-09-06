using DesignPattern.Mediator.DAL;
using DesignPattern.Mediator.Mediator.Commands;
using MediatR;

namespace DesignPattern.Mediator.Mediator.Handlers
{
    public class AddProductCommandHandler : IRequestHandler<AddProductCommand>
    {
        private readonly Context _context;

        public AddProductCommandHandler(Context context)
        {
            _context = context;
        }
        public async Task Handle(AddProductCommand request, CancellationToken cancellationToken)
        {


            _context.Products.Add(new Product
            {
                ProductCategory=request.ProductCategory,
                ProductName=request.ProductName,
                ProductPrice=request.ProductPrice,
                ProductStock=request.ProductStock,
                ProductStockType=request.ProductStockType
            });

         await _context.SaveChangesAsync();
        }
    }
}
