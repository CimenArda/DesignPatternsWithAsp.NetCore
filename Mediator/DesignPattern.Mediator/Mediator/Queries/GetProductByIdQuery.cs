using DesignPattern.Mediator.Mediator.Results;
using MediatR;

namespace DesignPattern.Mediator.Mediator.Queries
{
    public class GetProductByIdQuery:IRequest<GetProductByIdQueryResult>
    {
        public GetProductByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
