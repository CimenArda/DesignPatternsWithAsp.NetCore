using DesignPattern.Mediator.DAL;
using DesignPattern.Mediator.Mediator.Queries;
using DesignPattern.Mediator.Mediator.Results;
using MediatR;

namespace DesignPattern.Mediator.Mediator.Handlers
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, GetProductByIdQueryResult>
    {
        private readonly Context _context;

        public GetProductByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetProductByIdQueryResult> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
           var values = await _context.Products.FindAsync(request.Id);
            return new GetProductByIdQueryResult
            {
                ProductID = values.ProductID,
                ProductName = values.ProductName,
                ProductCategory = values.ProductCategory,
                ProductPrice = values.ProductPrice,
                ProductStock = values.ProductStock,
                ProductStockType = values.ProductStockType
            }; 
        }
    }
}
