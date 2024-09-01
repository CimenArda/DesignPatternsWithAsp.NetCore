using DesignPattern.CQRS.CQRSPattern.Results;
using DesignPattern.CQRS.DAL;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class GetProductQueryHandler
    {
        private readonly Context _context;

        public GetProductQueryHandler(Context context)
        {
            _context = context;
        }


        public List<GetProductQueryResult> Handle()
        {
            var values = _context.Products.Select(x=> new GetProductQueryResult
            {
                Description = x.Description,
                Name = x.Name,
                Price = x.Price,
                ProductID = x.ProductID,
                Status = x.Status,
                Stock = x.Stock
            }).ToList();

            return values;
        }
    }
}
