using MediatR;

namespace DesignPattern.Mediator.Mediator.Commands
{
    public class DeleteProductCommand :IRequest
    {
        public DeleteProductCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
