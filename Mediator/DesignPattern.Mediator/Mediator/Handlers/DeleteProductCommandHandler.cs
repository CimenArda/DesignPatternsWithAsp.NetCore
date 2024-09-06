using DesignPattern.Mediator.DAL;
using DesignPattern.Mediator.Mediator.Commands;
using MediatR;

namespace DesignPattern.Mediator.Mediator.Handlers
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand>
    {
        private readonly Context _context;

        public DeleteProductCommandHandler(Context context)
        {
            _context = context;
        }
        public async Task Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
           var values = await _context.Products.FindAsync(request.Id);
             
            _context.Products.Remove(values);   

            await _context.SaveChangesAsync();

        }
    }
}
