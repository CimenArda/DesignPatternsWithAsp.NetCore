using DesignPattern.CQRS.CQRSPattern.Queries;
using DesignPattern.CQRS.CQRSPattern.Results;
using DesignPattern.CQRS.DAL;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class GetProductByIdQueryHandler
    {
        private readonly Context _context;

        public GetProductByIdQueryHandler(Context context)
        {
            _context = context;
        }



        public GetProductByIdQueryResult Handle(GetProductByIdQuery query)
        {
            var values = _context.Set<Product>().Find(query.Id);

            return new GetProductByIdQueryResult
            {
                Description = values.Description,
                Name = values.Name,
                Price = values.Price,
                ProductID = values.ProductID,
                Status = values.Status,
                Stock = values.Stock
            };

        }
    }
}
