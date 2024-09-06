using DesignPattern.Mediator.DAL;
using DesignPattern.Mediator.Mediator.Queries;
using DesignPattern.Mediator.Mediator.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Mediator.Mediator.Handlers
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, List<GetAllProductQueryResult>>
    {
        private readonly Context _context;

        public GetAllProductQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<List<GetAllProductQueryResult>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
            return await _context.Products.Select(x => new GetAllProductQueryResult
            {
                ProductID = x.ProductID,
                ProductName = x.ProductName,
                ProductCategory = x.ProductCategory,
                ProductPrice = x.ProductPrice,
                ProductStock = x.ProductStock,
                ProductStockType = x.ProductStockType
            }).ToListAsync();
        }
    }
}
