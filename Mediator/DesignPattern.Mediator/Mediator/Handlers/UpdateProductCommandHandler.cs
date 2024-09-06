using DesignPattern.Mediator.DAL;
using DesignPattern.Mediator.Mediator.Commands;
using MediatR;

namespace DesignPattern.Mediator.Mediator.Handlers
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
    {
        private readonly Context _context;

        public UpdateProductCommandHandler(Context context)
        {
            _context = context;
        }
        public async Task Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var values =  await _context.Products.FindAsync(request.ProductID);
          
            values.ProductName = request.ProductName;
            values.ProductPrice = request.ProductPrice;
            values.ProductStock = request.ProductStock;
            values.ProductStockType = request.ProductStockType;
            values.ProductCategory = request.ProductCategory;

          await  _context.SaveChangesAsync();
        }
    }
}
